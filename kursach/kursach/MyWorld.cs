﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Threading;
using static kursach.consts;

namespace kursach
{
    class MyWorld
    {
        //behavior
        public MyWorld(DataGridView parentGrid, Label genlbl, Label num1lbl)
        {
            evoField = new Field(parentGrid);
            evoBots = new Bot[NUM_OF_BOTS];

            Random rnd = new Random();
            for (int i = 0; i < NUM_OF_BOTS; ++i)
            {
                evoBots[i] = new Bot(this, rnd);
            }
            parentGrid.ClearSelection();//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            generation = 1;
            this.genLbl = genlbl;
            this.num1 = num1lbl;
            showGeneration();

            mythread = new Thread(evolution);
            mythread.Start();
        }

        public void Initialize()
        { }

        public void Reset()
        {

        }

        public void CloseThread()
        {
            mythread.Abort();
        }

        public void NextGen()
        {
        }

        // button handlers
        public void StartEvolution()
        {
            evoField.DontDraw();
            doProcess = true;
        }

        public void PauseEvolution()
        {
            doProcess = false;
        }

        public void SeeOneGeneration()
        {
            evoField.DoDraw();
            doOneGeneration = true;
        }

        public void ResizeField()
        {
            evoField.Resize();
        }

        // end button handlers

        public int NextStep()
        {
            int aliveCounter = 0;
            for (int i = 0; i < consts.NUM_OF_BOTS; ++i)
            {
                if (evoBots[i].isSteelAlive())
                {
                    evoBots[i].DoNextStep();
                    aliveCounter++;
                }
            }
            return aliveCounter;
        }

        private void evolution()
        {
            // try to gi in permanently
            while (true)
            {
                // if we pressed Continue or See Next Generation
                if (doProcess || doOneGeneration)
                {
                    processOneGeneration();
                    doOneGeneration = false;
                }
            }
        }

        private void processOneGeneration()
        {
            int stepsWithoutFood = 0;
            evoField.PrepareFieldForGeneration();
            for (int i = 0; i < NUM_OF_BOTS; ++i)
            {
                Coord emptyPlace = evoField.GetFreeCell();
                evoBots[i].PrepareBotForNextGeneration(emptyPlace);
            }

            while (true)
            {                
                int howMuchAlive = NextStep();
                stepsWithoutFood++;
                // add some food
                if (stepsWithoutFood > MAX_STEPS_WITHOUT_FOOD)
                {
                    evoField.PutRandFood(EXTRA_FOOD_VOLUME);
                    stepsWithoutFood = 0;
                }

                if (howMuchAlive == 0)
                {
                    // go to the next generation
                    prepareNextGeneration();
                    generation++;
                    showGeneration();
                    return;
                }
                // if we see only one generation
                if (doOneGeneration)
                {
                    Thread.Sleep(TIME_TO_SLEEP_MS);
                }
            }
        }

        private void prepareNextGeneration()
        {
            evoField.ResetField();
            sortBots();
            for (int i = 0; i < NUM_OF_BOTS; ++i)
            {
                evoBots[i].ResetBot();
            }

            Random rnd = new Random();
            for (int i = 0; i < ALIVE_LIMIT; ++i)
            {
                Genom genomToCopy = evoBots[i].GetGenom();
                //int second_mutation = (generation % 1000 == 0) ? HARD_MUTATION : NORM_MUTATION;

                evoBots[ALIVE_LIMIT + i].SetGenom(genomToCopy);
                evoBots[2*ALIVE_LIMIT + i].SetGenom(genomToCopy.Mutate(SOFT_MUTATION, rnd));
                evoBots[3*ALIVE_LIMIT + i].SetGenom(genomToCopy.Mutate(NORM_MUTATION, rnd));
            }
        }

        private void sortBots()
        {
            // bubble sort
            for (int i = 0; i < NUM_OF_BOTS-1; ++i)
            {
                for (int j = 0; j < NUM_OF_BOTS - 1-i; ++j)
                {
                    if (evoBots[j].GetAge() < evoBots[j + 1].GetAge())
                    {
                        Bot temp = new Bot(evoBots[j]);
                        evoBots[j].CopyBot(evoBots[j + 1]);
                        evoBots[j+1].CopyBot(temp);
                    }
                }
            }
            num1.Text = evoBots[0].GetAge().ToString();
        }


        public int GetMaxLifeLen()
        {
            return 0;
        }

        // shared with Field ///////////////////////////////////////////////////////////////////////////////

        public CellType GetCellType(Coord dest)
        {
            return evoField.GetCellType(dest);
        }

        public Coord GetFreeCell()
        {
            return evoField.GetFreeCell();
        }

        public void KillBot(Coord dest)
        {
            evoField.KillBot(dest);
        }

        public void MoveBot(Coord from, Coord dest, int health)
        {
            evoField.MoveBot(from, dest, health);
        }

        public void PoisonToFood(Coord dest)
        {
            evoField.PoisonToFood(dest);
        }

        public void PutBot(Coord place, int health)
        {
            evoField.PutBot(place, health);
        }

        public void RemoveBot(Coord place)
        {
            evoField.RemoveBot(place);
        }

        public void RemoveFood(Coord dest)
        {
            evoField.RemoveFood(dest);
        }
        // shared with field /////////////////////////////////////////////////////////////////////////////////

        private void showGeneration()
        {
            genLbl.Text = generation.ToString();
        }

        // state
        Bot[] evoBots;
        Field evoField;

        bool doProcess = false;
        bool doOneGeneration = false;

        Label num1;
        Label genLbl;
        int generation;

        Thread mythread;
    }
}

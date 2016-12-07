using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Threading;
using System.IO;
//using static kursach.consts;


namespace kursach
{
    class MyWorld
    {
        //behavior
        public MyWorld(DataGridView parentGrid, Label genlbl, Label num1lbl)
        {
            evoField = new Field(parentGrid);
            evoBots = new Bot[Preferences.NUM_OF_BOTS_prop];

            Random rnd = new Random();
            for (int i = 0; i < Preferences.NUM_OF_BOTS_prop; ++i)
            {
                evoBots[i] = new Bot(this, rnd);
            }
            parentGrid.ClearSelection();//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            generation = 1;
            this.genLbl = genlbl;
            this.num1 = num1lbl;
            showGeneration();
            TheRnd = new Random();

            swMax = new StreamWriter(Preferences.WRITEPATH_MAXAGES_prop, true, System.Text.Encoding.Default);
            swMax.WriteLine("");
            swMax.Close();
            swAvg = new StreamWriter(Preferences.WRITEPATH_AVGAGES_prop, true, System.Text.Encoding.Default);
            swAvg.WriteLine("");
            swAvg.Close();

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
            for (int i = 0; i < Preferences.NUM_OF_BOTS_prop; ++i)
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
            swMax = new StreamWriter(Preferences.WRITEPATH_MAXAGES_prop, false, System.Text.Encoding.Default);
            swAvg = new StreamWriter(Preferences.WRITEPATH_AVGAGES_prop, false, System.Text.Encoding.Default);
            // try to go in permanently
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

        private int findAvgAge(Bot[] arr)
        {
            int summ = 0;
            for (int i = 0; i < Preferences.NUM_OF_BOTS_prop; ++i)
            {
                summ += arr[i].GetAge();
            }
            return Convert.ToInt32(summ / arr.Length);
        }

        private void processOneGeneration()
        {
            int steps = 0;

            evoField.PrepareFieldForGeneration();
            for (int i = 0; i < Preferences.NUM_OF_BOTS_prop; ++i)
            {
                Coord emptyPlace = evoField.GetFreeCell();
                evoBots[i].PrepareBotForNextGeneration(emptyPlace);
            }
            while (true)
            {                
                int howMuchAlive = NextStep();
                steps++;

                if (howMuchAlive == 0)
                {
                    // go to the next generation
                    prepareNextGeneration();
                    generation++;
                    showGeneration();

                    if (steps > 800000)
                    {
                        doProcess = false;
                    }
                    //Thread.Sleep(TIME_TO_SLEEP_BETWEEN_GEN_MS);
                    return;
                }

                // if we see only one generation
                if (doOneGeneration)
                {
                    Thread.Sleep(Preferences.TIME_TO_SLEEP_MS_prop);
                }
            }
        }

        private void prepareNextGeneration()
        {
            evoField.ResetField();
            sortBots();
            for (int i = 0; i < Preferences.NUM_OF_BOTS_prop; ++i)
            {
                evoBots[i].ResetBot();
            }

            for (int i = 0; i < Preferences.ALIVE_LIMIT_prop; ++i)
            {
                Genom genomToCopy = evoBots[i].GetGenom();
                //int second_mutation = (generation % 1000 == 0) ? HARD_MUTATION : NORM_MUTATION;

                evoBots[Preferences.ALIVE_LIMIT_prop + i].SetGenom(genomToCopy);
                evoBots[2 * Preferences.ALIVE_LIMIT_prop + i].SetGenom(genomToCopy.Mutate(Preferences.SOFT_MUTATION_prop, TheRnd));
                evoBots[3 * Preferences.ALIVE_LIMIT_prop + i].SetGenom(genomToCopy.Mutate(Preferences.NORM_MUTATION_prop, TheRnd));
                //evoBots[ALIVE_LIMIT + i].SetGenom(genomToCopy.Mutate(SOFT_MUTATION, rnd));
                //evoBots[2*ALIVE_LIMIT + i].SetGenom(genomToCopy.Mutate(NORM_MUTATION, rnd));
                //evoBots[3*ALIVE_LIMIT + i].SetGenom(genomToCopy.Mutate(HARD_MUTATION, rnd));
            }
        }

        private void sortBots()
        {
            // bubble sort
            for (int i = 0; i < Preferences.NUM_OF_BOTS_prop - 1; ++i)
            {
                for (int j = 0; j < Preferences.NUM_OF_BOTS_prop - 1 - i; ++j)
                {
                    if (evoBots[j].GetAge() < evoBots[j + 1].GetAge())
                    {
                        Bot temp = new Bot(evoBots[j]);
                        evoBots[j].CopyBot(evoBots[j + 1]);
                        evoBots[j+1].CopyBot(temp);
                    }
                }
            }
            int avgAge = findAvgAge(evoBots);
            // show on the screen
            num1.Text = evoBots[0].GetAge().ToString();
            // write max age to file
            writeMaxAge(evoBots[0].GetAge().ToString());

            writeAvgAge(avgAge.ToString());
        }

        private void writeMaxAge(string maxAge)
        {
            swMax.Write(maxAge+" ");
        }

        private void writeAvgAge(string maxAge)
        {
            swAvg.Write(maxAge + " ");
        }


        public int GetMaxLifeLen()
        {
            return 0;
        }

        // shared with Field ///////////////////////////////////////////////////////////////////////////////

        public Preferences.CellType GetCellType(Coord dest)
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
        Random TheRnd;

        Thread mythread;
        StreamWriter swMax;
        StreamWriter swAvg;
    }
}

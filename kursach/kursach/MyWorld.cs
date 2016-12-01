using System;
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
        public MyWorld(DataGridView parentGrid)
        {
            evoField = new Field(parentGrid);
            evoBots = new Bot[consts.NUM_OF_BOTS];

            Random rnd = new Random();
            for (int i = 0; i < consts.NUM_OF_BOTS; ++i)
            {
                evoBots[i] = new Bot(this, GetFreeCell(), rnd);
            }
            parentGrid.ClearSelection();

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

        public void StartEvolution()
        {
            doProcess = true;
        }

        public void PauseEvolution()
        {
            doProcess = false;
        }

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
            while (true)
            {
                if (doProcess)
                {
                    int howMuchAlive = NextStep();
                    Thread.Sleep(TIME_TO_SLEEP_MS);
                    if (howMuchAlive == 0)
                    {
                        return;
                    }
                }
            }
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


        // state
        Bot[] evoBots;

        Field evoField;

        bool doProcess = false;

        Thread mythread;
    }
}

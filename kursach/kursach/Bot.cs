using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static kursach.consts;
using System.Windows.Forms;
using System.Drawing;

namespace kursach
{
    class Bot
    {
        // behavior

        // ctor
        public Bot(MyWorld parent, Random rnd)
        {
            parentWorld = parent;

            curPlace = new Coord(0, 0);
            state = 0;
            orientation = 0;
            age = 0;
            botHealth = DEFAULT_BOT_HEALTH;
            botGenom = new Genom(rnd);
            isAlive = true;
        }

        // copy ctor
        public Bot(Bot botToCopy)
        {
            parentWorld = botToCopy.parentWorld;

            curPlace = botToCopy.curPlace;
            state = botToCopy.state;
            orientation = botToCopy.orientation;
            age = botToCopy.age;
            botHealth = botToCopy.botHealth;
            botGenom = botToCopy.botGenom;
            isAlive = botToCopy.isAlive;
        }

        // bot interface

        public void CopyBot(Bot botToCopy)
        {
            parentWorld = botToCopy.parentWorld;

            curPlace = botToCopy.curPlace;
            state = botToCopy.state;
            orientation = botToCopy.orientation;
            age = botToCopy.age;
            botHealth = botToCopy.botHealth;
            botGenom = botToCopy.botGenom;
            isAlive = botToCopy.isAlive;
        }

        // do one step
        public void DoNextStep()
        {
            int counter = MAX_BOT_ACTIONS;
            for (int i = 0; i < counter; ++i)
            {
                if (engine(state) == true || !isAlive)
                {
                    finalize();
                    return;
                }
            }

            finalize();
            return;
        }

        public int GetAge()
        {
            return age;
        }

        public Coord GetCurPlace()
        {
            return curPlace;
        }

        public Genom GetGenom()
        {
            return botGenom;
        }

        public int GetHealth()
        {
            return botHealth;
        }

        public void PrepareBotForNextGeneration(Coord emptyPlace)
        {
            curPlace = emptyPlace;
            parentWorld.PutBot(curPlace, botHealth);
        }

        public void ResetBot()
        {
            curPlace = new Coord(0,0);
            state = 0;
            orientation = 0;
            age = 0;
            botHealth = DEFAULT_BOT_HEALTH;
            // new genom will be inserted
            isAlive = true;
        }

        public void SetGenom(Genom genomToInsert)
        {
            botGenom = genomToInsert;
        }

        // private //////////////////////////////////////////////////////////////////////////////////////////

        private bool engine(int oldState)
        {
            int command = botGenom.getCommand(oldState);
            if (command > 15)
            {
                int maxActionCommand = ENABLE_TWISTS ? 31 : 23; 
                // branch on condition
                if (command > maxActionCommand)
                {
                    state = (state + command) % consts.GENOM_LENGTH;
                }
                // twist
                else if (command > 23 && ENABLE_TWISTS)
                {
                    orientation = (orientation + command) % 8;
                    state = (state + 1) % consts.GENOM_LENGTH;
                }
                // watch
                else
                {
                    int direction = handleDirectByOrientation(command % 8);
                    Coord temp = new Coord(curPlace.x + DIRECT[direction, 0], curPlace.y + DIRECT[direction, 1]);
                    CellType nextCell = parentWorld.GetCellType(temp);
                    shiftState(nextCell);
                }
                return false;
            }
            else
            {
                // hit some cell
                if (command > 7)
                {
                    hit(command % 8);
                }
                // move to some cell
                else
                {
                    move(command % 8);
                }
                return true;
            }
        }

        // end of step
        private void finalize()
        {
            botHealth -= 1;
            if (botHealth > 0)
            {
                parentWorld.PutBot(curPlace, botHealth);
            }
            if (botHealth <= 0)
            {
                kill();
                parentWorld.KillBot(curPlace);
            }
            age++;
        }

        private int handleDirectByOrientation(int direct)
        {
            return (orientation + direct) % 8;
        }

        // move action
        private void move(int moveDirect)
        {
            moveDirect = handleDirectByOrientation(moveDirect);

            Coord dest = new Coord(curPlace.x + DIRECT[moveDirect, 0], curPlace.y + DIRECT[moveDirect, 1]);
            CellType nextCell = parentWorld.GetCellType(dest);
            switch (nextCell)
            {
                case CellType.EmptyCell:
                    {
                        // remove bot from current cell
                        parentWorld.RemoveBot(curPlace);
                        // we drow him at the end
                        curPlace = dest;
                        break;
                    }
                case CellType.PoisonCell:
                    {
                        //kill bot
                        botHealth = 0;
                        kill();
                        break;
                    }
                case CellType.FoodCell:
                    {
                        // increase health
                        increaseHealth(FOOD_VOLUME);
                        parentWorld.RemoveFood(dest);
                        // and move to it
                        parentWorld.RemoveBot(curPlace);
                        curPlace = dest;
                        break;
                    }
                case CellType.WallCell:
                    {
                        //doNothing;
                        break;
                    }
                case CellType.BotCell:
                    {
                        //doNothing;
                        break;
                    }
            }
            shiftState(nextCell);
        }

        // shift state by condition
        private void shiftState(CellType nextCell)
        {
            switch (nextCell)
            {
                case CellType.EmptyCell:
                    {
                        state += 1;
                        break;
                    }
                case CellType.PoisonCell:
                    {
                        state += 2;
                        break;
                    }
                case CellType.FoodCell:
                    {
                        state += 3;
                        break;
                    }
                case CellType.WallCell:
                    {
                        state += 4;
                        break;
                    }
                case CellType.BotCell:
                    {
                        state += 5;
                        break;
                    }
            }
            state %= GENOM_LENGTH;
        }

        private void hit(int hitDirect)
        {
            hitDirect = handleDirectByOrientation(hitDirect);

            // destination point
            Coord dest = new Coord(curPlace.x + DIRECT[hitDirect, 0], curPlace.y + DIRECT[hitDirect, 1]);
            CellType nextCell = parentWorld.GetCellType(dest);
            switch (nextCell)
            {
                case CellType.EmptyCell:
                    {
                        //doNothing;
                        break;
                    }
                case CellType.PoisonCell:
                    {
                        // poison becomes food
                        parentWorld.PoisonToFood(dest);
                        break;
                    }
                case CellType.FoodCell:
                    {
                        // feed our bot
                        increaseHealth(FOOD_VOLUME);
                        parentWorld.RemoveFood(dest);
                        break;
                    }
                case CellType.WallCell:
                    {
                        //doNothing;
                        break;
                    }
                case CellType.BotCell:
                    {
                        //doNothing;
                        break;
                    }
            }
            shiftState(nextCell);
        }

        public void increaseHealth(int volume)
        {
            botHealth += volume;
            botHealth = (botHealth > DEFAULT_BOT_HEALTH) ? DEFAULT_BOT_HEALTH : botHealth;
        }

        public void decreaseHealth(int volume)
        {
            botHealth -= volume;
        }

        private void kill()
        {
            isAlive = false;
        }

        public bool isSteelAlive()
        {
            return isAlive;
        }

        //state
        MyWorld parentWorld;

        int state;
        int orientation;

        Coord curPlace;
        int botHealth;
        int age;
        Genom botGenom;
        bool isAlive;

        const int genomLen = 64;
    }
}

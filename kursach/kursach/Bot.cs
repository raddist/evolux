using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static kursach.consts;

namespace kursach
{
    class Bot
    {
        // behavior

        // ctor
        public Bot(MyWorld parent, Coord emptyCell, Random rnd)
        {
            parentWorld = parent;

            curPlace = emptyCell;
            state = 0;
            botHealth = DEFAULT_BOT_HEALTH;
            botGenom = new Genom(rnd);
            isAlive = true;

            parentWorld.PutBot(curPlace, botHealth);
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

        private bool Engine(int oldState)
        {
            int command = botGenom.getCommand(oldState);
            if (command > 15)
            {
                // branch on condition
                if (command > 23)
                {
                    state = (state + command) % consts.GENOM_LENGTH;
                }
                // watch
                else
                {
                    int direction = command % 8;
                    Coord temp = new Coord(curPlace.x + direct[direction, 0], curPlace.y + direct[direction, 1]);
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
                    Hit(command % 8);
                }
                // move to some cell
                else
                {
                    Move(command % 8);
                }
                return true;
            }
        }

        // do one step
        public void DoNextStep()
        {
            int counter = 10;
            for (int i = 0; i < counter; ++i)
            {
                if (Engine(state) == true || !isAlive)
                {
                    finalize();
                    return;
                }
            }
            
            finalize();
            return;
        }

        // end of step
        public void finalize()
        {
            botHealth -= 1;
            if (botHealth > 0)
            {
                parentWorld.PutBot(curPlace, botHealth);
            }
            if (botHealth <= 0)
            {
                Kill();
                parentWorld.KillBot(curPlace);
            }
        }

        // move action
        private void Move(int moveDirect)
        {
            Coord dest = new Coord(curPlace.x + direct[moveDirect, 0], curPlace.y + direct[moveDirect, 1]);
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
                        Kill();
                        break;
                    }
                case CellType.FoodCell:
                    {
                        // can't move to it
                        // doNothing;
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

        private void Hit(int hitDirect)
        {
            // destination point
            Coord dest = new Coord(curPlace.x + direct[hitDirect, 0], curPlace.y + direct[hitDirect, 1]);
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
                        IncreaseHealth(FOOD_VOLUME);
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

        public void IncreaseHealth(int volume)
        {
            botHealth += volume;
            botHealth = (botHealth > DEFAULT_BOT_HEALTH) ? DEFAULT_BOT_HEALTH : botHealth;
        }

        public void DecreaseHealth(int volume)
        {
            botHealth -= volume;
        }

        private void Kill()
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
        Coord curPlace;
        int botHealth;
        Genom botGenom;
        bool isAlive;

        const int genomLen = 64;
    }
}

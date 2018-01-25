using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static kursach.Preferences;
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
            botHealth = Preferences.DEFAULT_BOT_HEALTH_prop;
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
            int counter = Preferences.MAX_BOT_ACTIONS_prop;
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
            botHealth = Preferences.DEFAULT_BOT_HEALTH_prop;
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
                int maxActionCommand = Preferences.ENABLE_TWISTS_prop ? 31 : 23; 
                // branch on condition
                if (command > maxActionCommand)
                {
                    state = (state + command) % Preferences.GENOM_LENGTH_prop;
                }
                // twist
                else if (command > 23 && Preferences.ENABLE_TWISTS_prop)
                {
                    orientation = (orientation + command) % 8;
                    state = (state + 1) % Preferences.GENOM_LENGTH_prop;
                }
                // watch
                else
                {
                    int direction = handleDirectByOrientation(command % 8);
                    Coord temp = new Coord(curPlace.x + Preferences.DIRECT[direction, 0], curPlace.y + Preferences.DIRECT[direction, 1]);
                    Preferences.CellType nextCell = (Preferences.CellType)parentWorld.GetCellType(temp);
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

            Coord dest = new Coord(curPlace.x + Preferences.DIRECT[moveDirect, 0], curPlace.y + Preferences.DIRECT[moveDirect, 1]);
            Preferences.CellType nextCell = (Preferences.CellType)parentWorld.GetCellType(dest);
            switch (nextCell)
            {
                case Preferences.CellType.EmptyCell:
                    {
                        // remove bot from current cell
                        parentWorld.RemoveBot(curPlace);
                        // we drow him at the end
                        curPlace = dest;
                        break;
                    }
                case Preferences.CellType.PoisonCell:
                    {
                        //kill bot
                        botHealth = 0;
                        kill();
                        break;
                    }
                case Preferences.CellType.FoodCell:
                    {
                        // increase health
                        increaseHealth(Preferences.FOOD_VOLUME_prop);
                        parentWorld.RemoveFood(dest);
                        // and move to it
                        parentWorld.RemoveBot(curPlace);
                        curPlace = dest;
                        break;
                    }
                case Preferences.CellType.WallCell:
                    {
                        //doNothing;
                        break;
                    }
                case Preferences.CellType.BotCell:
                    {
                        //doNothing;
                        break;
                    }
            }
            shiftState(nextCell);
        }

        // shift state by condition
        private void shiftState(Preferences.CellType nextCell)
        {
            switch (nextCell)
            {
                case Preferences.CellType.EmptyCell:
                    {
                        state += 1;
                        break;
                    }
                case Preferences.CellType.PoisonCell:
                    {
                        state += 2;
                        break;
                    }
                case Preferences.CellType.FoodCell:
                    {
                        state += 3;
                        break;
                    }
                case Preferences.CellType.WallCell:
                    {
                        state += 4;
                        break;
                    }
                case Preferences.CellType.BotCell:
                    {
                        state += 5;
                        break;
                    }
            }
            state %= Preferences.GENOM_LENGTH_prop;
        }

        private void hit(int hitDirect)
        {
            hitDirect = handleDirectByOrientation(hitDirect);

            // destination point
            Coord dest = new Coord(curPlace.x + Preferences.DIRECT[hitDirect, 0], curPlace.y + Preferences.DIRECT[hitDirect, 1]);
            Preferences.CellType nextCell = parentWorld.GetCellType(dest);
            switch (nextCell)
            {
                case Preferences.CellType.EmptyCell:
                    {
                        //doNothing;
                        break;
                    }
                case Preferences.CellType.PoisonCell:
                    {
                        // poison becomes food
                        parentWorld.PoisonToFood(dest);
                        break;
                    }
                case Preferences.CellType.FoodCell:
                    {
                        // feed our bot
                        increaseHealth(Preferences.FOOD_VOLUME_prop);
                        parentWorld.RemoveFood(dest);
                        break;
                    }
                case Preferences.CellType.WallCell:
                    {
                        //doNothing;
                        break;
                    }
                case Preferences.CellType.BotCell:
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
            botHealth = (botHealth > Preferences.DEFAULT_BOT_HEALTH_prop) ? Preferences.DEFAULT_BOT_HEALTH_prop : botHealth;
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

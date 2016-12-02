using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace kursach
{
    static class consts
    {
        public static int[,] direct = { { -1, 1 }, { 0, 1 }, { 1, 1 }, { 1, 0 }, { 1, -1 }, { 0, -1 }, { -1, -1 }, { -1, 0 } };
        public enum CellType
        {
            EmptyCell,
            PoisonCell,
            FoodCell,
            WallCell,
            BotCell
        }

        public enum ActionType
        {

        }

        public static int MAX_COMMAND_NUMBER = 64 + 8 * 3; //genomLen + move + hit + watch
        public const int GENOM_LENGTH = 64;

        /*public const int FIELD_WIDTH = 25;//50
        public const int FIELD_HEIGHT = 10;//25

        // volume of things on the field
        public static int ALIVE_LIMIT = 4;

        public const int NUM_OF_BOTS = 16;//25
        public static int FOOD_VOLUME = 10;
        public static int FOOD_ON_FIELD = 10;//50
        public static int POIS_ON_FIELD = 10;//50

        // colors on the field
        public static Color CELL_COLOR = Color.White;
        public static Color BOT_COLOR = Color.Gray;
        public static Color FOOD_COLOR = Color.Green;
        public static Color POIS_COLOR = Color.Red;

        // other
        public static int TIME_TO_SLEEP_MS = 100;
        public static int DEFAULT_BOT_HEALTH = 99;
        public static int MAX_STEPS_WITHOUT_FOOD = 50;
        public static int EXTRA_FOOD_VOLUME = 5;

        // mutation parameters
        public static int SOFT_MUTATION = 5;
        public static int NORM_MUTATION = 15;
        public static int HARD_MUTATION = 50;
        
        public static int MAX_BOT_ACTIONS = 10;*/

        public const int FIELD_WIDTH = 50;//50
        public const int FIELD_HEIGHT = 25;//25

        // volume of things on the field
        public static int ALIVE_LIMIT = 16;

        public const int NUM_OF_BOTS = 64;//25
        public static int FOOD_VOLUME = 10;
        public static int FOOD_ON_FIELD = 160;//50
        public static int POIS_ON_FIELD = 160;//50

        // colors on the field
        public static Color CELL_COLOR = Color.White;
        public static Color BOT_COLOR = Color.Gray;
        public static Color FOOD_COLOR = Color.Green;
        public static Color POIS_COLOR = Color.Red;

        // other
        public static int TIME_TO_SLEEP_MS = 100;
        public static int DEFAULT_BOT_HEALTH = 99;
        public static int MAX_STEPS_WITHOUT_FOOD = 50;
        public static int EXTRA_FOOD_VOLUME = 10;

        // mutation parameters
        public static int SOFT_MUTATION = 5;
        public static int NORM_MUTATION = 15;
        public static int HARD_MUTATION = 50;

        public static int MAX_BOT_ACTIONS = 20;
    }
}

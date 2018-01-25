using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace kursach
{
    static class Preferences
    {
        public static int[,] DIRECT = { { -1, 1 }, { 0, 1 }, { 1, 1 }, { 1, 0 }, { 1, -1 }, { 0, -1 }, { -1, -1 }, { -1, 0 } };
        public enum CellType
        {
            EmptyCell,
            PoisonCell,
            FoodCell,
            WallCell,
            BotCell
        }

        // genom preferences
        static int MAX_COMMAND_NUMBER; //genomLen + move + hit + watch
        static int GENOM_LENGTH;

        static int FIELD_WIDTH;//50
        static int FIELD_HEIGHT;//25

        // volume of things on the field
        static int ALIVE_LIMIT;

        static int NUM_OF_BOTS;//25
        static int FOOD_VOLUME;
        static int FOOD_ON_FIELD;//50
        static int POIS_ON_FIELD;//50
        static int WALL_ON_FIELD;//50

        static int LEN_OF_WALL;

        // other
        static int TIME_TO_SLEEP_MS;
        static int TIME_TO_SLEEP_BETWEEN_GEN_MS;
        static int DEFAULT_BOT_HEALTH;

        // mutation parameters
        static int SOFT_MUTATION;
        static int NORM_MUTATION;
        static int HARD_MUTATION;

        static int MAX_BOT_ACTIONS;
        // */

        // enablements
        static bool ENABLE_WALLS;
        static bool ENABLE_TWISTS;

        // resources
        static string WRITEPATH_MAXAGES;
        static string WRITEPATH_AVGAGES;

        /* public const int FIELD_WIDTH = 40;//50
         public const int FIELD_HEIGHT = 20;//25

         // volume of things on the field
         public static int ALIVE_LIMIT = 8;

         public const int NUM_OF_BOTS = 32;//25
         public static int FOOD_VOLUME = 10;
         public static int FOOD_ON_FIELD = 80;//50
         public static int POIS_ON_FIELD = 80;//50

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

         public static int MAX_BOT_ACTIONS = 20;*/

        // /*
     

        // colors on the field
         static Color CELL_COLOR;
         static Color BOT_COLOR;
         static Color FOOD_COLOR;
         static Color POIS_COLOR;
         static Color WALL_COLOR;


        public static void Set_Default_Options()
        {
            CELL_COLOR = Color.White;
            BOT_COLOR = Color.Gray;
            FOOD_COLOR = Color.Green;
            POIS_COLOR = Color.Red;
            WALL_COLOR = Color.Black;


            MAX_COMMAND_NUMBER = 64 + 32;

            GENOM_LENGTH = 64;

            FIELD_WIDTH = 45;//50
            FIELD_HEIGHT = 25;//25

            // volume of things on the field
            ALIVE_LIMIT = 16;

            NUM_OF_BOTS = 64;//25
            FOOD_VOLUME = 10;
            FOOD_ON_FIELD = 100;//50
            POIS_ON_FIELD = 100;//50
            WALL_ON_FIELD = 7;//50

            LEN_OF_WALL = 4;

            // other
            TIME_TO_SLEEP_MS = 100;
            TIME_TO_SLEEP_BETWEEN_GEN_MS = 100;
            DEFAULT_BOT_HEALTH = 99;

            // mutation parameters
            SOFT_MUTATION = 5;
            NORM_MUTATION = 15;
            HARD_MUTATION = 50;

            MAX_BOT_ACTIONS = 10;
            // */

            // enablements
            ENABLE_WALLS = true;
            ENABLE_TWISTS = true;

            // resources
            /**********************************/
            //не забудь вписать нужные файлики 
            //да и просто сделай ссылки на СУЩЕСТВУЮЩИЕ! файлики
            WRITEPATH_MAXAGES = @"C:\Users\Andrey\Desktop"; 
            WRITEPATH_AVGAGES = @"C:\Users\Andrey\Desctop";
            /**********************************/
        }

        #region properties

        public static int MAX_COMMAND_NUMBER_prop
        {
            get
            {
                return MAX_COMMAND_NUMBER;
            }
            set
            {
                MAX_COMMAND_NUMBER = value;
            }
        }

        public static int GENOM_LENGTH_prop
        {
            get
            {
                return GENOM_LENGTH;
            }
            set
            {
                GENOM_LENGTH = value;
            }
        }

        public static int FIELD_WIDTH_prop
        {
            get
            {
                return FIELD_WIDTH;
            }
            set
            {
                FIELD_WIDTH = value;
            }
        }

        public static int FIELD_HEIGHT_prop
        {
            get
            {
                return FIELD_HEIGHT;
            }
            set
            {
                FIELD_HEIGHT = value;
            }
        }

        public static int ALIVE_LIMIT_prop
        {
            get
            {
                return ALIVE_LIMIT;
            }
            set
            {
                ALIVE_LIMIT = value;
            }
        }

        public static int NUM_OF_BOTS_prop
        {
            get
            {
                return NUM_OF_BOTS;
            }
            set
            {
                NUM_OF_BOTS = value;
            }
        }

        public static int FOOD_VOLUME_prop
        {
            get
            {
                return FOOD_VOLUME;
            }
            set
            {
                FOOD_VOLUME = value;
            }
        }

        public static int FOOD_ON_FIELD_prop
        {
            get
            {
                return FOOD_ON_FIELD;
            }
            set
            {
                FOOD_ON_FIELD = value;
            }
        }

        public static int POIS_ON_FIELD_prop
        {
            get
            {
                return POIS_ON_FIELD;
            }
            set
            {
                POIS_ON_FIELD = value;
            }
        }

        public static int WALL_ON_FIELD_prop
        {
            get
            {
                return WALL_ON_FIELD;
            }
            set
            {
                WALL_ON_FIELD = value;
            }
        }

        public static int LEN_OF_WALL_prop
        {
            get
            {
                return LEN_OF_WALL;
            }
            set
            {
                LEN_OF_WALL = value;
            }
        }

        public static int TIME_TO_SLEEP_MS_prop
        {
            get
            {
                return TIME_TO_SLEEP_MS;
            }
            set
            {
                TIME_TO_SLEEP_MS = value;
            }
        }

        public static int TIME_TO_SLEEP_BETWEEN_GEN_MS_prop
        {
            get
            {
                return TIME_TO_SLEEP_BETWEEN_GEN_MS;
            }
            set
            {
                TIME_TO_SLEEP_BETWEEN_GEN_MS = value;
            }
        }

        public static int DEFAULT_BOT_HEALTH_prop
        {
            get
            {
                return DEFAULT_BOT_HEALTH;
            }
            set
            {
                DEFAULT_BOT_HEALTH = value;
            }
        }

        public static int SOFT_MUTATION_prop
        {
            get
            {
                return SOFT_MUTATION;
            }
            set
            {
                SOFT_MUTATION = value;
            }
        }

        public static int NORM_MUTATION_prop
        {
            get
            {
                return NORM_MUTATION;
            }
            set
            {
                NORM_MUTATION = value;
            }
        }

        public static int HARD_MUTATION_prop
        {
            get
            {
                return HARD_MUTATION;
            }
            set
            {
                HARD_MUTATION = value;
            }
        }

        public static int MAX_BOT_ACTIONS_prop
        {
            get
            {
                return MAX_BOT_ACTIONS;
            }
            set
            {
                MAX_BOT_ACTIONS = value;
            }
        }

        public static bool ENABLE_WALLS_prop
        {
            get
            {
                return ENABLE_WALLS;
            }
            set
            {
                ENABLE_WALLS = value;
            }
        }

        public static bool ENABLE_TWISTS_prop
        {
            get
            {
                return ENABLE_TWISTS;
            }
            set
            {
                ENABLE_TWISTS = value;
            }
        }

        public static string WRITEPATH_MAXAGES_prop
        {
            get
            {
                return WRITEPATH_MAXAGES;
            }
            set
            {
                WRITEPATH_MAXAGES = value;
            }
        }

        public static string WRITEPATH_AVGAGES_prop
        {
            get
            {
                return WRITEPATH_AVGAGES;
            }
            set
            {
                WRITEPATH_AVGAGES = value;
            }
        }

        public static Color Get_CELL_COLOR
        {
            get
            {
                return CELL_COLOR;
            }
        }

        public static Color Get_BOT_COLOR
        {
            get
            {
                return BOT_COLOR;
            }
        }

        public static Color Get_FOOD_COLOR
        {
            get
            {
                return FOOD_COLOR;
            }
        }

        public static Color Get_POIS_COLOR
        {
            get
            {
                return POIS_COLOR;
            }
        }

        public static Color Get_WALL_COLOR
        {
            get
            {
                return WALL_COLOR;
            }
        }

        #endregion  

        
    }
}

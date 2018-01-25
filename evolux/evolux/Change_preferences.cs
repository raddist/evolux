using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace kursach
{
    public partial class Change_preferences : Form
    {
         int MAX_COMMAND_NUMBER; //genomLen + move + hit + watch
         int GENOM_LENGTH;

         int FIELD_WIDTH;//50
         int FIELD_HEIGHT;//25

        // volume of things on the field
         int ALIVE_LIMIT;

         int NUM_OF_BOTS;//25
         int FOOD_VOLUME;
         int FOOD_ON_FIELD;//50
         int POIS_ON_FIELD;//50
         int WALL_ON_FIELD;//50

         int LEN_OF_WALL;

        // other
         int TIME_TO_SLEEP_MS;
         int TIME_TO_SLEEP_BETWEEN_GEN_MS;
         int DEFAULT_BOT_HEALTH;

        // mutation parameters
         int SOFT_MUTATION;
         int NORM_MUTATION;
         int HARD_MUTATION;

         int MAX_BOT_ACTIONS;
        // */

        // enablements
         bool ENABLE_WALLS;
         bool ENABLE_TWISTS;

        // resources
         string WRITEPATH_MAXAGES;
         string WRITEPATH_AVGAGES;

         public Change_preferences()
         {
             InitializeComponent();

             Get_From_Preferences();
         }

         private void Change_options_Load(object sender, EventArgs e)
         {
             this.CenterToParent();
             View_Preferences();
         }

         #region work_with_Preferences
         private void Get_From_Preferences()
         {
             this.MAX_COMMAND_NUMBER = Preferences.MAX_COMMAND_NUMBER_prop;
             this.GENOM_LENGTH = Preferences.GENOM_LENGTH_prop;

             this.FIELD_WIDTH = Preferences.FIELD_WIDTH_prop;
             this.FIELD_HEIGHT = Preferences.FIELD_HEIGHT_prop;

             this.ALIVE_LIMIT = Preferences.ALIVE_LIMIT_prop;

             this.NUM_OF_BOTS = Preferences.NUM_OF_BOTS_prop;//25
             this.FOOD_VOLUME = Preferences.FOOD_VOLUME_prop;
             this.FOOD_ON_FIELD = Preferences.FOOD_ON_FIELD_prop;//50
             this.POIS_ON_FIELD = Preferences.POIS_ON_FIELD_prop;//50
             this.WALL_ON_FIELD = Preferences.WALL_ON_FIELD_prop;//50

             this.LEN_OF_WALL = Preferences.LEN_OF_WALL_prop;

             // other
             this.TIME_TO_SLEEP_MS = Preferences.TIME_TO_SLEEP_MS_prop;
             this.TIME_TO_SLEEP_BETWEEN_GEN_MS = Preferences.TIME_TO_SLEEP_BETWEEN_GEN_MS_prop;
             this.DEFAULT_BOT_HEALTH = Preferences.DEFAULT_BOT_HEALTH_prop;

             // mutation parameters
             this.SOFT_MUTATION = Preferences.SOFT_MUTATION_prop;
             this.NORM_MUTATION = Preferences.NORM_MUTATION_prop;
             this.HARD_MUTATION = Preferences.HARD_MUTATION_prop;

             this.MAX_BOT_ACTIONS = Preferences.MAX_BOT_ACTIONS_prop;
             // */

             // enablements
             this.ENABLE_WALLS = Preferences.ENABLE_WALLS_prop;
             this.ENABLE_TWISTS = Preferences.ENABLE_TWISTS_prop;

             // resources
             this.WRITEPATH_MAXAGES = Preferences.WRITEPATH_MAXAGES_prop;
             this.WRITEPATH_AVGAGES = Preferences.WRITEPATH_AVGAGES_prop;

         }

         private void Set_To_Preferences()
         {
             Preferences.MAX_COMMAND_NUMBER_prop = this.MAX_COMMAND_NUMBER;
             Preferences.GENOM_LENGTH_prop = this.GENOM_LENGTH;

             Preferences.FIELD_WIDTH_prop = this.FIELD_WIDTH;
             Preferences.FIELD_HEIGHT_prop = this.FIELD_HEIGHT;

             Preferences.ALIVE_LIMIT_prop = this.ALIVE_LIMIT;

             Preferences.NUM_OF_BOTS_prop = this.NUM_OF_BOTS;//25
             Preferences.FOOD_VOLUME_prop = this.FOOD_VOLUME;
             Preferences.FOOD_ON_FIELD_prop = this.FOOD_ON_FIELD;//50
             Preferences.POIS_ON_FIELD_prop = this.POIS_ON_FIELD;//50
             Preferences.WALL_ON_FIELD_prop =  this.WALL_ON_FIELD;//50

             Preferences.LEN_OF_WALL_prop = this.LEN_OF_WALL;

             // other
             Preferences.TIME_TO_SLEEP_MS_prop = this.TIME_TO_SLEEP_MS;
             Preferences.TIME_TO_SLEEP_BETWEEN_GEN_MS_prop = this.TIME_TO_SLEEP_BETWEEN_GEN_MS;
             Preferences.DEFAULT_BOT_HEALTH_prop = this.DEFAULT_BOT_HEALTH;

             // mutation parameters
             Preferences.SOFT_MUTATION_prop = this.SOFT_MUTATION;
             Preferences.NORM_MUTATION_prop = this.NORM_MUTATION;
             Preferences.HARD_MUTATION_prop = this.HARD_MUTATION;

             Preferences.MAX_BOT_ACTIONS_prop = this.MAX_BOT_ACTIONS;
             // */

             // enablements
             Preferences.ENABLE_WALLS_prop = this.ENABLE_WALLS;
             Preferences.ENABLE_TWISTS_prop = this.ENABLE_TWISTS;

             // resources
             Preferences.WRITEPATH_MAXAGES_prop = this.WRITEPATH_MAXAGES;
             Preferences.WRITEPATH_AVGAGES_prop = this.WRITEPATH_AVGAGES;
         }
#endregion

         private void View_Preferences()
         {
             cb_ENABLE_TWISTS.Checked = this.ENABLE_TWISTS;           
             cb_ENABLE_WALLS.Checked = this.ENABLE_WALLS;           

             tb_DEFAULT_BOT_HEALTH.Text = this.DEFAULT_BOT_HEALTH.ToString();
             tb_FIELD_HEIGHT.Text = this.FIELD_HEIGHT.ToString();
             tb_FIELD_WIDTH.Text = this.FIELD_WIDTH.ToString();
             tb_FOOD_ON_FIELD.Text = this.FOOD_ON_FIELD.ToString();
             tb_FOOD_VOLUME.Text = this.FOOD_VOLUME.ToString();
             tb_GENOM_LENGTH.Text = this.GENOM_LENGTH.ToString();
             tb_HARD_MUTATION.Text = this.HARD_MUTATION.ToString();
             tb_LEN_OF_WALL.Text = this.LEN_OF_WALL.ToString();
             tb_MAX_BOT_ACTIONS.Text = this.MAX_BOT_ACTIONS.ToString();
             tb_MAX_COMMAND_NUMBER.Text = this.MAX_COMMAND_NUMBER.ToString();
             tb_NORM_MUTATION.Text = this.NORM_MUTATION.ToString();
             tb_NUM_OF_BOTS.Text = this.NUM_OF_BOTS.ToString();
             tb_POIS_ON_FIELD.Text = this.POIS_ON_FIELD.ToString();
             tb_SOFT_MUTATION.Text = this.SOFT_MUTATION.ToString();
             tb_TIME_TO_SLEEP_BETWEEN_GEN_MS.Text = this.TIME_TO_SLEEP_BETWEEN_GEN_MS.ToString();
             tb_TIME_TO_SLEEP_MS.Text = this.TIME_TO_SLEEP_MS.ToString();
             tb_WALL_ON_FIELD.Text = this.WALL_ON_FIELD.ToString();
             tb_WRITEPATH_AVGAGES.Text = this.WRITEPATH_AVGAGES;
             tb_WRITEPATH_MAXAGES.Text = this.WRITEPATH_MAXAGES;
        }


        private void validateAndApplyMaxAges()
        {
            if (File.Exists(tb_WRITEPATH_MAXAGES.Text.Trim()))
            {
                this.WRITEPATH_MAXAGES = tb_WRITEPATH_MAXAGES.Text.Trim();
            }
            else
            {
                MessageBox.Show("недопустимое значение WRITEPATH_AVGAGES: такого файла не существует");
                tb_WRITEPATH_MAXAGES.Text = this.WRITEPATH_MAXAGES;
            }
        }
        private void validateAndApplyAvgAges()
        {
            if (File.Exists(tb_WRITEPATH_AVGAGES.Text.Trim()))
            {
                this.WRITEPATH_AVGAGES = tb_WRITEPATH_AVGAGES.Text.Trim();
            }
            else
            {
                MessageBox.Show("недопустимое значение WRITEPATH_AVGAGES: такого файла не существует");
                tb_WRITEPATH_AVGAGES.Text = this.WRITEPATH_AVGAGES;
            }
        }


        private void ch_WRITEPATH_MAXAGES_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_WRITEPATH_MAXAGES.Text = openFileDialog1.FileName;

                validateAndApplyMaxAges();
            } 
        }

        private void ch_WRITEPATH_AVGAGES_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_WRITEPATH_AVGAGES.Text = openFileDialog1.FileName;

                validateAndApplyAvgAges();
            } 
        }

       

       
        #region validating

        private void tb_MAX_COMMAND_NUMBER_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_MAX_COMMAND_NUMBER.Text, out temp))
            {
                if (temp > 32)
                {
                    this.MAX_COMMAND_NUMBER = temp;
                }
                else
                {
                    MessageBox.Show("недопустимое значение MAX_COMMAND_NUMBER: значение параметра должно быть больше 32");
                    tb_MAX_COMMAND_NUMBER.Text = this.MAX_COMMAND_NUMBER.ToString();
                }
            }
            else
            {
                MessageBox.Show("недопустимое значение MAX_COMMAND_NUMBER: введённое значение должно быть целым числом");

                tb_MAX_COMMAND_NUMBER.Text = this.MAX_COMMAND_NUMBER.ToString();
            }
        }

        private void tb_GENOM_LENGTH_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_GENOM_LENGTH.Text, out temp))
            {
                if (temp > 0)
                {
                    this.GENOM_LENGTH = temp;
                }
                else
                {
                    MessageBox.Show("недопустимое значение GENOM_LENGTH: значение параметра должно быть положительным");
                    tb_GENOM_LENGTH.Text = this.GENOM_LENGTH.ToString();
                }
            }
            else
            {
                MessageBox.Show("недопустимое значение GENOM_LENGTH: введённое значение должно быть целым числом");
                tb_GENOM_LENGTH.Text = this.GENOM_LENGTH.ToString();
            }
        }

        private void tb_FIELD_WIDTH_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_FIELD_WIDTH.Text, out temp))
            {
                if (temp > 0)
                {
                    if (temp * FIELD_HEIGHT > NUM_OF_BOTS + FOOD_ON_FIELD + POIS_ON_FIELD + ((ENABLE_WALLS) ? WALL_ON_FIELD * LEN_OF_WALL : 0))
                    {
                        this.FIELD_WIDTH = temp;
                    }
                    else
                    {
                        MessageBox.Show("недопустимое значение FIELD_WIDTH: не подходит, поверьте на слово, если я начну объяснять выйдет поэма, поэтому просто поверьте"); //это для меня слишком сложно, придумай комментарий сам
                        tb_FIELD_WIDTH.Text = this.FIELD_WIDTH.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("недопустимое значение FIELD_WIDTH: значение параметра должно быть положительным");
                    tb_FIELD_WIDTH.Text = this.FIELD_WIDTH.ToString();
                }
            }
            else
            {
                MessageBox.Show("недопустимое значение FIELD_WIDTH: введённое значение должно быть целым числом");
                tb_FIELD_WIDTH.Text = this.FIELD_WIDTH.ToString();
            }
        }

        private void tb_FIELD_HEIGHT_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_FIELD_HEIGHT.Text, out temp))
            {
                if (temp > 0)
                {
                    if (FIELD_WIDTH * temp > NUM_OF_BOTS + FOOD_ON_FIELD + POIS_ON_FIELD + ((ENABLE_WALLS) ? WALL_ON_FIELD * LEN_OF_WALL : 0))
                    {
                        this.FIELD_HEIGHT = temp;
                    }
                    else
                    {
                        MessageBox.Show("недопустимое значение FIELD_HEIGHT: не подходит, поверьте на слово, если я начну объяснять выйдет поэма, поэтому просто поверьте"); //это для меня слишком сложно, придумай комментарий сам
                        tb_FIELD_HEIGHT.Text = this.FIELD_HEIGHT.ToString();
                    }
                   
                }
                else
                {
                    MessageBox.Show("недопустимое значение FIELD_HEIGHT: значение параметра должно быть положительным");
                    tb_FIELD_HEIGHT.Text = this.FIELD_HEIGHT.ToString();
                }
            }

            else
            {
                MessageBox.Show("недопустимое значение FIELD_HEIGHT: введённое значение должно быть целым числом");
                tb_FIELD_HEIGHT.Text = this.FIELD_HEIGHT.ToString();
            }
        }

        private void tb_NUM_OF_BOTS_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_NUM_OF_BOTS.Text, out temp))
            {
                if (temp > 0)
                {
                    if (FIELD_WIDTH * FIELD_HEIGHT > temp + FOOD_ON_FIELD + POIS_ON_FIELD + ((ENABLE_WALLS) ? WALL_ON_FIELD * LEN_OF_WALL : 0))
                    {
                        this.NUM_OF_BOTS = temp;
                        this.ALIVE_LIMIT = this.NUM_OF_BOTS / 4;
                    }
                    else
                    {
                        MessageBox.Show("недопустимое значение NUM_OF_BOTS: не подходит, поверьте на слово, если я начну объяснять выйдет поэма, поэтому просто поверьте"); //это для меня слишком сложно, придумай комментарий сам
                        tb_NUM_OF_BOTS.Text = this.NUM_OF_BOTS.ToString();
                    }
                    
                }
                else
                {
                    MessageBox.Show("недопустимое значение NUM_OF_BOTS: значение параметра должно быть положительным");
                    tb_NUM_OF_BOTS.Text = this.NUM_OF_BOTS.ToString();
                }
            }

            else
            {
                MessageBox.Show("недопустимое значение NUM_OF_BOTS: введённое значение должно быть целым числом");
                tb_NUM_OF_BOTS.Text = this.NUM_OF_BOTS.ToString();
            }
        }

        private void tb_FOOD_VOLUME_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_FOOD_VOLUME.Text, out temp))
            {
                if (temp > 0)
                {
                    this.FOOD_VOLUME = temp;
                }
                else
                {
                    MessageBox.Show("недопустимое значение FOOD_VOLUME: значение параметра должно быть положительным");
                    tb_FOOD_VOLUME.Text = this.FOOD_VOLUME.ToString();
                }
            }

            else
            {
                MessageBox.Show("недопустимое значение FOOD_VOLUME: введённое значение должно быть целым числом");
                tb_FOOD_VOLUME.Text = this.FOOD_VOLUME.ToString();
            }
        }

        private void tb_FOOD_ON_FIELD_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_FOOD_ON_FIELD.Text, out temp))
            {
                if (temp >= 0)
                {
                    if (FIELD_WIDTH * FIELD_HEIGHT > NUM_OF_BOTS + temp + POIS_ON_FIELD + ((ENABLE_WALLS) ? WALL_ON_FIELD * LEN_OF_WALL : 0))
                    {
                        this.FOOD_ON_FIELD = temp;
                    }
                    else
                    {
                        MessageBox.Show("недопустимое значение FOOD_ON_FIELD: не подходит, поверьте на слово, если я начну объяснять выйдет поэма, поэтому просто поверьте"); //это для меня слишком сложно, придумай комментарий сам
                        tb_FOOD_ON_FIELD.Text = this.FOOD_ON_FIELD.ToString();
                    }
                   
                }
                else
                {
                    MessageBox.Show("недопустимое значение FOOD_ON_FIELD: значение параметра должно быть неотрицательным");
                    tb_FOOD_ON_FIELD.Text = this.FOOD_ON_FIELD.ToString();
                }
            }

            else
            {
                MessageBox.Show("недопустимое значение FOOD_ON_FIELD: введённое значение должно быть целым числом");
                tb_FOOD_ON_FIELD.Text = this.FOOD_ON_FIELD.ToString();
            }
        }

        private void tb_POIS_ON_FIELD_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_POIS_ON_FIELD.Text, out temp))
            {
                if (temp >= 0)
                {
                    if (FIELD_WIDTH * FIELD_HEIGHT > NUM_OF_BOTS + FOOD_ON_FIELD + temp + ((ENABLE_WALLS) ? WALL_ON_FIELD * LEN_OF_WALL : 0))
                    {
                        this.POIS_ON_FIELD = temp;
                    }
                    else
                    {
                        MessageBox.Show("недопустимое значение POIS_ON_FIELD: не подходит, поверьте на слово, если я начну объяснять выйдет поэма, поэтому просто поверьте"); //это для меня слишком сложно, придумай комментарий сам
                        tb_POIS_ON_FIELD.Text = this.POIS_ON_FIELD.ToString();
                    }
                    
                }
                else
                {
                    MessageBox.Show("недопустимое значение POIS_ON_FIELD: значение параметра должно быть неотрицательным");
                    tb_POIS_ON_FIELD.Text = this.POIS_ON_FIELD.ToString();
                }
            }

            else
            {
                MessageBox.Show("недопустимое значение POIS_ON_FIELD: введённое значение должно быть целым числом");
                tb_POIS_ON_FIELD.Text = this.POIS_ON_FIELD.ToString();
            }
        }

        private void tb_WALL_ON_FIELD_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_WALL_ON_FIELD.Text, out temp))
            {
                if (temp >= 0)
                {
                    if (FIELD_WIDTH * FIELD_HEIGHT > NUM_OF_BOTS + FOOD_ON_FIELD + POIS_ON_FIELD + ((ENABLE_WALLS) ? temp * LEN_OF_WALL : 0))
                    {
                        this.WALL_ON_FIELD = temp;
                    }
                    else
                    {
                        MessageBox.Show("недопустимое значение WALL_ON_FIELD: не подходит, поверьте на слово, если я начну объяснять выйдет поэма, поэтому просто поверьте"); //это для меня слишком сложно, придумай комментарий сам
                        tb_WALL_ON_FIELD.Text = this.WALL_ON_FIELD.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("недопустимое значение WALL_ON_FIELD: значение параметра должно быть неотрицательным");
                    tb_WALL_ON_FIELD.Text = this.WALL_ON_FIELD.ToString();
                }
            }

            else
            {
                MessageBox.Show("недопустимое значение WALL_ON_FIELD: введённое значение должно быть целым числом");
                tb_WALL_ON_FIELD.Text = this.WALL_ON_FIELD.ToString();
            }
        }

        private void tb_LEN_OF_WALL_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_LEN_OF_WALL.Text, out temp))
            {
                if (temp >= 0)
                {
                    if (FIELD_WIDTH * FIELD_HEIGHT > NUM_OF_BOTS + FOOD_ON_FIELD + POIS_ON_FIELD + ((ENABLE_WALLS) ? WALL_ON_FIELD * temp : 0))
                    {
                        this.LEN_OF_WALL = temp;
                    }
                    else
                    {
                        MessageBox.Show("недопустимое значение LEN_OF_WALL: не подходит, поверьте на слово, если я начну объяснять выйдет поэма, поэтому просто поверьте"); //это для меня слишком сложно, придумай комментарий сам
                        tb_LEN_OF_WALL.Text = this.LEN_OF_WALL.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("недопустимое значение LEN_OF_WALL: значение параметра должно быть неотрицательным");
                    tb_LEN_OF_WALL.Text = this.LEN_OF_WALL.ToString();
                }
            }

            else
            {
                MessageBox.Show("недопустимое значение LEN_OF_WALL: введённое значение должно быть целым числом");
                tb_LEN_OF_WALL.Text = this.LEN_OF_WALL.ToString();
            }
        }

        private void tb_TIME_TO_SLEEP_MS_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_TIME_TO_SLEEP_MS.Text, out temp))
            {
                if (temp > 10)
                {
                    this.TIME_TO_SLEEP_MS = temp;
                }
                else
                {
                    MessageBox.Show("недопустимое значение TIME_TO_SLEEP_MS: значение параметра должно быть больше 10");
                    tb_TIME_TO_SLEEP_MS.Text = this.TIME_TO_SLEEP_MS.ToString();
                }
            }

            else
            {
                MessageBox.Show("недопустимое значение TIME_TO_SLEEP_MS: введённое значение должно быть целым числом");
                tb_TIME_TO_SLEEP_MS.Text = this.TIME_TO_SLEEP_MS.ToString();
            }
        }

        private void tb_DEFAULT_BOT_HEALTH_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_DEFAULT_BOT_HEALTH.Text, out temp))
            {
                if (temp > 0)
                {
                    this.DEFAULT_BOT_HEALTH = temp;
                }
                else
                {
                    MessageBox.Show("недопустимое значение DEFAULT_BOT_HEALTH: значение параметра должно быть больше 0");
                    tb_DEFAULT_BOT_HEALTH.Text = this.DEFAULT_BOT_HEALTH.ToString();
                }
            }

            else
            {
                MessageBox.Show("недопустимое значение DEFAULT_BOT_HEALTH: введённое значение должно быть целым числом");
                tb_DEFAULT_BOT_HEALTH.Text = this.DEFAULT_BOT_HEALTH.ToString();
            }
        }

        private void tb_TIME_TO_SLEEP_BETWEEN_GEN_MS_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_TIME_TO_SLEEP_BETWEEN_GEN_MS.Text, out temp))
            {
                if (temp >= 0)
                {
                    this.TIME_TO_SLEEP_BETWEEN_GEN_MS = temp;
                }
                else
                {
                    MessageBox.Show("недопустимое значение TIME_TO_SLEEP_BETWEEN_GEN_MS: значение параметра должно быть неотрицательным");
                    tb_TIME_TO_SLEEP_BETWEEN_GEN_MS.Text = this.TIME_TO_SLEEP_BETWEEN_GEN_MS.ToString();
                }
            }

            else
            {
                MessageBox.Show("недопустимое значение TIME_TO_SLEEP_BETWEEN_GEN_MS: введённое значение должно быть целым числом");
                tb_TIME_TO_SLEEP_BETWEEN_GEN_MS.Text = this.TIME_TO_SLEEP_BETWEEN_GEN_MS.ToString();
            }
        }

        private void tb_SOFT_MUTATION_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_SOFT_MUTATION.Text, out temp))
            {
                if (temp >= 0 && temp <= 100)
                {
                    this.SOFT_MUTATION = temp;
                }
                else
                {
                    MessageBox.Show("недопустимое значение SOFT_MUTATION: значение параметра должно находиться в пределах [0; 100]");
                    tb_SOFT_MUTATION.Text = this.SOFT_MUTATION.ToString();
                }
            }

            else
            {
                MessageBox.Show("недопустимое значение SOFT_MUTATION: введённое значение должно быть целым числом");
                tb_SOFT_MUTATION.Text = this.SOFT_MUTATION.ToString();
            }
        }

        private void tb_NORM_MUTATION_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_NORM_MUTATION.Text, out temp))
            {
                if (temp >= 0 && temp <= 100)
                {
                    this.NORM_MUTATION = temp;
                }
                else
                {
                    MessageBox.Show("недопустимое значение NORM_MUTATION: значение параметра должно находиться в пределах [0; 100]");
                    tb_NORM_MUTATION.Text = this.NORM_MUTATION.ToString();
                }
            }

            else
            {
                MessageBox.Show("недопустимое значение NORM_MUTATION: введённое значение должно быть целым числом");
                tb_NORM_MUTATION.Text = this.NORM_MUTATION.ToString();
            }
        }

        private void tb_HARD_MUTATION_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_HARD_MUTATION.Text, out temp))
            {
                if (temp >= 0 && temp <= 100)
                {
                    this.HARD_MUTATION = temp;
                }
                else
                {
                    MessageBox.Show("недопустимое значение HARD_MUTATION: значение параметра должно находиться в пределах [0; 100]");
                    tb_HARD_MUTATION.Text = this.HARD_MUTATION.ToString();
                }
            }

            else
            {
                MessageBox.Show("недопустимое значение HARD_MUTATION: введённое значение должно быть целым числом");
                tb_HARD_MUTATION.Text = this.HARD_MUTATION.ToString();
            }
        }

        private void tb_MAX_BOT_ACTIONS_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (Int32.TryParse(tb_MAX_BOT_ACTIONS.Text, out temp))
            {
                if (temp > 0)
                {
                    this.MAX_BOT_ACTIONS = temp;
                }
                else
                {
                    MessageBox.Show("недопустимое значение MAX_BOT_ACTIONS: значение параметра должно быть больше 0");
                    tb_MAX_BOT_ACTIONS.Text = this.MAX_BOT_ACTIONS.ToString();
                }
            }

            else
            {
                MessageBox.Show("недопустимое значение MAX_BOT_ACTIONS: введённое значение должно быть целым числом");
                tb_MAX_BOT_ACTIONS.Text = this.MAX_BOT_ACTIONS.ToString();
            }
        }

        private void tb_WRITEPATH_MAXAGES_Validating(object sender, CancelEventArgs e)
        {
            validateAndApplyMaxAges();
        }

        private void tb_WRITEPATH_AVGAGES_Validating(object sender, CancelEventArgs e)
        {
            validateAndApplyAvgAges();
        }

        private void cb_ENABLE_WALLS_CheckedChanged(object sender, EventArgs e)
        {
            int temp = NUM_OF_BOTS + FOOD_ON_FIELD + POIS_ON_FIELD + ((cb_ENABLE_WALLS.Checked) ? WALL_ON_FIELD * LEN_OF_WALL : 0);
            if (FIELD_WIDTH * FIELD_HEIGHT > temp)
            {
                this.ENABLE_WALLS = cb_ENABLE_WALLS.Checked;
            }
            else
            {
                MessageBox.Show("недопустимое значение ENABLE_WALLS: не подходит, поверьте на слово, если я начну объяснять выйдет поэма, поэтому просто поверьте"); //это для меня слишком сложно, придумай комментарий сам
                cb_ENABLE_WALLS.Checked = this.ENABLE_WALLS;
            }

        }

        private void cb_ENABLE_TWISTS_CheckedChanged(object sender, EventArgs e)
        {
            this.ENABLE_TWISTS = cb_ENABLE_TWISTS.Checked;
        }
       
        #endregion

        #region buttons_activities

        private void btn_Set_Default_Click(object sender, EventArgs e)
        {
            Preferences.Set_Default_Options();
            Get_From_Preferences();
            View_Preferences();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Set_To_Preferences();
            this.Close();
        }        

       

        #endregion

        

      



  
      



       


    
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            /************************/
            Preferences.Set_Default_Options(); //!!добавлен метод инициализирующий переменные значениями по умолчанию
            this.CenterToScreen(); //выравнивание по центру экрана
            /************************/

          
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            mainForm newForm = new mainForm(this);
            this.Hide();
            newForm.Show();
        }

        private void moreOptionsBtn_Click(object sender, EventArgs e)
        {
            Change_preferences preferences = new Change_preferences();
            preferences.ShowDialog();
        }
    }
}

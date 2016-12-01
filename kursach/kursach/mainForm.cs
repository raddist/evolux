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
    public partial class mainForm : Form
    {
        Form1 parent;

        MyWorld evoWorld;

        public mainForm(Form1 parentForm)
        {
            InitializeComponent();

            parent = parentForm;

            evoWorld = new MyWorld(fieldDataGridView);
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            evoWorld.CloseThread();
            parent.Show();
        }

        private void seeNextGenBtn_Click(object sender, EventArgs e)
        {
            evoWorld.NextStep();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            evoWorld.StartEvolution();
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            evoWorld.PauseEvolution();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_15_3
{
    public partial class Form1 : Form
    {
        public bool secondClick=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (secondClick == false)
            {
                MessageBox.Show("Вы нажа-а-а-а-а-ли меня!");
                secondClick = true;
            }
            else
                Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_15_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (milesTBx.Text == "")
                MessageBox.Show("Выедите значение");
            else
                kmTbx.Text = "Указанное число миль равно: "+(double.Parse(milesTBx.Text) * 1.6).ToString()+" километров";
        }
    }
}

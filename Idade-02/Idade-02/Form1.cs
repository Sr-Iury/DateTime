using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idade_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataNas = dateTimePicker1.Value;
            DateTime dataATUAL = DateTime.Today;
            int idade1 = dataATUAL.Year - dataNas.Year;
            if(dataATUAL.Month >= dataNas.Month)
            {
                if (dataATUAL.Day >= dataNas.Day)
                {
                    idade.Text = idade1.ToString();
                }
                else
                {
                    idade1--;
                    idade.Text = idade1.ToString();
                }
            }
            else
            {
                idade1--;
                idade.Text = idade1.ToString();
            }
            
        }

        private void idade_Click(object sender, EventArgs e)
        {

        }
    }
}

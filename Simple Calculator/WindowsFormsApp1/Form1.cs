using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class smplCalc : Form
    {
        public smplCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valueOne = 0;
            double valueTwo = 0;
            bool number = true;

            number = (double.TryParse(valOneTextBox.Text, out valueOne) &&
                double.TryParse(valTwoTextBox.Text, out valueTwo));


            //   if (double.TryParse.valOneTextBox)


            if (number)

            {
                if (rbAdd.Checked)
                {
               resultTextBox.Text = (valueOne + valueTwo).ToString();
                }

                if (rbSubtract.Checked)
                {
                    resultTextBox.Text = (valueOne - valueTwo).ToString();
                }

                if (rbMultiply.Checked)
                {
                    resultTextBox.Text = (valueOne * valueTwo).ToString();
                }

                if (rbDivide.Checked)
                {
                    resultTextBox.Text = (valueOne / valueTwo).ToString();
                }

                

            }
                else
                    MessageBox.Show("Dude, That's Not Acceptable."); 
        }
    }
}

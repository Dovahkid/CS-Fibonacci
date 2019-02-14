using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double fibo(int n)
        {
            double dblPhi = 0;
            double dblFibAprox = 0;
            string strFibAprox = "";
            int subOfDec = 0;
            int intIndexOfDec = 0;
            double answer = 0;

            try
            {
                dblPhi = (1 + Math.Pow(5, .5)) / 2;

                dblFibAprox = (Math.Pow(dblPhi, n)) / (Math.Pow(5, .5));

                strFibAprox = Convert.ToString(dblFibAprox);
                subOfDec = strFibAprox.IndexOf(".");
                intIndexOfDec = Convert.ToInt32(strFibAprox.Substring(subOfDec + 1, 1));

                answer = intIndexOfDec > 5 ? Math.Ceiling(dblFibAprox) : Math.Floor(dblFibAprox);
                
                return answer;
            }
            catch
            {
                return 1;
            }
        }

        private void btnFib_Click(object sender, EventArgs e)
        {

            int length = -1;
            try
            {
                length = Convert.ToInt32(txtNum.Text);
            }
            catch
            {
                lblStatus.Text = "Use numbers only!";
            }

            string answers = string.Empty;

            if (radSeries.Checked == true)
            {
                for (int i = 0; i <= length; i++)
                {
                    answers += fibo(i) + ", ";
                }
            }
            else
            {
                answers += fibo(length);
            }
            lblFib.Text = answers;

        }

        private void radSeries_CheckedChanged(object sender, EventArgs e)
        {
            lblNum.Text = "How many numbers do you want to generate?";
        }

        private void radSingle_CheckedChanged(object sender, EventArgs e)
        {
            lblNum.Text = "What numbers, n, do you want to find?";
        }
    }
}

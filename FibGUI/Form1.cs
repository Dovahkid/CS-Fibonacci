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
            double dblTemp = 0;
            string strTemp = "";
            int subTemp = 0;
            int tempNum = 0;
            double answer = 0;

            try
            {
                dblPhi = (1 + Math.Pow(5, .5)) / 2;

                dblTemp = (Math.Pow(dblPhi, n)) / (Math.Pow(5, .5));
                strTemp = Convert.ToString(dblTemp);

                subTemp = strTemp.IndexOf(".");
                tempNum = Convert.ToInt32(strTemp.Substring(subTemp + 1, 1));

                answer = tempNum > 5 ? Math.Ceiling(dblTemp) : Math.Floor(dblTemp);
                
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

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgebraStringSolve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            double answer;

            try
            {
                var v = dataTable.Compute(txtEquation.Text, "");
                Double.TryParse(v.ToString(), out answer);

                txtAnswer.Text = answer.ToString("#.##");
            }
            catch (Exception)
            {
                txtAnswer.Text = "Illegal character used in expression. Please only use '+','-','*','/', '.' and digits";
            }          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

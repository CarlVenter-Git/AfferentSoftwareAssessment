using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraStringSolve
{
    public class Calculate
    {
        public String Calculation(string equation)
        {
            DataTable dataTable = new DataTable();
            string answerString;

            try
            {
                var v = dataTable.Compute(equation, ""); //Does computation via DataTable
                Double.TryParse(v.ToString(), out double answer);

                answerString = answer.ToString("#.##");

                return answerString;
            }
            catch (Exception)
            {
                answerString = "Illegal character used in expression.";

                return answerString;
            }
        }
    }
}

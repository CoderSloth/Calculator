using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using NCalc;

namespace Calculator
{
    public partial class Global
    {
        public static string Work { get; set; }

        public static string Calculate(string work)
        {
            NCalc.Expression e = new NCalc.Expression(work);
            object b = "";
            try
            {
                b = e.Evaluate();
            }
            catch (NCalc.EvaluationException x)
            {
                MessageBox.Show(x.Message);
            }
            return b.ToString();
            
        }
    }
}

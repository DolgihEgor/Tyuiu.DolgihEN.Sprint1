using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DolgihEN.Sprint1.Task7.V21.Lib
{
    public class DataService : ISprint1Task7V21
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Pow(y, x) / (Math.Cos(x) - x / 3) + (Math.Pow(Math.Sin(x), 2) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y)) * Math.Tan(x * y);
            return res;
        }
    }
}

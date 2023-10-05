using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SysoevDA.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            int num1, num2, num3;

            num3 = (int)(number % 10.0);
            num2 = (int)((number / 10.0) % 10.0);
            num1 = (int)(number / 100.0);
            var res = num1 * num2 * num3;
            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rab2
{
    class A
    {
        protected List<double> x;

        public List<double> Solution(double a, double b) {
            if (a == 0)
            {
                throw new Exception("Неправильно, попробуй еще раз!!!");
            }
            return x = new List<double>
            {
                -b / a
            };
            //Console.WriteLine("x= {0}\n", x);
            
        }
    }
}

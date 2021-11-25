using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace rab2
{
    class B : A
    {
        public List<double> Solution(double a, double b, double c) {
            //List<double> x = new List<double>();
            if (a == 0)
            {
                return Solution(b, c);
            }

            double D = Discriminant(a, b, c);
            if (D < 0)
            {
                throw new Exception("Действительных корней нет");
            }
            
            if (D == 0)
            {
               return x = new List<double>() { (-b + 0) / 2 * a };
                
            }

            return x = new List<double>() {
            (-b + Math.Sqrt(D)) / (2 * a),
            (-b - Math.Sqrt(D)) / (2 * a)
            };
    }

        protected double Discriminant( double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c; 
        }
    }
}

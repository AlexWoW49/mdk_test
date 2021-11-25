using System;
using System.Collections.Generic;
using core;
using System.Text;

namespace Prozorov
{
    class SquareEquations : LinearEquations, EquationInterfece
    {
        public List<double> solve(double a, double b, double c)
        {
            if (a == 0)
            {
                return x = solution(b, c);
            }
            ProzorovLog.getIntance().log("Определено, это ковдратное уравнение");

            double D = Discriminant(a, b, c);
            if (D < 0)
            {
                ProzorovLog.getIntance().log("Действительных корней нет");
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

        protected double Discriminant(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
    }
}

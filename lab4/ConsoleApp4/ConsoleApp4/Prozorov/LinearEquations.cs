using System;
using System.Collections.Generic;
using System.Text;

namespace Prozorov
{
    class LinearEquations
    {
        protected List<double> x;
        public List<double> solution(double a, double b)
        {
            if (a == 0)
                ProzorovLog.getIntance().log("Данное уравнение не имеет решений!!!");
            ProzorovLog.getIntance().log("Определено, это линенйное уравнение");
            return x = new List<double> { -b / a };
        }
    }
}

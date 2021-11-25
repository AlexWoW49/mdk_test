using System;
using System.Collections.Generic;
using System.IO;
using Prozorov;

namespace ConsoleApp4
{
    class Program : SquareEquations
    {
        static void Main(string[] args)
        {
            SquareEquations equations = new SquareEquations();
            Console.WriteLine("Введите a, b, c: ");
            try
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());
                ProzorovLog.getIntance().log("Введено уравнение " + a + "x^2 + " + b + "x + " + c);
                List<double> roots = equations.solve(a, b, c);
                ProzorovLog.getIntance().log("Корни уравнения: " + string.Join(" ", roots)).write();
                
            }
            catch (ProzorovException e)
            {
                ProzorovLog.getIntance().log(e.Message);
            }
            catch (IOException e)
            {
                throw new Exception("Outer", e);
            }
            ProzorovLog.getIntance().write();
        }
    }
}

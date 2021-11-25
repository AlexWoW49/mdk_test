using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rab1
{
    class Program
    {
        static void Main(string[] args) {
            A a1 = new A();
            A a2 = new A();
            A a3 = new A();
            A a4 = new A();
            B b5 = new B();

          /*b5.A = a1;
            b5.A2 = a2;
            b5.A3 = a3;
            b5.A4 = a4;*/

            b5.a = a1;
            b5.a = a2;
            b5.a = a3;
            b5.a = a4;
        }
        class A
        {

        }

        class B:A
        {
          /*public object A;
            public object A2;
            public object A3;
            public object A4;*/

            public object a;
            public void setA(object a)
            {
                this.a = a;
            }
            public object getA()
            {
                return a;
            }

        }
        
        

    }
}

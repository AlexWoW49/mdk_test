using core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prozorov
{
    class Prozorov : LogAbstract, LogInterface
    {

        private static Prozorov instance = null;
        static List<String> logs = new List<string>();

        public static Prozorov getIntance()
        {
            if (instance == null)
                instance = new Prozorov();
            return instance;
        }
        public LogInterface log(string str)
        {
            logs.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(logs.ToArray());
            return this;
        }
    }
}

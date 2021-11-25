using System;
using System.Collections.Generic;
using System.Text;
using core;

namespace Prozorov
{
    class ProzorovLog : LogAbstract, LogInterface
    {
        private static ProzorovLog instance = null;
        static List<String> logs = new List<string>();

        public static ProzorovLog getIntance()
        {
            if (instance == null)
                instance = new ProzorovLog();
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

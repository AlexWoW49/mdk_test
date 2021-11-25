using System;
using System.Collections.Generic;
using System.Text;

namespace core
{
    interface LogInterface
    {
        LogInterface log(string str);
        LogInterface write();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDelegates
{
    class MyClass
    {
        //  Delegates can be bound to instance members as well as 
        //  static class functions

        public string InstanceMethod1(int arg1, int arg2)
        {
            return ((arg1 + arg2) * arg1).ToString();
        }

    }
}

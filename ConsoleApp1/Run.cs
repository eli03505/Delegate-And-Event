using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void Ffunc(string data);

    class Run
    {
        public void RunFunc(Ffunc func, string str)
        {
            func.Invoke(str);
        }
    }
}
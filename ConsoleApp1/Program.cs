using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            MyClass cls = new MyClass();
            Ffunc funcDell = new Ffunc(cls.Space);
            funcDell += cls.Reverse;

            Run run = new Run();
            run.RunFunc(funcDell, str);
        }
    }
}
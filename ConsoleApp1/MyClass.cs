using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass
    {
        public void Reverse(string str)
        {
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            string s = new string(charArr);
            Console.WriteLine(s);
        }
        public void Space(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                stringBuilder.Append(str[i]);
                if (i != str.Length - 1)
                    stringBuilder.Append('_');
            }

            string s = stringBuilder.ToString();
            Console.WriteLine(s);
        }

    }
}

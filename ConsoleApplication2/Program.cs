using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
Hashtable test=new Hashtable();

            test.Add("9","abc");
            test.Add("8","def");

            foreach (string b in test.Keys)
            {
              Console.WriteLine(b);
                Console.ReadLine();
            }
            foreach (string b in test.Values)
            {
                Console.WriteLine(b);
                Console.ReadLine();
            }


        }
    }
}

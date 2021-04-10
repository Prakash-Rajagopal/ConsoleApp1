using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b;

            b = a++;
            Console.WriteLine("a is : {0}", a);
            Console.WriteLine("b is : {0}", b);

            b = ++a;
            Console.WriteLine("a is : {0}", a);
            Console.WriteLine("b is : {0}", b);

            b = a--;
            Console.WriteLine("a is : {0}", a);
            Console.WriteLine("b is : {0}", b);

            b = --a;
            Console.WriteLine("a is : {0}", a);
            Console.WriteLine("b is : {0}", b);

            Console.ReadLine();
        }
    }
}

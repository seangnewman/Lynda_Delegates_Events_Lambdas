using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDelegates
{
    
    class Program
    {
        static string Func1(int a, int b)
        {
            return (a + b).ToString();
        }

        static string Func2(int a, int b)
        {
            return (a * b).ToString();
        }
        // INSERT DELEGATES HERE

        static void Main(string[] args)
        {
            MyDelegate F = Func1;
            Console.WriteLine("The number is : " + F(10,10));

            F = Func2;
            Console.WriteLine("The number is : " + F(10, 10));

            MyClass mc = new MyClass();
            F = mc.InstanceMethod1;
            Console.WriteLine("The number is : " + F(10,20));


            Console.WriteLine("\nPress Enter Key to Continue...");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.if_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the test that can be either true or falsw 
            bool isMale = true;
            if(isMale)
            {
                Console.WriteLine("You are male");
            }
            else
            {
                Console.WriteLine("You are female");
            }
            //can also test 2 condition with and ie && in c#, or is ||
            bool isTall = false;
            if (isTall && isMale)
            {
                Console.WriteLine("You are both male and tall.");
            }
            else if(!isTall && isMale)
            {
                Console.WriteLine("You are not tall but you are male");
            }
            else { Console.WriteLine("You are either not tall or not male"); }
Console.ReadLine(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingScope
{
    class Program
    {

        private static string k = String.Empty;

        static void Main(string[] args)
        {
            // courtesy of Bob Tabor, I'll re-do one of his oh-so-good lessons from yonder year
            // just so I've got some code that I can blame on someone else
            // (like I'm trying to make myself out to be some kind of professional or something.... SHYAH!)


            string j = String.Empty;

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(i);
                k = i.ToString();
                j = i.ToString();

            }

            Console.WriteLine("Outside of for, j = " +j);

            Console.WriteLine("Static field k = " + k);

            helperMethod();


            
            Console.ReadLine();

        }

        static void helperMethod()
        {
            Console.WriteLine("k from helperMethod: " + k);
        }
    }
}

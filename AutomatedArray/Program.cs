/*
   Author: Mikessa Fribley
   Date: 1/28/2019
   Comments: This C# Console application code demonstrates the use of an
             automatically populated Array.
*/

using System;

namespace AutomatedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Users are not required to enter input into this application.
               The application will run and execute the code on its own.
            */
            Console.WriteLine("This Array contains 25 elements.");
            Console.WriteLine("");

            /*
               Since user input is not required, the try catch block
               will be used to catch mistakes within the code being written.
            */
            try
            {
                // The Array will automatically be populated.
                int[] countdown = new int[26];

                // The Array will be iterated using a For Loop.
                for (int i = 1; i < 26; i++)
                {
                    countdown[i] = 25;
                    Console.WriteLine("Element value = " + i);
                    Console.WriteLine("");
                } // End of For Loop.

                Console.Write("Press any key to exit the application.");
                Console.ReadKey(true);
            } // End of try.

            catch
            {
                Console.Write("Press any key to exit the application.");
                Console.ReadKey(true);
            } // End of catch.
        } // End of main.
    } // End of class.
}// End of namespace.

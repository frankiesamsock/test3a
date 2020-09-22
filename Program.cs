using System;

namespace test3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                //Gather information from user
                string input = Console.ReadLine();


                if (input == "Tom Brady")
                {
                    Console.WriteLine("Hello " + input.ToString() + "!");
                    Console.WriteLine("Go Bucs!");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (input == "Victor Hedman")
                {
                    Console.WriteLine("Hello " + input.ToString() + "!");
                    Console.WriteLine("Go Bolts!");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (input == "Austin Meadows")
                {
                    Console.WriteLine("Hello " + input.ToString() + "!");
                    Console.WriteLine("Go Rays!");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Hello " + input.ToString() + "!");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
            }//END TRY
            catch
            {
                Console.WriteLine("A problem has occured, please try again...");
                Console.WriteLine("Press any key to exit and try again");
                Console.ReadKey(true);
            }
        }
    }
}

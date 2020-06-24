using System;

namespace HelloWorld
{
    class Problem1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bibu!");
            Console.WriteLine("Press the ENTER key to close the program");
            
            String line = Console.ReadLine();

if(line == "enter")
{
    System.Environment.Exit(0);
}
            
        }


    }
}

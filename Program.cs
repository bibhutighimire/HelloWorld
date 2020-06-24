using System;

namespace HelloWorld
{
    class Program
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

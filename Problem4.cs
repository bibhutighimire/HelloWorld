using System;

namespace HelloWorld
{
    class Problem4
    {
        static void Main(string[] args)     
{
    
    Console.WriteLine("What is your age?");
    int userAge= Convert.ToInt32(Console.ReadLine());

    int numberOfDiners= Convert.ToInt32(Console.ReadLine());

    double yearOfBirth=2020-numberOfDiners;
    Console.WriteLine("\nYou were born in the year of {0}",yearOfBirth);
Console.ReadLine();
}

    }
}

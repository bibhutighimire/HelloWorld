using System;

namespace HelloWorld
{
    class Problem3

    {
        static void Main(string[] args)
{
    
    Console.WriteLine("Please enter the total bill amount!");
    double totalBillAmount= Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Please enter the number of diners and then i will give you the equal split!");
    int numberOfDiners= Convert.ToInt32(Console.ReadLine());

    double equalSplit=totalBillAmount/numberOfDiners;
    Console.WriteLine("\nYou will each pay ${0} .\nDon't forget to tip",equalSplit);
Console.ReadLine();
}

    }
}

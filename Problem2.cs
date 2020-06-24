using System;

namespace HelloWorld
{
    class Problem2
    {
        static void Main(string[] args)
        
{
    
    Console.WriteLine("Please enter any integer and i will give you the cube of that integer!");
    int numberFromUser= Convert.ToInt32(Console.ReadLine());
    int result=numberFromUser*numberFromUser*numberFromUser;
    Console.WriteLine("The cube root of {0} is:{1}",numberFromUser,result);
    Console.ReadLine();
}

    }
}

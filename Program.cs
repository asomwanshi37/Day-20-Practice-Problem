using System;

namespace Day20_Regex
{
    class Program
    {
        static void Main(string[] args)
        {     string name3;
            bool result3;


            UC3 email = new UC3();
            // Console.WriteLine("Enter First Character in Bolt Latters...");
            Console.WriteLine("Enter the Email Address");

            name3 = Console.ReadLine();

            result3 = email.emailCheck(name3);
            Console.WriteLine(result3);

            }
       }
}

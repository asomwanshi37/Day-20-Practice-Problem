using System;

namespace Day20_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
          string name7;
            bool result7;


            UC7 Passwordnum = new UC7();
            Console.WriteLine("Password should contain 1 numric");
            Console.WriteLine("Enter the Password");

            name7 = Console.ReadLine();

            result7 = Passwordnum.PasswordnumCheck(name7);
            Console.WriteLine(result7);

            
          }
     }
}

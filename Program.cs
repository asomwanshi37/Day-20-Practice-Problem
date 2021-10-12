using System;

namespace Day20_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
          string name6;
            bool result6;


            UC6 Passwordupp = new UC6();
            Console.WriteLine("Password should contain 1 Upper Latter");
            Console.WriteLine("Enter the Password");

            name6 = Console.ReadLine();

            result6 = Passwordupp.PasswordUppCheck(name6);
            Console.WriteLine(result6);

            
         }
    }
}

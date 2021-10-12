sing System;

namespace Day20_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
         string name8;
            bool result8;


            UC8 Passwordspecial = new UC8();
            Console.WriteLine("Password should contain 1 Special Character");
            Console.WriteLine("Enter the Password");

            name8 = Console.ReadLine();

            result8 = Passwordspecial.PasswordSpecialCheck(name8);
            Console.WriteLine(result8);

        }   
    }
}

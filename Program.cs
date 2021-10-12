using System;

namespace Day20_Regex
{
    class Program
    {
        static void Main(string[] args)
        {   UC4 Email = new UC4();
            Console.WriteLine("Enter Country code in start  eg(91) for India");
            Console.WriteLine("Enter the Phone Number");

            name4 = Console.ReadLine();

            result4 = Email.PhonenumberCheck(name4);
            Console.WriteLine(result4);

            }
      }
}

using System;

namespace Age
{
    class Age
    {
        static void Main()
        {
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime dateNow = DateTime.Now;
            int age = dateNow.Year - birthday.Year;
                                         
            Console.WriteLine(age);
            Console.WriteLine(age+10);
        }
    }
}

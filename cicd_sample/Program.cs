using System;

namespace cicd_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var cal = new Calculation(1, 4);
            Console.WriteLine(cal.Add());
        }
    }
}

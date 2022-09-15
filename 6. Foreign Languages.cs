using System;

namespace _6._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            if (name == "England" || name == "USA")
            {
                Console.WriteLine("English");
            }else if (name == "Spain" || name == "Argentina" || name == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else { Console.WriteLine("unknown"); }
        }
    }
}

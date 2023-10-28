using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5.1);
            Shape rectangle = new Rectangle(2.8,8.2);

            //abstract class, NEW'lenemez!


            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");




            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Shape //bir class oluşturduk
    {
        public abstract double CalculateArea();
        //bu classtan miras alan adamlar bunu OVERRIDE ETSİN!
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

    }




}

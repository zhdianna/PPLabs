using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        public double radius;
        public double area;
        public double diameter;
        public double perimeter;
        public const double pi = 3.14159;

        public Circle()
        {
            radius = 5;
        }

        public void findArea() {
            area = pi * radius * radius;
        }

        public void findPerimetr()
        {
            perimeter = 2 * pi * radius;
        }

        public void findDiameter()
        {
            diameter = 2 * radius;
        }
        public override string ToString()
        {
            return radius + "\n" + perimeter + "\n" + diameter;
        }


        static void Main(string[] args)
        {
            Circle r = new Circle();
            r.findArea();
            r.findDiameter();
            r.findPerimetr();
            
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}

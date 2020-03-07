using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your desired geometrical object:");
            var calculateArea = Console.ReadLine();

            // CIRCLE (круг)
            if ((calculateArea == "circle") || (calculateArea == "Circle") || (calculateArea == "CIRCLE"))
            {
                double r, per_cir;
                double PI = 3.14;

                Console.WriteLine("Input the radius of the circle : ");
                r = Convert.ToInt32(Console.ReadLine());

                per_cir = 2 * PI * r;

                Console.WriteLine("Perimeter of your circle is " + per_cir);
                Console.ReadLine();
            }

            //else
            //{
            //    Console.WriteLine("Please Enter a Valid Geometrical Object");
            //    Console.ReadLine();
            //}

            // RECTANGLE (правоаголник)
            if ((calculateArea == "rectangle") || (calculateArea == "Rectangle") || (calculateArea == "RECTANGLE"))
            {
                double l, w;

                Console.WriteLine("Enter the length of the rectangle");
                l = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the width of the rectangle");
                w = Convert.ToDouble(Console.ReadLine());

                var per_rec = l * w;
                Console.WriteLine("Perimeter of your rectangle is " + per_rec);
                Console.ReadLine();

            }

            // SQUARE (квадрат)
            if ((calculateArea == "square") || (calculateArea == "Square") || (calculateArea == "SQUARE"))
            {
                double a;

                Console.WriteLine("Enter the length of the square side");
                a = Convert.ToDouble(Console.ReadLine());

                var per_squ = a * a;
                Console.WriteLine("Area of the square is" + per_squ);
                Console.ReadLine();
            }

            // ELLIPSE (кружница)
            if ((calculateArea == "ellipse") || (calculateArea == "Ellipse") || (calculateArea == "ELLIPSE"))
            {
                double r1, r2;
                double PI = 3.14;

                Console.WriteLine("Enter the first, smaller radius:");
                r1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second, bigger radius:");
                r2 = Convert.ToDouble(Console.ReadLine());

                var per_ell = r1 * r2 * PI;
                Console.WriteLine("Area of ellipse is" + per_ell);
                Console.ReadLine();

            }

            
            // TRAPEZOID (трапез)

            if ((calculateArea == "trapezoid") || (calculateArea == "Trapezoid") || (calculateArea == "TRAPEZOID"))
            {
                double a1, b1, h1;
                Console.WriteLine("Enter the length of the first side:");
                a1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the length of the second side");
                b1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the height of the trapezoid:");
                h1 = Convert.ToDouble(Console.ReadLine());

                var per_tra = ((a1 + b1) / 2) * h1;
                Console.WriteLine("Area of Trapezoid is" + per_tra);
                Console.ReadLine();
            }

            // RHOMBUS (Ромб)

            if ((calculateArea == "rhombus") || (calculateArea == "Rhombus") || (calculateArea == "RHOMBUS"))
            {
                double d1, d2;
                Console.WriteLine("Enter the length of the first diagonal:");
                d1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the length of the second diagonal:");
                d2 = Convert.ToDouble(Console.ReadLine());

                var per_rho = (d1 * d2) / 2;
                Console.WriteLine("The area of the given rhombus is " + per_rho);
            }


            // PARALLELOGRAM (паралелограм)
            if ((calculateArea == "parallelogram") || (calculateArea == "Parallelogram") || (calculateArea == "PARALLELOGRAM"))
            {
                double x, y;
                Console.WriteLine("Enter the length of the side:");
                x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the length of the height:");
                y = Convert.ToDouble(Console.ReadLine());

                var per_par = x * y;
                Console.WriteLine("The area of the given parallelogram is" + per_par);
            }


            // TRIANGLE (триаголник)
            if ((calculateArea == "triangle") || (calculateArea == "Triangle") || (calculateArea == "TRIANGLE"))
            {
                Console.WriteLine("Please Specify the type of triangle");
                string type = Console.ReadLine();

                if ((type == "Equilateral") || (type == "equilateral") || (type == "EQUILATERAL")) {
                    double z;
                    Console.WriteLine("Enter the length of the side:");
                    z = Convert.ToDouble(Console.ReadLine());

                    double sqrt = 0.4330127018922193;

                    var per_tri1 = sqrt * z * z;
                    Console.WriteLine("The area of the equilateral triangle is:" + per_tri1);
                }

            if ((type == "Isosceles") || (type == "isosceles") || (type == "ISOSCELES"))
                {
                    double b2, hb;

                    Console.WriteLine("Enter the length of the side b:");
                    b2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the length of the height:");
                    hb = Convert.ToDouble(Console.ReadLine());

                    var per_isos = (b2 * hb) / 2;
                    Console.WriteLine("The area of the isosceles triangle is" + per_isos);
                }

            if ((type == "Scalene") || (type == "scalene") || (type == "SCALENE"))
                {
                    double b3, hc;

                    Console.WriteLine("Enter the length of the side b:");
                    b3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the length of the height:");
                    hc = Convert.ToDouble(Console.ReadLine());

                    var per_isos = (b3 * hc) / 2;
                    Console.WriteLine("The area of the scalene triangle is" + per_isos);
                }
            }
        }
    }
}
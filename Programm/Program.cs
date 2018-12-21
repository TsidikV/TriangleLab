using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleNS;

namespace Programm
{
    class Program
    {
        static void Main(string[] args)
        {
            bool can = false;
            //bool flag = false;
             
            Triangle[] tri = new Triangle[10];
            tri[0] = new Triangle(0, 0, 1, 0, 0, 1);
            tri[1] = new Triangle(-2, 0, 2, 0, 0, 3);
            tri[2] = new Triangle(0, 0, 0, 8, 8, 8);
            tri[3] = new Triangle(-2, 0, 2, 0, 0, -Math.Sqrt(12));
            tri[4] = new Triangle(3, 0, 9, 0, 6, Math.Sqrt(27));
            tri[5] = new Triangle(0, 5, 0, 10, -6, 7.5);
            tri[6] = new Triangle(0, 0, 3, 0, -4, 2);
            tri[7] = new Triangle(4, -5, 1, 0, 0, 1);
            tri[8] = new Triangle(-7, 5, -2, 3, 0, 1);
            tri[9] = new Triangle(0, 0, 7, 5, 3, 2);


            int[] mas  = new int[4];
            double[] plos = new double[4];
            double var1 = 0;
            int[] nom  = new int[4];

            for(int i=0; i < 10; i++)
            {
                can = tri[i].CanBe();

                if (can == true)
                {
                    if (tri[i].Rectangled())
                    {
                        Console.WriteLine("Треугольник под номером {0} - прямоугольный", i);
                        var1 = tri[i].Square();
                        if (var1 > plos[0])
                        {
                            plos[0] = var1;
                            nom[0] = i;
                        }
                        mas[0]++;
                    }
                    if (tri[i].Isosceles())
                    {
                        Console.WriteLine("Треугольник под номером {0} - равнобедренный", i);
                        var1 = tri[i].Square();
                        if (var1 > plos[1])
                        {
                            plos[1] = var1;
                            nom[1] = i;
                        }
                        mas[1]++;
                    }
                    if (tri[i].Equilateral())
                    {
                        Console.WriteLine("Треугольник под номером {0} - равносторонний", i);
                        var1 = tri[i].Square();
                        if (var1 > plos[2])
                        {
                            plos[2] = var1;
                            nom[2] = i;
                        }
                        mas[2]++;
                    }
                    if (tri[i].Versatile())
                    {
                        Console.WriteLine("Треугольник под номером {0} - обычный", i);
                        var1 = tri[i].Square();
                        if (var1 > plos[3])
                        {
                            plos[3] = var1;
                            nom[3] = i;
                        }
                        mas[3]++;
                    }
                }
                else tri[i] = new Triangle(0, 0, 0, 0, 0, 0);
            }

            Console.WriteLine("Количество треугольников:");
            Console.WriteLine("     прямоугольных  - {0}", mas[0]);
            Console.WriteLine("     равнобедренных - {0}", mas[1]);
            Console.WriteLine("     равносторонних - {0}", mas[2]);
            Console.WriteLine("     простых        - {0}", mas[3]);

            Console.WriteLine("Наибольшая площадь среди");
            Console.WriteLine("     прямоугольных треугольников  у номера {1} - {0}", plos[0], nom[0]);
            Console.WriteLine("     равнобедренных треугольников у номера {1} - {0}", plos[1], nom[1]);
            Console.WriteLine("     равносторонних треугольников у номера {1} - {0}", plos[2], nom[2]);
            Console.WriteLine("     простых треугольников        у номера {1} - {0}", plos[3], nom[3]);
        }
    }
}

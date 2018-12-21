using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleNS
{
    public class Triangle
    {
        private double ax; // координаты по Х первой вершины
        private double ay; // координаты по Y первой вершины
        private double bx; // координаты по Х второй вершины
        private double by; // координаты по Y второй вершины
        private double cx; // координаты по Х третьей вершины
        private double cy; // координаты по Y третьей вершины
        private double AB;
        private double AC;
        private double BC; // стороны треугольника

        public Triangle()
        {
            this.ax = 0; this.ay = 0;
            this.bx = 0; this.by = 0;
            this.cx = 0; this.cy = 0;
        }

        public Triangle(double ax, double ay, double bx, double by, double cx, double cy)
        {
            this.ax = ax; this.ay = ay;
            this.bx = bx; this.by = by;
            this.cx = cx; this.cy = cy;
            this.AB = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
            this.AC = Math.Sqrt((cx - ax) * (cx - ax) + (cy - ay) * (cy - ay));
            this.BC = Math.Sqrt((cx - bx) * (cx - bx) + (cy - by) * (cy - by));
        }


        public bool CanBe()
        {
            if ((AB + AC) < BC && (AC + BC) < AB && (BC + AB) < AC)
            {
                Console.WriteLine("Ошибка! Неверный треугольник!");
                return false;
            }
            else
            {
                Console.WriteLine("Треугольник построен верно!");
                return true;
            }
        }

        public double Perimetr()
        {
            return AB + AC + BC;
        }

        public double Square()
        {
            return AB * Hight("AB") / 2;
        }

        public bool Rectangled() // прямоугольный
        {
            if (Math.Round(AB * AB + AC * AC) == Math.Round(BC * BC) ||
                Math.Round(AB * AB) == Math.Round(AC * AC + BC * BC) ||
                Math.Round(AC * AC) == Math.Round(AB * AB + BC * BC))
                return true;
            return false;
        }

        public bool Isosceles() // равнобедренный
        {
            if (AB == AC || AC == BC || AB == BC)
                return true;
            return false;
        }

        public bool Equilateral() // правильный
        {
            if (AB == AC && AC == BC)
                return true;
            return false;
        }

        public bool Versatile() // обычный
        {
            if (AB != AC && AC != BC && BC != AB)
                return true;
            return false;
        }

        public double Hight(string storona)
        {
            double p = Perimetr() / 2;
            double temp = Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));
            temp = temp * 2;
            switch (storona)
            {
                case "AB":
                    {
                        return temp / AB;
                    }
                case "AC":
                    {
                        return temp / AC;
                    }
                case "BC":
                    {
                        return temp / BC;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }

        public double getAB()
        {
            return AB;
        }

        public double getAC()
        {
            return AC;
        }

        public double getBC()
        {
            return BC;
        }
    }
}

using System;

namespace oop4_2
{
    class Square
    {
        private double x1, y1, x2, y2;

        public double X1
        {
            get { return x1; }
            set { x1 = value; }
        }

        public double Y1
        {
            get { return y1; }
            set { y1 = value; }
        }

        public double X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public double Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        public double SideLength
        {
            get { return CalculateSideLength(); }
        }

        public double Area
        {
            get { return CalculateArea(); }
        }

        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }

        public void Init(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2 || y1 == y2)
            {
                throw new ArgumentException("Некоректнi координати. Дiагональнi точки не повиннi лежати на однiй прямiй.");
            }

            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void Read()
        {
            Console.WriteLine("Введiть координати дiагоналi (x1, y1, x2, y2):");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            Init(x1, y1, x2, y2);
        }

        public void Display()
        {
            Console.WriteLine("Точки дiагоналi квадрата:");
            Console.WriteLine($"Точка 1: ({x1}, {y1})");
            Console.WriteLine($"Точка 2: ({x2}, {y2})");
            Console.WriteLine($"Довжина сторони: {SideLength}");
            Console.WriteLine($"Площа: {Area}");
            Console.WriteLine($"Периметр: {Perimeter}");
        }

        private double CalculateSideLength()
        {
            double sideLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return sideLength;
        }

        private double CalculateArea()
        {
            double sideLength = CalculateSideLength();
            double area = Math.Pow(sideLength, 2);
            return area;
        }

        private double CalculatePerimeter()
        {
            double sideLength = CalculateSideLength();
            double perimeter = 4 * sideLength;
            return perimeter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square square = MakeSquare();
            square.Display();
        }

        static Square MakeSquare()
        {
            try
            {
                Square square = new Square();
                Console.WriteLine("Введiть координати дiагоналi квадрата:");
                double x1 = Convert.ToDouble(Console.ReadLine());
                double y1 = Convert.ToDouble(Console.ReadLine());
                double x2 = Convert.ToDouble(Console.ReadLine());
                double y2 = Convert.ToDouble(Console.ReadLine());

                square.Init(x1, y1, x2, y2);
                return square;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
                Environment.Exit(0);
                return null; 
            }
        }
    }
}


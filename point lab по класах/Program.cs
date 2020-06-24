using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tochku

{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            Console.WriteLine("Введіть X координату точки:");
            point.X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть Y координату точки:");
            point.Y1 = Convert.ToInt32(Console.ReadLine());


            point.ToStart();


            Console.WriteLine("Введіть значення на яке змінити координату x");
            int a = Convert.ToInt32(Console.ReadLine());
            point.MoveOnX(a);

            Console.WriteLine("Введіть значення на яке змінити координату y");
            int b = Convert.ToInt32(Console.ReadLine());
            point.MoveOnY(b);


            Console.WriteLine("Введіть х координату для другої точки");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть y координату для другої точки");
            b = Convert.ToInt32(Console.ReadLine());


            point.DistanceToPoint(a, b);


            Console.ReadKey();

        }
    }
    class Point
    {
        int x1, y1;
        public void ToStart()
        {
            double lenght = Math.Sqrt(Math.Pow(0 - x1, 2) + Math.Pow(0 - y1, 2));
            Console.WriteLine("Відстань від  точки: [{0};{1}] до початку координат дорівнює {2}", x1, y1, lenght);
        }

        public void MoveOnX(int a)
        {
            x1 = x1 + a;
            Console.WriteLine("Координати точки: [{0}; {1}]", x1, y1);
        }
        public void MoveOnY(int a)
        {
            y1 = y1 + a;
            Console.WriteLine("Координати точки: [{0}; {1}]", x1, y1);
        }

        public void DistanceToPoint(int x2, int y2)
        {
            double lenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Відстань від точки [{0};{1}] до точки [{2};{3}] Дорівнює {4}", x1, y1, x2, y2, lenght);
        }

        public Point()
        {
            x1 = 0;
            y1 = 0;
        }

        public Point(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        public int X1
        {
            set { x1 = value; }
            get { return x1; }
        }
        public int Y1
        {
            set { y1 = value; }
            get { return y1; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IPrint
    {
        void print_S();
    }
    //-----------------------------------------------------
    abstract class geometric_figures : IPrint
    {

        public string name { get; set; }
        public override string ToString()
        {
            return string.Format("Тип фигуры - {0} \n", name);
        }
        public void print_S()
        {
            Console.WriteLine(this);
        }
    }
    //-----------------------------------------------------
    class rectangle : geometric_figures
    {
        public int side_a;
        public int side_b;
        public rectangle()
        {
            side_a = 0;
            side_b = 0;
            name = "Прямоуголник";
        }
        public rectangle(int side_a, int side_b)
        {
            this.side_a = side_a;
            this.side_b = side_b;
            name = "Прямоуголник";
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("а = {0} , b = {1} , S = {2}", side_a, side_b, side_a * side_b);
        }
    }
    //-----------------------------------------------------
    class square : rectangle
    {

        public square()
        {
            side_a = 0;
            name = "Квадрат";
        }
        public square(int side)
        {
            this.side_a = side;
            name = "Квадрат";
        }
        public override string ToString()
        {
            return string.Format("Тип фигуры - {0} \nСтороны квардарат равны = {1}, S = {2}", name, side_a, side_a * side_a);
        }
    }
    //-----------------------------------------------------
    class circle : geometric_figures
    {
        public double R;

        public circle()
        {
            R = 0;
            name = "Круг";
        }
        public circle(double R)
        {
            this.R = R;
            name = "Круг";
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("R = {0} , S = {1}", R, Math.PI * Math.Pow(R, 2));
        }
    }
    //-----------------------------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            rectangle four_ygl = new rectangle(5, 7);
            four_ygl.print_S();
            square kvadr = new square(10);
            kvadr.print_S();
            circle circ = new circle(33);
            circ.print_S();

            Console.ReadKey();
        }
    }
}

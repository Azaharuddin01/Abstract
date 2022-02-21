using System;
namespace Abstract
{
    abstract class Rectangle
    {
        public int a;
        public int b;
        public abstract void area(int a, int b);
        public void parameter(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine(2 * this.a * this.b);
        }
    }
    class Squre : Rectangle
    {
        public override void area(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine(this.a * this.b);

        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Squre obj = new Squre();
            obj.parameter(10, 20);
            obj.area(20, 30);
        }
    }
}

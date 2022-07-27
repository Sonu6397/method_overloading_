using System;

namespace method_overloading_
{
    class Demo
    {
        public void Show(int x, int y)
        {
            Console.WriteLine(x+y);
        }

        public void Show(string x, string y)
        {
            Console.WriteLine(x+y);
        }

        public void Show(float x, float y)
        {
            Console.WriteLine(x+y);
        }

        public void Show(double x, double y)
        {
            Console.WriteLine(x+y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.Show(1,2);
            d.Show("sonu kumar", "neha thakur");
            d.Show(1.5F, 2.5F);
            d.Show(15.5D, 12.5D);
            Console.ReadLine();
        }
    }
}

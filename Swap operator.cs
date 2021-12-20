using System;
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x; /* save the value of x */
            x = y; /* put y into x */
            y = temp; /* put temp into y */
        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();

            /* local variable definition */
            int p = 25;
            int q = 50;
            Console.WriteLine("Before swap, value of a : {0}", p);
            Console.WriteLine("Before swap, value of b : {0}", q);
            /* calling a function to swap the values */
            n.swap(ref p, ref q);
            Console.WriteLine("After swap, value of a : {0}", p);
            Console.WriteLine("After swap, value of b : {0}", q);
            Console.ReadLine();
        }
    }
}

using System;
class Excercise1
{
    static void Main(string[] args)
    {
        Console.WriteLine(test(1, 2));
        Console.WriteLine(test(2, 3));
        Console.WriteLine(test(2, 2));
        Console.ReadLine();
    }
    static int test(int x, int y)
    {
        return x == y ? (x + y) * 3 : x + y;
    }
}


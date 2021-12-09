using System;
class Excercise3
{
     static void Main(string[] args)
    {
        int x, y, temp;
        Console.Write("\ninput the First number : ");
        x = int.Parse(Console.ReadLine());
        Console.Write("\ninput the Second number : ");
        y = int.Parse(Console.ReadLine());
        temp = x;
        x = y;
        y = temp;
        Console.Write("After swap :");
        Console.Write("\ninput the First number : "+x);
        Console.Write("\ninput the Second number : "+y);
        Console.Read();

    }
}
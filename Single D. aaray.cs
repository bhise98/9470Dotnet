using System;
namespace Single.D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 50, 51, 500, 501, 510 };
            int len = arr.Length;
            Console.WriteLine("Length of Array " + len);
            Console.WriteLine(arr[0] + " " + arr[4]);
        }
    }
}

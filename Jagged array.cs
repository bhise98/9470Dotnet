using System;
namespace Studytonight
{
    class Program
    {
        public static void Main(string[] args)
        {
 int[][] arr = new int[][]
 {
 new int[] { 0, 4 },
 new int[] { 40, 44 },
 new int[] { 400, 401, 410, 411 }
 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write(arr[i][j] + " ");
                }
                System.Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}


using System;
class Demo
{
    static void Main()
    {
        object[] obj = new object[2];
        obj[0] = "Pratiksha";
        obj[1] = 32;
        for (int i = 0; i < obj.Length; ++i)
        {
            string s = obj[i] as string;
            Console.Write("{0}: ", i);
            if (s != null)
          Console.WriteLine("'" + s + "'");
           else
                Console.WriteLine("This is not a string!");
        }
        Console.ReadKey();
    }
}

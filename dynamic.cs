using System;

    class Demo
    {
        dynamic data = 14;
        public int method(int x, int y)
        {
            return (x + y) * data;
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            dynamic value1 = 5;
            dynamic value2 = 6;
        dynamic str = "your result is:";
            Console.WriteLine(str + obj.method(value1, value2));
            Console.ReadLine();
        }
    }




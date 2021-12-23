using System;

namespace usesimple
{
    class Program
    {
        static void Main(string[] args)
        {
            //调用C++的gcd()函数
            int x = 42;
            int y = 105;
            int g = simple.gcd(x, y);
            Console.WriteLine("The gcd of " + x + " and " + y + " is " + g);

            //操纵C++的Foo全局变量
            Console.WriteLine("Foo = " + simple.Foo);	//输出当前值
            simple.Foo = 3.1415926;						//改变值
            Console.WriteLine("Foo = " + simple.Foo);	//看看改变是否生效

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Basic
{
    internal class Program
    {
        static void Main(string[] args) { 
            Console.WriteLine("Hello World");


            //오버플로우 연습
            int a = 200000000;
            int b = 100000000;
            Console.WriteLine(a+b);
             
            //오버플로우 연습2
            Console.WriteLine((long)a + b);
            Console.WriteLine(a+(long)b);
            Console.WriteLine((long)a + (long)b);


            // 자료형의 최소 최대 값 출력
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
        }
    }
}   

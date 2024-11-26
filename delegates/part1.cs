using System;
using System.Collections.Generic;
using System.Linq;

delegate int DoMath(int x, int y);

namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DoMath output1 = Add;
            DoMath output2 = Subtract;
            Console.WriteLine($"output1: {output1(1,1)}\noutput2: {output2(1,1)}");
        }
        
        static int Add(int x, int y)
        {
            return x + y;
        }
        
        static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}

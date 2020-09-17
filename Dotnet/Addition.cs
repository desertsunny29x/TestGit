using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class Addition : Functions
    {
        static void Main(string[] args)
        {
            int a1 = 0, b1 = 0, c1 = 0;
            Console.WriteLine("Enter the value of a= ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b= ");
            b1 = Convert.ToInt32(Console.ReadLine());
            Addition obj = new Addition ();
            c1 = obj.addNumbers(a1, b1);
            Console.WriteLine("Sum of the numbers is= " + c1);
            Console.ReadKey();
        }
    }
    public class Functions
    {
        protected int addNumbers(int a, int b)
        {
            int c = 0;
            c = a + b;
            return c;
        }
    }
}

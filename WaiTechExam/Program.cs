using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiTechExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter a value:");
            a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter b value:");
            b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter c value:");
            c = Convert.ToInt16(Console.ReadLine());

            if((a*a)+(b*b)==(c*c))
            {
                Console.WriteLine("right-angled ");
            }
            else if((a==b)&&(b!=c))
            {
                Console.WriteLine("isosceles ");
            }
            else if((a==b)&&(b==c))
            {
                Console.WriteLine("equilateral triangle");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadLine();

            //assignment-1
            int n;
            Console.WriteLine("How many number if u want to enter:");
            n = Convert.ToInt16(Console.ReadLine());


            for (int num = 0; num <= n; num++)
            {
                Console.WriteLine("Enter number :");
                num = Convert.ToInt16(Console.ReadLine());
            }

        }
    }
}

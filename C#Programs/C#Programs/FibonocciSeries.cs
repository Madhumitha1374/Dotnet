using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class FibonocciSeries
    {

        // PRINT N NUMBER OF FIBONOCCI ELEMENTS
        public void FibNum()
        {
            int n = 15;

            int i = 1;
            int a = 0;
            int b = 1;
            Console.Write(a.ToString() + " " + b.ToString());
            while (i <= n)
            {
                int c = a + b;
                Console.Write(" " + c.ToString());
                a = b;
                b = c;
                i += 1;
            }
            Console.WriteLine();
        }

        public int NthFib(int n)
        {
            if(n <= 1)
            {
                return n;
            }

            return (NthFib(n - 1) + NthFib(n - 2));
        }

        //PRINT N TH FIBONOCCI NUMBER
        public void FibOfNthNum()
        {
            int n = 14;
            int result = NthFib(n);
            Console.WriteLine(result.ToString());
        }


        //PRINT FOBOCCI SEREIS UPTO GIVEN NUMBER
        public void FibUptoGivenNum()
        {
            int n = 100;

            int a = 0;
            int b = 1;
            int c = 0;
            Console.Write(a.ToString() + " " + b.ToString());
            while (c <= n)
            {
                c = a + b;
                Console.Write(" " + c.ToString());
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
    }
}

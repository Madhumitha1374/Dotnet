using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class ArmstrongNUmber
    {
        //How to check if a given number is Armstrong or not?
        public void CheckNumArmstng()
        {
            int n = 8208;
            string s = n.ToString();
            int sum = 0;
            for(int i = 0; i < s.Length; i++)
            {
                int r = 1;
                for(int j = 0; j < s.Length; j++)
                {
                    r = r * Convert.ToInt32(s[i].ToString());
                }
                sum += r;
            }
            if(Convert.ToInt32(sum) == n)
            {
                Console.WriteLine("ArmStrong number");
            }
            else
            {
                Console.WriteLine("Not an Armstrong number");
            }
            
        }

        // PRINT ARMSTRONG NUMBER BETWEEN GIVEN RANGE
        public void CheckArmstngRange()
        {
            int m = 100;
            int n = 9000;
            for (int i = m; i <= n; i++)
            {
                string s = i.ToString();
                int sum = 0;
                for (int j = 0;j < s.Length; j++)
                {
                    int r = 1;
                    for (int k = 0;k < s.Length;k++)
                    {
                        r *= Convert.ToInt32(s[j].ToString());
                    }
                    sum += r;
                }
                if(Convert.ToInt32(sum) == i)
                {
                    Console.Write(i + ", ");
                }

            }
        }



    }
}

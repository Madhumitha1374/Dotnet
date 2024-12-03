using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class Decimal_Binary
    {
        public void DecimalToBin()
        {
            int dec = 10;
            string s = "";
            while (dec > 0)
            {
                s += dec % 2;
                dec /= 2;
            }
            for(int i = s.Length-1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }
    }
}

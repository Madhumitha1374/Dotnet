using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class ArrayRotation
    {
        public void LeftRotate()
        {
            List<int> ints = new List<int>() { 10, 20, 30, 40, 50, 60 };
            
                int temp = ints[0];
                for (int i = 0; i < ints.Count - 1; i++)
                {
                    ints[i] = ints[i + 1];
                }
                ints[ints.Count - 1] = temp;
            foreach(int i in ints)
            {
                Console.Write(i + ", ");
            }
        }

        public void LeftRotateByGivenNum()
        {
            List<int> ints = new List<int>() { 10, 20, 30, 40, 50, 60 };
            int n = 4;
            for (int j = 0; j < n; j++)
            {
                int temp = ints[0];
                for (int i = 0; i < ints.Count - 1; i++)
                {
                    ints[i] = ints[i + 1];
                }
                ints[ints.Count - 1] = temp;
            }
            foreach (int i in ints)
            {
                Console.Write(i + ", ");
            }
        }

        public void RightRotate()
        {
            List<int> ints = new List<int>() { 10, 20, 30, 40, 50, 60 };
            int temp = ints[ints.Count - 1];
            for(int i = ints.Count-1; i > 0 ;i--)
            {
                ints[i] = ints[i - 1];
            }
            ints[0] = temp;
            foreach (int i in ints)
            {
                Console.Write(i + ", ");
            }
        }

        public void RightRotateByGivenNum()
        {
            List<int> ints = new List<int>() { 10, 20, 30, 40, 50, 60 };
            int n = 3;
            for(int j = 0; j < n; j++)
            {
                int temp = ints[ints.Count - 1];
                for (int i = ints.Count - 1; i > 0; i--)
                {
                    ints[i] = ints[i - 1];
                }
                ints[0] = temp;
            }
            
            
            foreach (int i in ints)
            {
                Console.Write(i + ", ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class ArrayCheck
    {
        public int[] Array1;
        public int[] Array2;

        public ArrayCheck(int[] arr1, int[] arr2)
        {
            Array1 = arr1;
            Array2 = arr2;
        }

           

        public bool IsArrayContains()
        {
           int index = 0;
            foreach (int num in Array1)
            {
                if (num == Array2[index])
                {
                    index++; 
                }

                if (index == Array2.Length)
                {
                    return true;
                }
            }

            return false;
        }
    }

}


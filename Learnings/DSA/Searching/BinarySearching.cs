using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.DSA.Searching
{
    /// <summary>
    /// Pefore performing the Binary search - sort the giving values in array to ascending order
    /// </summary>
    internal class BinarySearching
    {
        public BinarySearching()
        {

        }
        public int BinarySearchingImplementation(int[] arry, int left, int right, int x)
        {
            int retVal = -1;
            try
            {
                if (left > right)
                {
                    int midValIndex = (left + right) / 2;

                    if (arry[midValIndex] == x)
                    {
                        return midValIndex;
                    }

                    if (x > arry[midValIndex])
                    {
                        retVal = BinarySearchingImplementation(arry, midValIndex + 1, right, x);
                    }
                    else
                    {
                        retVal = BinarySearchingImplementation(arry, left, midValIndex - 1, x);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
            return retVal;
        }


    }
}

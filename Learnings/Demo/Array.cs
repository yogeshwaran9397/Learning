using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.Demo
{
    internal class Array
    {
        public Array()
        {

        }

        public void RotateArray()
        {
            try
            {
                //int[] array1 = new int[5];
                int[] array1 = new int[] { 1, 2, 3, 4, 5 };

                //rotate 5 ::
                //it will rotate from value 2 
                int iRotVal = 2;

                int[] array2 = new int[array1.Length];
                for (int i = iRotVal; i < array1.Length-1; i++)
                {
                    array2[i] = array1[i];
                }

                if (iRotVal > 1)
                {
                    for (int i = array1.Length - 2; i > 0; i--)
                    {
                        array2[i] = array1[i];
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

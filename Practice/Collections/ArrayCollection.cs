using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Collections
{
    internal class ArrayCollection
    {
        int[] dArray;
        public ArrayCollection()
        {
            GetInput();
            RotateArray(2);
        }

        public void GetInput()
        {
            string strInput = Console.ReadLine().ToString();
            string[] strArry = strInput.Split(",").ToArray();
            int dVal = 0;
            dArray = new int[strArry.Length];
            for (int i = 0; i < strArry.Length - 1; i++)
            {
                dVal = Convert.ToInt32(strArry[i]);
                dArray[i] = dVal;
            }
        }

        public void RotateArray(int pos)
        {
            int[] tempArray = new int[dArray.Length];
            int k = 0;
            for (int i = pos; i < dArray.Length; i++)
            {
                tempArray[k] = dArray[i];
                k++;
            }

            for (int i = 0; i < pos - 1; i++)
            {
                tempArray[k] = dArray[i];
            }
        }
    }
}

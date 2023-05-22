using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Practice.Var_and_Data_Types
{
    internal class StringOperations
    {
        public StringOperations()
        {
        }

        public void MethodStringOperations()
        {
            string str1 = "Yogesh";
            string str2 = "Waran";

            string str3 = str1 + str2;

            FindSpaceInString();
            FindDuplicateCharInString();
            MakeStartingWordToUpper();
        }

        private static void TrimSample()
        {
            string str7 = "###";
        }

        private static void MakeStartingWordToUpper()
        {
            //make each word start letter as capital
            string str6 = "i love programming";
            string[] stringArray = str6.Split(" ");
            foreach (string str in stringArray)
            {
                string st = str.Substring(0, 1);
                st = st.ToUpper();
                Console.WriteLine(st);
            }
        }

        private static void FindSpaceInString()
        {
            string str4 = " Y Ogesh ";
            // find all the space " " in the above string
            char[] charArry = str4.ToCharArray();
            int spaceCount = 0;
            foreach (var ch in charArry)
            {
                if (ch == ' ')
                {
                    spaceCount++;
                }
            }

            Console.WriteLine(spaceCount);


        }

        private static void FindDuplicateCharInString()
        {
            //find duplicate char if any in the string
            string str5 = "abcdabc";
            char[] charArray = str5.ToCharArray();
            int count = 0;
            foreach (var ch in charArray)
            {
                count = 0;
                for (int i = 0; i < charArray.Length - 1; i++)
                {
                    if (charArray[i] == ch)
                    {
                        count++;
                    }
                }

                Console.WriteLine($"{ch} count in string is {count}");

            }
        }
    }
}

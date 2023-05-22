using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.Sample
{
    internal class StreamFile
    {
        List<string> files;

        ArrayList objArry = null;



        string strFilePath = "";
        public StreamFile(string strFilePath)
        {
            this.strFilePath = strFilePath;
            objArry = new ArrayList();
        }

        public string ReadFileData()
        {
            string retVal = "";
            try
            {
                bool fileExists = File.Exists(strFilePath);
                if (fileExists)
                {
                    StreamReader sr = new StreamReader(strFilePath);
                    retVal = sr.ReadToEnd();
                }
                else
                {
                    //log the error - file not exists
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return retVal;
        }


        public void SwapNumbers(int num1, int num2, ref int retNum1, ref int retNum2)
        {
            try
            {
                int tempNum = 0;
                tempNum = num1;
                num1 = num2;
                num2 = tempNum;

                retNum1 = num1;
                retNum2 = num2;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Topics
{
    internal class Reverse
    {
        public Reverse()
        {

        }

        public string ReverseValue()
        {
            string revStr = string.Empty;
            try
            {
                string strVale = Console.ReadLine();
                int actulNum = int.Parse(strVale);

                int rem = 0;
                int i = 0;
                while (i != strVale.Count())
                {
                    rem = actulNum % 10;
                    revStr = revStr +  rem.ToString();
                    i = i + 1;
                    actulNum= actulNum / 10;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            return revStr;
        }

    }
}

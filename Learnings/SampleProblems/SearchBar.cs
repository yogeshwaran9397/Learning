using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.SampleProblems
{
    internal class SearchBar
    {
        public SearchBar()
        {

        }

        public string SearchBarImplementation()
        {
            string retSrt = "";
            try
            {
                List<string> list = new List<string>();
                list.Add("ball");
                list.Add("bat");
                list.Add("tall");
                list.Add("call");

                Console.WriteLine("Search here :");
                string strUserInput = Console.ReadLine();

                // If user types B - need to print ball , bat 
                // If user types T - need to print tall 
                // If user types Bal - need to print ball
                List<string> returnString = list.FindAll(x => x.StartsWith(strUserInput));

                foreach (var s in returnString)
                {
                    retSrt = retSrt + " " + s;
                }

                Console.WriteLine(retSrt);
            }
            catch (Exception ex)
            {
            }
            return retSrt;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SampleProblem
    {
        List<int> lsNumbers = null;

        public SampleProblem()
        {
            lsNumbers = new List<int>();
            lsNumbers.Add(1);
            lsNumbers.Add(3);
            lsNumbers.Add(4);
            lsNumbers.Add(5);
        }


        public void IdentifyNumerMinMax()
        {
            try
            {
                //identify min
                int minNumber = 0;
                if (lsNumbers != null)
                {
                    for (int i = 0; i < lsNumbers.Count - 1; i++)
                    {
                        for (int j = i + 1; j < lsNumbers.Count - 1; j++)
                            if (lsNumbers[i] < lsNumbers[j])
                            {
                                minNumber = i;
                            }
                    }
                }
                else
                {
                    // thrown user 
                }

                Console.WriteLine($"Min number {minNumber}");

                //identify max
                int maxNumber = 0;
                if (lsNumbers != null)
                {
                    for (int i = 0; i < lsNumbers.Count - 1; i++)
                    {
                        for (int j = i + 1; j < lsNumbers.Count - 1; j++)
                            if (lsNumbers[i] > lsNumbers[j])
                            {
                                maxNumber = i;
                            }
                    }
                }
                else
                {
                    // thrown user 
                }
                Console.WriteLine($"Max number {maxNumber}");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void IdentifyMinMaxNumber()
        {
            try
            {
                Console.WriteLine($"Min {lsNumbers.Min().ToString()}");
                Console.WriteLine($"Max {lsNumbers.Max().ToString()}");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

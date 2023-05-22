using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.Demo
{
    internal class Bit
    {
        public Bit()
        {

        }
        public void sampleMethod()
        {
            uint x = 0b_1101_0101;//0b_1100_1010_0001;
            Console.WriteLine(x);

            //Left Shift
            uint y = x << 8;
            Console.WriteLine(y);

            //Right Shift
            uint z = x >> 8;
            Console.WriteLine(z);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.Abstract
{
    internal class AbstractUsageClass : AbstractClass
    {
        //Implementation of the SampleAbstractMethod 

        public override void SampleAbstractMethod()
        {
            int a1 = a;  
            throw new NotImplementedException();
        }

        //Virtual method -- method implementation is not necessary 
        public override void SampleVirtualMethod()
        {
            base.SampleVirtualMethod();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.Abstract
{
    abstract class AbstractClass
    {
        //abstract cannot have the body 
        [Required(AllowEmptyStrings = false, ErrorMessage = "Check the Required data")]
        int a = 5;
        public abstract void SampleAbstractMethod();

        public virtual void SampleVirtualMethod()
        {
            // can have the body 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.DP.Singleton
{
    public sealed class Singleton
    {
        private Singleton()
        {

        }
        private static Singleton instance = null;
        public static Singleton Instance
        {
            get
            {
                if (instance != null)
                    return instance;
                else
                    return new Singleton();
            }
        }
    }
}

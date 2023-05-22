using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Topics
{
    internal static class ExampleStringBuilderClass
    {
        public static void ExampleStringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Yogesh");
            for (int i = 0; i < 10; i++)
            {
                stringBuilder.Append(i.ToString());
            }

            Console.WriteLine(stringBuilder.ToString());

            stringBuilder.Replace("Yogesh", "Superman");

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}

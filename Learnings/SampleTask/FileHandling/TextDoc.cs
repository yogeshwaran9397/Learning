using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.SampleTask.FileHandling
{
    internal class TextDoc
    {
        string PathExistingDoc = "E:\\Yogesh\\Live\\Prac\\C#\\Learnings\\Learnings\\SampleTask\\FileHandling\\SampleDoc\\ExistingDoc.txt";
        string PathNewDoc = "E:\\Yogesh\\Live\\Prac\\C#\\Learnings\\Learnings\\SampleTask\\FileHandling\\SampleDoc\\NewDoc.txt";

        List<string> strContent = null;
        public TextDoc()
        {
            strContent = new List<string>();
        }

        public void ReadWriteDoc()
        {
            try
            {
                List<string> lines = System.IO.File.ReadLines(PathExistingDoc).ToList();
                strContent = lines;
                WriteDoc();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void WriteDoc()
        {
            try
            {
                if (!File.Exists(PathNewDoc))
                {
                    File.Create(PathNewDoc);                    
                    System.IO.File.WriteAllLines(PathNewDoc, strContent);
                }
                else
                {
                    System.IO.File.WriteAllLines(PathNewDoc, strContent);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

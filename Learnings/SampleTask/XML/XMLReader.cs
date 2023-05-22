using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Learnings.SampleTask.XML
{
    internal class XMLReader
    {
        string strPath = "";
        public XMLReader()
        {
            strPath = "C:\\Users\\Yogesh\\Downloads\\Sample VIF\\P45__Belkin__QC4+__0.xml";
        }

        public void ReadXML()
        {
            try
            {
                //XmlDocument objXMLDoc = new XmlDocument();                

                //XmlTextReader xmlReader = new XmlTextReader(strPath);
                //while (xmlReader.Read())
                //{
                //    switch (xmlReader.NodeType)
                //    {
                //        case XmlNodeType.Element: // The node is an element.
                //            Console.Write("<" + xmlReader.Name);

                //            while (xmlReader.MoveToNextAttribute()) // Read the attributes.
                //                Console.Write(" " + xmlReader.Name + "='" + xmlReader.Value + "'");
                //            Console.Write(">");
                //            Console.WriteLine(">");
                //            break;
                //        case XmlNodeType.Text: //Display the text in each element.
                //            Console.WriteLine(xmlReader.Value);
                //            break;
                //        case XmlNodeType.EndElement: //Display the end of the element.
                //            Console.Write("</" + xmlReader.Name);
                //            Console.WriteLine(">");
                //            break;
                //    }
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.DSA.LinkedList
{
    public class Node
    {
        public string data = "";
        public Node nextNode = null;
        public Node(string Data)
        {
            data = Data;
            nextNode = null;
        }

    }

    public class SLinkedList
    {
        public Node headNode = null;
        public SLinkedList(Node currenNode)
        {
            headNode = currenNode;
        }

        private void PintLinkedList(SLinkedList objLinkedList)
        {
            try
            {
                string Data = "";
                Node printData = objLinkedList.headNode;
                while (printData != null)
                {
                    Data = Data + " - " + printData.data;
                    printData = printData.nextNode;
                }
                Console.WriteLine(Data);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public void Insert_After(Node prevNode, string data)
        {
            try
            {
                if (prevNode == null)
                {
                    Console.WriteLine("Prev node should not be null");
                    return;
                }

                Console.Write($"Insert {data} after {prevNode.data}");

                Node newNode = new Node(data);
                newNode.nextNode = prevNode.nextNode;
                prevNode.nextNode = newNode;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CreatingLinkedList()
        {
            try
            {
                //Create a below linkedList
                // null <-[Y]-> [O]-> [G]-> null

                Node headNode = new Node("Y");
                SLinkedList objSLinkedList = new SLinkedList(headNode);

                Node ele2 = new Node("O");
                Node ele3 = new Node("G");

                //link the 1st node to the 2nd 
                objSLinkedList.headNode.nextNode = ele2;

                //link the 2nd node to the 3rd 
                ele2.nextNode = ele3;

                PintLinkedList(objSLinkedList); // need to be Y O G

                Insert_After(ele2, "E");// need to be Y O E G                 
                PintLinkedList(objSLinkedList);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}

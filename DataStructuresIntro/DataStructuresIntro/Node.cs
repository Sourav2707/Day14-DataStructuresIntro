using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresIntro
{
    internal class Node
    {
        public int data; // data for the node 
        public Node next; // reference for the node
        public Node(int data)
        {
            this.data = data;
        }
    }
}

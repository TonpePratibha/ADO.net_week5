using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review5
{
    public class Node
    {
       public int data;
        public Node next;
        public Node(int d) { 
        this.data= d;
            next = null;
        }
    }
}

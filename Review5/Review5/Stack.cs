using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review5
{
   internal class Stack
    {
        Node top;
        public Stack() {
            this.top =null ;
        }
        public void Push(int value) { 
        
            Node newnode=new Node(value) ;
            if (top == null)
            {
                newnode.next = null;
            }
            else { 
            newnode.next=top;

            }
            top = newnode;
        }
        public void Peek() {
            if (top == null) {
                Console.WriteLine("empty stack");
                return;
            }
            Console.WriteLine(top.data);
        
        }
        public void Pop()
        {
            if (top == null) { 
            Console.WriteLine("empty stack");
                return;
            }
            Console.WriteLine(top.data);
            top = top.next;


        }

        public void Print()
        {
            if (top == null)
            {
                return;
            }
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            
        }

      

    }
}

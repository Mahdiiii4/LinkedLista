using System;
namespace Ny_mapp
{
    public class Node
    {
        int value;
        Node next;

        public Node Next{
            get { return next; }
            set { next = value; }
        }

        public int Value{
            get { return value; }
            set { this.value = value; }
        }

        public Node(int value)
        {
            this.value = value;
        }
    }
}
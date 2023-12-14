using System;
namespace Ny_mapp
{
    public class LinkedList
    {
        Node head;
        public void Add(int value)
        {
            Node newNode = new Node(value);

            if(head is null)
            {
                head = newNode;
                return;
            }

            Node current = head;

            for(;current.Next != null ; current = current.Next)
            {}

            current.Next = newNode;
        }

        public void Print()
        {
            Node current = head;

            for(;current != null ; current = current.Next)
            {
                Console.WriteLine(current.Value);
            }
        }
    }
}
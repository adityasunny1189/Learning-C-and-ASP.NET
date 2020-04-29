using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List");
            Node h1 = insert();
            print(h1);
        }

        public static Node insert() 
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Node head = null;
            Node tail = null;
            while(num != -1) 
            {
                Node newNode = new Node(num);
                if(head == null) 
                {
                    head = newNode;
                    tail = newNode;
                } 
                else 
                {
                    tail.next = newNode;
                    tail = newNode;
                }
                num = Convert.ToInt32(Console.ReadLine());
            }
            return head;
        }
        public static void print(Node head) 
        {
            while(head != null) 
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
        }
    }
}

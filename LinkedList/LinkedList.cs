using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList<T> where T: IComparable<T>
    {
        public bool IsEmpty()
        {
            if (head == null)
                return true;
            return false;
        }
        public LinkedList()
        {
            head = null;
        }
        public LinkedList<T> List()
        {
            LinkedList<T> emptyList = new LinkedList<T>();
            return emptyList;
        }
        public Node<T> head; //new 
        public void Append(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
                head = node;
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = node;
            }
        }
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
                head = node;
            else
            {
                node.next = head;
                head = node;
            }
        }
            internal void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next; //temp=null
            }
        }
        //Insert Element Between 56nand 70
        public void Insert(int position, T data)
        {
            Node<T> temp = head;
            if (position < 0)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            if (position == 0)
                Add(data);
            else
            {
                Node<T> node = new Node<T>(data);
                for (int i = 1; i < position; i++)
                    temp = temp.next;
                node.next = temp.next;
                temp.next = node;
            }
        }
        //Remove First Element
        internal Node<T> RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }
        //Remove Last Element
        internal Node<T> RemovaLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node<T> newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
        //Search Node
        public bool Search(T data)
        {
            Node<T> temp = head;
            while (temp != null)
            {
                if (temp.data.CompareTo(data) == 0)
                    return true;
                temp = temp.next;
            }
            return false;
        }

        //Adding 40 after 30
        public int Update(T data)
        {
            int index = 0;
            Node<T> temp = head;
            while (temp != null)
            {
                if (temp.data.CompareTo(data) == 0)
                    return index;
                temp = temp.next;
                index++;
            }
            return -1;
        }

        //UC9 Delete node from List
        public void Delete(T data)
        {
            if (IsEmpty())
                return;
            if (head.data.CompareTo(data) == 0)
                head = head.next;
            else
            {
                Node<T> temp = head;
                while (temp != null)
                {
                    if (temp.next.data.CompareTo(data) == 0)
                    {
                        temp.next = temp.next.next;
                        return;
                    }
                    temp = temp.next;
                }
            }
        }
    }
}

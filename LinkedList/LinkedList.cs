﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList<T> where T: IComparable<T>
    {
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
       
        

    }
}

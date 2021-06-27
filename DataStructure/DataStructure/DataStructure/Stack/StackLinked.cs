using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Stack
{
    public class Node<T> {
      public   T data { get; set; }
      public Node<T> next;
    }
    public  class StackLinked<T>
    {
        private Node<T> top { get; set; }
        private int size { get; set; }
        public StackLinked()
        {
            top = null;
        }
        public int getSize()
        {
            return size;
        }
         public void Push(T data)
        {
            Node<T> temp = new Node<T>();
            temp.data = data;
            if (top == null)
                temp.next = null;
            else
                temp.next = top;
            top = temp;
          }
        public T pop()
        {
            if (top == null)
                return top.data;
            top = top.next;
            return top.data;
        }

        public void printStack()
        {
            if (top == null)
                Console.Write( "empty");
            else
            {
                Node<T> temp = top;
                while(temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }


        }


    }
}

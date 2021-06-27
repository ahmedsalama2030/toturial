using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Stack
{
   public  class StackCustom
    {
            int MAX = 2;
        public int[] stack = new int[2];
        private int Top;
      public   StackCustom()
        {
            Top = 0;
        }

        public void Push(int data)
        {
            if (Top >=  MAX)
            {
                Console.WriteLine("Stack Overflow");
             }
            else
            stack[Top++]=data;
        }

        public int pop()
        {
            if (Top <=0)
            {
                Console.WriteLine("Stack Overflow");
                return 0;
            }
            return stack[--Top];
        }
        public int  getTop()
        {
            if (Top <= 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
             }
            return stack[Top];

        }
        public void printStack()
        {

            if (Top <= 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                for (int i = Top-1; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
     }
}

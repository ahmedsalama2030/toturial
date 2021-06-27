using DataStructure.Graph;
using DataStructure.Stack;
using System;

namespace DataStructure
{
   public  class Program
    {

        static void Main(string[] args)
        {
            Node root = new Node(7,null,null);
            var builtTree = new BuiltTree(root);
            int[] arr = { 1, 3, 7, 9, 8, 10, 0 };
            for (int i = 0; i < arr.Length; i++)
            {
              builtTree.AddNode(new Node(arr[i],null,null), root);
            }

           var x=  builtTree.Search(9, root);
            if (x==null)
             Console.WriteLine("notfound");
             else
            Console.WriteLine(x.value);
         }
    }
}

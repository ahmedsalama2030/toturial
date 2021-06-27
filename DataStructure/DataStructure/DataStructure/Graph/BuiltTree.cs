using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Graph
{
     public class Node
    {
        public int value { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
        public Node(int Value, Node Left, Node Right)
        {
            value = Value;
            left = Left;
            right = Right;
        }

        
          
       
    }
    public class BuiltTree
    {
        public Node root { get; set; }
        public BuiltTree(Node Root)
        {
            root = Root;
        }
        public void  AddNode(Node node, Node root)
        {
            if (node.value > root.value)
            {
                if (root.right == null)
                    root.right = node;
                else
                    this.AddNode(node, root.right);
            }
            if (node.value < root.value)
            {
                if (root.left == null)
                    root.left = node;
                else
                    this.AddNode(node, root.left);
            }
        }


        public Node  Search(int value, Node parent)
        {
            if (parent != null)
            {
                if (value == parent.value) return parent;
                if (value < parent.value)
                    return Search(value, parent.left);
                else
                    return Search(value, parent.right);
            }

            return null;


        }
     }
}

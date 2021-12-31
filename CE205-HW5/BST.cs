using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE205_HW5.libs
{
    public class BSTNode
    {
        public int Val { get; set; }
        public BSTNode Left { get; set; }
        public BSTNode Right { get; set; }

        public BSTNode()
        {
        }

        public BSTNode(int val)
        {
            Val = val;
        }

        public void Print()
        {
            Console.WriteLine(Val);
        }
    }

    public class BSTNode<T> : BSTNode
    {
        public BSTNode(int key, T value) : base(key)
        {
            Value = value;
        }

        public T Value { get; set; }
    }
    public class BinaryTree
    {
        BSTNode root = null;

        public BinaryTree()
        {
        }

        /// <summary>
        /// Delete a node by key.  This will only delete one occurence of a 
        /// node with that key.
        /// </summary>
        /// <param name="val">Key of node to delete</param>
        public void Delete(int val)
        {
            BSTNode curr = Find(val);
            BSTNode parent = FindParent(root, val);
            BSTNode node = null, nodeParent = null, nodeChild = null;
            if (curr.Left == null || curr.Right == null)
                node = curr;
            else
                node = FindSuccessor(curr);

            nodeParent = FindParent(root, node.Val);

            if (node.Left != null)
                nodeChild = node.Left;
            else
                nodeChild = node.Right;

            if (nodeParent == null) // root
            {
                root = nodeChild;
            }
            else
            {
                if (node == nodeParent.Left)
                    nodeParent.Left = nodeChild;
                else
                    nodeParent.Right = nodeChild;
            }
            if (node != curr)
                curr.Val = node.Val;
        }

        /// <summary>
        /// Delete a node from the binary tree
        /// </summary>
        /// <param name="node">Node reference</param>
        public void Delete(BSTNode node)
        {
            Delete(node.Val);
        }

        /// <summary>
        /// Find a node given a key
        /// </summary>
        /// <param name="val">Key of node to find</param>
        /// <returns>First node found with that key</returns>
        public BSTNode Find(int val)
        {
            return Find(root, val);
        }

        /// <summary>
        /// Find the node with the next biggest key
        /// </summary>
        /// <param name="curr">Input node</param>
        /// <returns>Successor node</returns>
        public BSTNode FindSuccessor(BSTNode curr)
        {
            if (curr.Right != null)
            {
                curr = curr.Right;
                while (curr.Left != null)
                    curr = curr.Left;
                return curr;
            }
            else
            {
                BSTNode Parent = FindParent(root, curr.Val);
                BSTNode LastParent = curr;
                while (Parent != null && Parent.Right == LastParent)
                {
                    LastParent = Parent;
                    Parent = FindParent(root, Parent.Val);
                }
                return Parent;
            }
        }

        /// <summary>
        /// Insert a node into the binary tree
        /// </summary>
        /// <param name="node">Node to insert</param>
        public void Insert(int data)
        {
            BSTNode node = new BSTNode();
            node.Val = data;
            if (root == null)
            {
                root = node;
                return;
            }

            InsertHelper(root, node);
        }
        public void InsertHelper(BSTNode curr, BSTNode node)
        {
            if (node.Val < curr.Val)
            {
                if (curr.Left == null)
                    curr.Left = node;
                else
                    InsertHelper(curr.Left, node);
            }
            else
            {
                if (curr.Right == null)
                    curr.Right = node;
                else
                    InsertHelper(curr.Right, node);
            }
        }

        /// <summary>
        /// Pretty-print the binary tree
        /// </summary>
        public void Print()
        {
            // not implemented
        }

        /// <summary>
        /// Do a pre-order walk of the tree and print the key of each node
        /// </summary>
        public void PrintSorted()
        {
            Print(root);
        }

        #region Helpers

        int Depth()
        {
            // not implemented
            return 0;
        }

        public BSTNode Find(BSTNode curr, int val)
        {
            if (curr == null)
                return null;
            if (curr.Val == val)
                return curr;
            if (val < curr.Val)
                return Find(curr.Left, val);
            return Find(curr.Right, val);
        }
        public bool Search(int key)
        {
            if (root == null)
            {
                return false;
            }
            BSTNode current = root;
            if (current.Val == key)
            {
                return true;
            }
            else
            {
                while (true)
                {
                    if (current.Val == key)
                    {
                        return true;
                    }
                    else if (key < current.Val)
                    {
                        if (current.Left != null)
                        {
                            current = current.Left;
                            continue;
                        }
                        return false;
                    }
                    else
                    {
                        if (current.Right != null)
                        {
                            current = current.Right;
                            continue;
                        }
                        return false;
                    }
                }
                return false;
            }
        }

        public BSTNode FindParent(BSTNode curr, int val)
        {
            if (curr == null)
                return null;
            if (curr.Left != null && curr.Left.Val == val)
                return curr;
            if (curr.Right != null && curr.Right.Val == val)
                return curr;
            if (val < curr.Val)
                return FindParent(curr.Left, val);
            return FindParent(curr.Right, val);
        }

        public void Print(BSTNode node)
        {
            if (node == null)
                return;
            Print(node.Left);
            Console.WriteLine(node.Val);
            Print(node.Right);
        }
        public void InOrderDisplayTree(BSTNode current, ref Microsoft.Msagl.Drawing.Graph graphObject)
        {
            graphObject.AddNode(root.Val.ToString()).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
            if (current != null)
            {
                if (current.Right != null)
                {
                    graphObject.AddEdge(current.Val.ToString(), current.Right.Val.ToString()).Attr.Color =
                        Microsoft.Msagl.Drawing.Color.Green;
                }
                if (current.Left != null)
                {
                    graphObject.AddEdge(current.Val.ToString(), current.Left.Val.ToString()).Attr.Color =
                        Microsoft.Msagl.Drawing.Color.Blue;

                }

                InOrderDisplayTree(current.Left, ref graphObject);
                Console.Write("({0}) ", current.Val);
                InOrderDisplayTree(current.Right, ref graphObject);
            }
            else
            {

            }
        }
        public void printTable(ref Microsoft.Msagl.Drawing.Graph graphObject)
        {

            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            InOrderDisplayTree(root, ref graphObject);
            Console.WriteLine();
        }

        #endregion
    }
}


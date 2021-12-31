using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE205_HW5
{
    public class BPlusNode
    {
        public readonly int n;
        public readonly int splitIdx;
        public readonly int?[] values;
        public readonly BPlusNode[] children;
        public int filled;
        public BPlusNode parent;

        public BPlusNode(int n)
        {
            this.n = n;
            splitIdx = (int)Math.Ceiling((n - 1) / 2d);
            filled = 0;
            children = new BPlusNode[n];
            values = new int?[n - 1];
        }

        public IEnumerable<int?> Values => values.AsEnumerable();
        public BPlusNode Root => IsRoot ? this : parent.Root;
        public bool IsRoot => parent == null;
        public bool IsLeaf => children[0] == null;


        public IEnumerable<BPlusNode> GetLevel(int x)
        {
            if (x == 0)
            {
                yield return this;
            }

            if (!IsLeaf)
            {
                for (var i = 0; i < filled + 1; i++)
                {
                    foreach (var node in children[i].GetLevel(x - 1))
                    {
                        yield return node;
                    }
                }
            }
        }

        public BPlusNode Search(int value)
        {
            if (IsLeaf)
            {
                return this;
            }

            var i = 0;
            for (; i < n - 1 && values[i] <= value; i++) ;
            return children[i].Search(value);
        }

        public void Insert(int value)
        {
            Search(value).Insert(value, null);
        }

        public BPlusNode Split(int comingValue, BPlusNode comingNode)
        {
            var newSibling = new BPlusNode(n);

            // Sort with the new value, keep the max value in a variable outside the array
            var overflowValue = comingValue;
            var overflowNode = comingNode;
            for (var i = 0; i < n - 1; i++)
            {
                var (tempValue, tempNode) = GetAt(i);
                if (overflowValue <= tempValue)
                {
                    SetAt(i, overflowValue, overflowNode);
                    (overflowValue, overflowNode) = (tempValue.Value, tempNode);
                }
            }

            // Copy values to the new node and reset values in the old node
            for (var i = splitIdx; i < n - 1; i++)
            {
                var (addValue, addNode) = GetAt(i);
                ResetAt(i);
                newSibling.SetAt(i - splitIdx, addValue.Value, addNode);
            }
            newSibling.SetAt(newSibling.filled, overflowValue, overflowNode);

            return newSibling;
        }

        public void Insert(int value, BPlusNode node)
        {
            // Check if there is a place for a new value
            if (filled < n - 1)
            {
                var insertIdx = 0;
                for (; values[insertIdx] <= value; insertIdx++) ;

                InsertAt(insertIdx, value, node);
            }
            else
            {
                var newSibling = Split(value, node);
                var midValueCopy = newSibling.GetAt(0).value.Value;

                if (!IsLeaf)
                {
                    newSibling.children[0] = newSibling.children[1];
                    newSibling.RemoveAt(0);
                }

                if (IsRoot)
                {
                    parent = new BPlusNode(n);
                    parent.children[0] = this;
                }

                parent.Insert(midValueCopy, newSibling);
            }
        }

        public void RemoveAt(int index)
        {
            for (var i = index; i < filled - 1; i++)
            {
                var (addValue, addNode) = GetAt(i + 1);
                ResetAt(i + 1);
                SetAt(i, addValue.Value, addNode);
            }
        }

        public void InsertAt(int index, int value, BPlusNode node)
        {
            for (var i = filled; i > index; i--)
            {
                var (addValue, addNode) = GetAt(i - 1);
                SetAt(i, addValue.Value, addNode);
            }
            SetAt(index, value, node);
        }

        public void SetAt(int index, int value, BPlusNode node)
        {
            // Check if value is added or updated
            if (values[index] == null)
            {
                filled++;
            }

            // Set
            values[index] = value;
            children[index + 1] = node;

            // Update node's parent
            if (node != null)
            {
                node.parent = this;
            }
        }

        public void ResetAt(int index)
        {
            if (values[index] != null)
            {
                values[index] = null;
                children[index + 1] = null;
                filled--;
            }
        }

        public (int? value, BPlusNode node) GetAt(int index)
        {
            return (values[index], children[index + 1]);
        }
    }
    public class BPlusTree
    {
        public BPlusNode root;


        public BPlusTree(int n)
        {
            root = new BPlusNode(n);
        }


        public IEnumerable<BPlusNode> GetLevel(int level)
        {
            return root.GetLevel(level);
        }

        public BPlusNode Search(int value)
        {
            return root.Search(value);
        }

        public void Insert(int value)
        {
            root.Insert(value);
            root = root.Root;
        }
        public static void PrintTree(BPlusTree tree, ref Microsoft.Msagl.Drawing.Graph graphObject)
        {
            int counter = 0;
            int i = 0;
            IEnumerable<BPlusNode> nodes;
            string salah = "|";
            string prev = "";
            while ((nodes = tree.GetLevel(i))?.Any() == true)
            {
                Console.Write(i + ":\t");
                foreach (var node in nodes)
                {
                    Console.Write(string.Join(('|').ToString(), node.Values) + "   ");
                    graphObject.AddNode(string.Join(('|').ToString(), node.Values) + "   ");
                    if(counter > 0)
                    {
                        graphObject.AddEdge(prev, string.Join(('|').ToString(), node.Values) + "   ");
                    }
                    prev = string.Join(salah, node.Values) + "   ";
                    counter++;
                }
                i++;
                salah = salah + " ";
                counter = 0;
            }
        }
    }
}
using Microsoft.Msagl.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CE205_HW5.libs;

namespace CE205_HW5
{
    public partial class Form1 : Form
    {

        private Microsoft.Msagl.Drawing.Graph _graphObject;
        const int degreeBplus = 3;
        AVL avl1 = new AVL();
        RBTree redblack = new RBTree();
        BPlusTree BPtree = new BPlusTree(degreeBplus);
        BinaryTree bstbst = new BinaryTree();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //_graphObject.AddEdge("A", "B");
            //_graphObject.AddEdge("B", "C");
            //_graphObject.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            //_graphObject.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            //_graphObject.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            //Microsoft.Msagl.Drawing.Node c = _graphObject.FindNode("C");
            //c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            //c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
            ////bind the graph to the viewer 
            //gViewer1.Graph = _graphObject;

            //gViewer1.Refresh();
        }
        private readonly Random _random = new Random();
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        private bool MessageBoxes(int textBoxNum)
        {
            TextBox textBoxy = new TextBox();
            if (textBoxNum == 1) textBoxy = textBox1;
            else if (textBoxNum == 2) textBoxy = textBox2;
            else if (textBoxNum == 3) textBoxy = textBox3;

            bool isNumeric = int.TryParse(textBoxy.Text, out int n);
            if (isNumeric == false)
            {
                MessageBox.Show("You can only add integers. \n" +
                    "Range can be between -2,147,483,648 to 2,147,483,647", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxy.Text = null;
                return false;
            }
            if (textBoxy.Text.Length == 0)
            {
                MessageBox.Show("Box can't be free", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(rdBplus.Checked)
            {

                _graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
                //add randoms
                //BPlusTree.PrintTree(BPtree, ref _graphObject);
                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }

            else if (rdAvl.Checked)
            {
                _graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
                for (int i = 0; i < 3; i++)
                {
                    int a1 = RandomNumber(0, 100);
                    //avl1.Add(a1);
                    bool result = avl1.Find(a1);
                    if (result)
                    {
                        continue;
                    }
                    avl1.Add(a1);
                }
                avl1.printTable(ref _graphObject);
                btnCreate.Text = "Add 3 random numbers in range(0,100) ";

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
            else if(rdRedblack.Checked)
            {
                _graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
                for (int i = 0; i < 3; i++)
                {
                    int a1 = RandomNumber(0, 100);
                    bool result = redblack.FindValue(a1);
                    if (result)
                    {
                        continue;
                    }
                    redblack.Insert(a1);
                }
                redblack.printTable(ref _graphObject);
                btnCreate.Text = "Add 3 random numbers in range(0,100) ";

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
            else if (rdBST.Checked)
            {
                _graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
                for (int i = 0; i < 3; i++)
                {
                    int a1 = RandomNumber(0, 100);
                    bool result = bstbst.Search(a1);
                    if (result)
                    {
                        continue;
                    }
                    bstbst.Insert(a1);
                }
                bstbst.printTable(ref _graphObject);
                btnCreate.Text = "Add 3 random numbers in range(0,100) ";

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (rdBplus.Checked)
            {
                if (!MessageBoxes(1)) return;

                int insertVal = Convert.ToInt32(textBox1.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    return;
                    
                }
                /*
                bool result = avl1.Find(insertVal);
                if (result)
                {
                    MessageBox.Show("Item already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    return;
                }
                */

                _graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
                BPtree.Insert(insertVal);
                BPlusTree.PrintTree(BPtree, ref _graphObject);

                textBox1.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }

            else if (rdAvl.Checked)
            {
                if (!MessageBoxes(1)) return;

                int insertVal = Convert.ToInt32(textBox1.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    return;
                }

                bool result = avl1.Find(insertVal);
                if (result)
                {
                    MessageBox.Show("Item already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    return;
                }

                _graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
                avl1.Add(insertVal);
                avl1.printTable(ref _graphObject);

                textBox1.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
            else if (rdRedblack.Checked)
            {
                if (!MessageBoxes(1)) return;

                int insertVal = Convert.ToInt32(textBox1.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    return;
                }

                bool result = redblack.FindValue(insertVal);
                if (result)
                {
                    MessageBox.Show("Item already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    return;
                }

                _graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
                redblack.Insert(insertVal);
                redblack.printTable(ref _graphObject);

                textBox1.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();

            }
            else if (rdBST.Checked)
            {
                if (!MessageBoxes(1)) return;

                int insertVal = Convert.ToInt32(textBox1.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    return;
                }

                bool result = bstbst.Search(insertVal);
                if (result)
                {
                    MessageBox.Show("Item already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    return;
                }

                _graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
                bstbst.Insert(insertVal);
                bstbst.printTable(ref _graphObject);

                textBox1.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (rdBplus.Checked)
            {

            }
            else if (rdAvl.Checked)
            {
                if (!MessageBoxes(2)) return;

                int insertVal = Convert.ToInt32(textBox2.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = null;
                    return;
                }

                bool result = avl1.Find(insertVal);

                _graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
                avl1.printTable(ref _graphObject);

                if (result)
                {
                    _graphObject.FindNode(insertVal.ToString()).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    _graphObject.FindNode(insertVal.ToString()).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Hexagon;
                }
                else
                {
                    MessageBox.Show("Item does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                avl1.printTable(ref _graphObject);

                textBox2.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
            else if (rdRedblack.Checked)
            {
                if (!MessageBoxes(2)) return;

                int insertVal = Convert.ToInt32(textBox2.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = null;
                    return;
                }

                bool result = redblack.FindValue(insertVal);

                _graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
                redblack.printTable(ref _graphObject);

                if (result)
                {
                    _graphObject.FindNode(insertVal.ToString()).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    _graphObject.FindNode(insertVal.ToString()).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Hexagon;
                }
                else
                {
                    MessageBox.Show("Item does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                redblack.printTable(ref _graphObject);

                textBox2.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();

            }
            else if (rdBST.Checked)
            {
                if (!MessageBoxes(2)) return;

                int insertVal = Convert.ToInt32(textBox2.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = null;
                    return;
                }

                bool result = bstbst.Search(insertVal);

                _graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
                bstbst.printTable(ref _graphObject);

                if (result)
                {
                    _graphObject.FindNode(insertVal.ToString()).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    _graphObject.FindNode(insertVal.ToString()).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Hexagon;
                }
                else
                {
                    MessageBox.Show("Item does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bstbst.printTable(ref _graphObject);

                textBox2.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (rdBplus.Checked)
            {

            }
            else if (rdAvl.Checked)
            {
                if (!MessageBoxes(3)) return;

                int insertVal = Convert.ToInt32(textBox3.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Text = null;
                    return;
                }

                _graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
                bool result = avl1.Find(insertVal);
                if (!result)
                {
                    MessageBox.Show("Item does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Text = null;
                    return;
                }

                avl1.Delete(insertVal);
                avl1.printTable(ref _graphObject);

                textBox3.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
            else if (rdRedblack.Checked)
            {
                if (!MessageBoxes(3)) return;

                int insertVal = Convert.ToInt32(textBox3.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Text = null;
                    return;
                }

                _graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
                bool result = redblack.FindValue(insertVal);
                if (!result)
                {
                    MessageBox.Show("Item does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Text = null;
                    return;
                }

                redblack.Delete(insertVal);
                redblack.printTable(ref _graphObject);

                textBox3.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();

            }
            else if (rdBST.Checked)
            {
                if (!MessageBoxes(3)) return;

                int insertVal = Convert.ToInt32(textBox3.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Text = null;
                    return;
                }

                _graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
                bool result = bstbst.Search(insertVal);
                if (!result)
                {
                    MessageBox.Show("Item does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Text = null;
                    return;
                }

                bstbst.Delete(insertVal);
                bstbst.printTable(ref _graphObject);

                textBox3.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }

        }
        private void rdAvl_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdBtnBfsAlgorithm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdBtnMstAlgorithm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
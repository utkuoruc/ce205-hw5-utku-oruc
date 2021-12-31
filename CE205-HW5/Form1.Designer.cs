namespace CE205_HW5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdRedblack = new System.Windows.Forms.RadioButton();
            this.rdAvl = new System.Windows.Forms.RadioButton();
            this.rdBplus = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdBST = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 36);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(110, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1307, 35);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // gViewer1
            // 
            this.gViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gViewer1.ArrowheadLength = 10D;
            this.gViewer1.AsyncLayout = false;
            this.gViewer1.AutoScroll = true;
            this.gViewer1.BackwardEnabled = false;
            this.gViewer1.BuildHitTree = true;
            this.gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer1.EdgeInsertButtonVisible = true;
            this.gViewer1.FileName = "";
            this.gViewer1.ForwardEnabled = false;
            this.gViewer1.Graph = null;
            this.gViewer1.InsertingEdge = false;
            this.gViewer1.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer1.LayoutEditingEnabled = true;
            this.gViewer1.Location = new System.Drawing.Point(0, 135);
            this.gViewer1.LooseOffsetForRouting = 0.25D;
            this.gViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gViewer1.MouseHitDistance = 0.05D;
            this.gViewer1.Name = "gViewer1";
            this.gViewer1.NavigationVisible = true;
            this.gViewer1.NeedToCalculateLayout = true;
            this.gViewer1.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer1.PaddingForEdgeRouting = 8D;
            this.gViewer1.PanButtonPressed = false;
            this.gViewer1.SaveAsImageEnabled = true;
            this.gViewer1.SaveAsMsaglEnabled = true;
            this.gViewer1.SaveButtonVisible = true;
            this.gViewer1.SaveGraphButtonVisible = true;
            this.gViewer1.SaveInVectorFormatEnabled = true;
            this.gViewer1.Size = new System.Drawing.Size(1307, 670);
            this.gViewer1.TabIndex = 3;
            this.gViewer1.TightOffsetForRouting = 0.125D;
            this.gViewer1.ToolBarIsVisible = true;
            this.gViewer1.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewer1.Transform")));
            this.gViewer1.UndoRedoButtonsVisible = true;
            this.gViewer1.WindowZoomButtonPressed = false;
            this.gViewer1.ZoomF = 1D;
            this.gViewer1.ZoomWindowThreshold = 0.05D;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Purple;
            this.groupBox1.Controls.Add(this.rdBST);
            this.groupBox1.Controls.Add(this.rdRedblack);
            this.groupBox1.Controls.Add(this.rdAvl);
            this.groupBox1.Controls.Add(this.rdBplus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(13, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(469, 74);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm";
            // 
            // rdRedblack
            // 
            this.rdRedblack.AutoSize = true;
            this.rdRedblack.BackColor = System.Drawing.Color.Purple;
            this.rdRedblack.Location = new System.Drawing.Point(212, 31);
            this.rdRedblack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdRedblack.Name = "rdRedblack";
            this.rdRedblack.Size = new System.Drawing.Size(147, 33);
            this.rdRedblack.TabIndex = 3;
            this.rdRedblack.Text = "Red-Black";
            this.rdRedblack.UseVisualStyleBackColor = false;
            this.rdRedblack.CheckedChanged += new System.EventHandler(this.rdBtnBfsAlgorithm_CheckedChanged);
            // 
            // rdAvl
            // 
            this.rdAvl.AutoSize = true;
            this.rdAvl.Location = new System.Drawing.Point(106, 31);
            this.rdAvl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdAvl.Name = "rdAvl";
            this.rdAvl.Size = new System.Drawing.Size(81, 33);
            this.rdAvl.TabIndex = 2;
            this.rdAvl.Text = "AVL";
            this.rdAvl.UseVisualStyleBackColor = true;
            this.rdAvl.CheckedChanged += new System.EventHandler(this.rdAvl_CheckedChanged);
            // 
            // rdBplus
            // 
            this.rdBplus.AutoSize = true;
            this.rdBplus.Checked = true;
            this.rdBplus.Location = new System.Drawing.Point(8, 31);
            this.rdBplus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBplus.Name = "rdBplus";
            this.rdBplus.Size = new System.Drawing.Size(69, 33);
            this.rdBplus.TabIndex = 1;
            this.rdBplus.TabStop = true;
            this.rdBplus.Text = "B+";
            this.rdBplus.UseVisualStyleBackColor = true;
            this.rdBplus.CheckedChanged += new System.EventHandler(this.rdBtnMstAlgorithm_CheckedChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Red;
            this.btnCreate.Location = new System.Drawing.Point(553, 61);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(222, 74);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsert.Location = new System.Drawing.Point(781, 101);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(112, 34);
            this.buttonInsert.TabIndex = 8;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSearch.Location = new System.Drawing.Point(899, 101);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 34);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDelete.Location = new System.Drawing.Point(1017, 101);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 34);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(781, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 31);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(899, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 31);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1017, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 31);
            this.textBox3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            // 
            // rdBST
            // 
            this.rdBST.AutoSize = true;
            this.rdBST.BackColor = System.Drawing.Color.Purple;
            this.rdBST.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdBST.Location = new System.Drawing.Point(384, 31);
            this.rdBST.Name = "rdBST";
            this.rdBST.Size = new System.Drawing.Size(78, 33);
            this.rdBST.TabIndex = 14;
            this.rdBST.TabStop = true;
            this.rdBST.Text = "BST";
            this.rdBST.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1307, 809);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "CE205 HW5 2021-2022";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
        private GroupBox groupBox1;
        private RadioButton rdRedblack;
        private RadioButton rdAvl;
        private RadioButton rdBplus;
        private Button btnCreate;
        private Button buttonInsert;
        private Button buttonSearch;
        private Button buttonDelete;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private RadioButton rdBST;
    }
}
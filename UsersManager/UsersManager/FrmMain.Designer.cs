namespace UsersManager
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("用户信息");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("用户信息");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("用户信息");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("用户信息");
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pltitle = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.clbClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.pltitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 12;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Transparent;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Transparent;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pltitle
            // 
            this.pltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(215)))));
            this.pltitle.Controls.Add(this.guna2ControlBox1);
            this.pltitle.Controls.Add(this.clbClose);
            this.pltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pltitle.Location = new System.Drawing.Point(0, 0);
            this.pltitle.Name = "pltitle";
            this.pltitle.ShadowDecoration.Parent = this.pltitle;
            this.pltitle.Size = new System.Drawing.Size(1167, 46);
            this.pltitle.TabIndex = 0;
            this.pltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pltitle_MouseDown);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BorderRadius = 4;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1057, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(49, 46);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // clbClose
            // 
            this.clbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clbClose.Animated = true;
            this.clbClose.BorderRadius = 4;
            this.clbClose.FillColor = System.Drawing.Color.Transparent;
            this.clbClose.HoverState.Parent = this.clbClose;
            this.clbClose.IconColor = System.Drawing.Color.White;
            this.clbClose.Location = new System.Drawing.Point(1112, 0);
            this.clbClose.Name = "clbClose";
            this.clbClose.ShadowDecoration.Parent = this.clbClose;
            this.clbClose.Size = new System.Drawing.Size(55, 46);
            this.clbClose.TabIndex = 0;
            this.clbClose.Click += new System.EventHandler(this.clbClose_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 46);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.splitContainer1.Size = new System.Drawing.Size(1167, 605);
            this.splitContainer1.SplitterDistance = 159;
            this.splitContainer1.TabIndex = 1;
            // 
            // tvMenu
            // 
            this.tvMenu.BackColor = System.Drawing.Color.White;
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvMenu.FullRowSelect = true;
            this.tvMenu.HideSelection = false;
            this.tvMenu.Indent = 45;
            this.tvMenu.ItemHeight = 40;
            this.tvMenu.Location = new System.Drawing.Point(0, 0);
            this.tvMenu.Name = "tvMenu";
            treeNode1.Checked = true;
            treeNode1.Name = "TrUserInfo";
            treeNode1.Text = "用户信息";
            treeNode2.Name = "节点1";
            treeNode2.Text = "用户信息";
            treeNode3.Name = "节点2";
            treeNode3.Text = "用户信息";
            treeNode4.Name = "节点3";
            treeNode4.Text = "用户信息";
            this.tvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.tvMenu.ShowLines = false;
            this.tvMenu.Size = new System.Drawing.Size(159, 605);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMenu_AfterSelect);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 651);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pltitle.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pltitle;
        private Guna.UI2.WinForms.Guna2ControlBox clbClose;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvMenu;
    }
}


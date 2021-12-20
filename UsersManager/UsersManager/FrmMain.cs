using System;
using System.Drawing;
using System.Windows.Forms;

namespace UsersManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void pltitle_MouseDown(object sender, MouseEventArgs e)
        {
            //用来释放光标
            Win32.ReleaseCapture();
            //像windows发送拖动窗体的消息
            Win32.SendMessage(this.Handle, Win32.WM_SYSCOMMAND, Win32.SC_MOVE + Win32.HTCAPTION, 0);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            tvMenu.Nodes[0].BackColor = SystemColors.Highlight;
            tvMenu.Nodes[0].ForeColor = Color.Black;

            FrmUserInfo frmUserInfo = new FrmUserInfo();
            frmUserInfo.MdiParent = this;
            frmUserInfo.Parent = splitContainer1.Panel2;
            frmUserInfo.Dock = DockStyle.Fill;
            frmUserInfo.Show();
        }

        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode tn in tvMenu.Nodes)
            {
                tn.BackColor = Color.White;
                tn.ForeColor = Color.Black;
            }
            e.Node.BackColor =SystemColors.Highlight;
            e.Node.ForeColor = Color.Black;
        }

        private void clbClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}

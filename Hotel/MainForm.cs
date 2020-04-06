using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class MainForm : Form
    {
        string userType;
        public string UserType
        {
            set { userType = value; }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text="欢迎"+this.userType+"登录";
            if(userType!="管理员")
            {
                用户管理ToolStripMenuItem.Visible = false;
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void 用户注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                userAdd a = new userAdd();
                a.MdiParent = this;
                a.Show();
            }
            else
            {
                MessageBox.Show("不能同时打开多个子窗体！");
            }

        }

        private void 用户管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                userManage a = new userManage();
                a.MdiParent = this;
                a.Show();
            }
            else
            {
                MessageBox.Show("不能同时打开多个子窗体！");
            }
        }

        private void 宾客预定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                BooKRoom a = new BooKRoom();
                a.MdiParent = this;
                a.Show();
            }
            else
            {
                MessageBox.Show("不能同时打开多个子窗体！");
            }
        }

        private void 取消预定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                CancelReservation a = new CancelReservation();
                a.MdiParent = this;
                a.Show();
            }
            else
            {
                MessageBox.Show("不能同时打开多个子窗体！");
            }
        }

        private void 宾客登记ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                CheckIn a = new CheckIn();
                a.MdiParent = this;
                a.Show();
            }
            else
            {
                MessageBox.Show("不能同时打开多个子窗体！");
            }
        }

        private void 退房结算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                CheckOut a = new CheckOut();
                a.MdiParent = this;
                a.Show();
            }
            else
            {
                MessageBox.Show("不能同时打开多个子窗体！");
            }
        }

        private void 补交押金ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                PayDeposit a = new PayDeposit();
                a.MdiParent = this;
                a.Show();
            }
            else
            {
                MessageBox.Show("不能同时打开多个子窗体！");
            }
        }

        private void 房态查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                roomSearch a = new roomSearch();
                a.MdiParent = this;
                a.Show();
            }
            else
            {
                MessageBox.Show("不能同时打开多个子窗体！");
            }
        }

        private void 宾客查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                CustomerSearch a = new CustomerSearch();
                a.MdiParent = this;
                a.Show();
            }
            else
            {
                MessageBox.Show("不能同时打开多个子窗体！");
            }
        }

        private void 预定查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                BookSearch a = new BookSearch();
                a.MdiParent = this;
                a.Show();
            }
            else
            {
                MessageBox.Show("不能同时打开多个子窗体！");
            }
        }

        private void 客房添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                roomAdd a = new roomAdd();
                a.MdiParent = this;
                a.Show();
            }
            else
            {
                MessageBox.Show("不能同时打开多个子窗体！");
            }
        }

        private void 客房管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                roomManage a = new roomManage();
                a.MdiParent = this;
                a.Show();
            }
            else
            {
                MessageBox.Show("不能同时打开多个子窗体！");
            }
        }

        private void 历史记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Lishi a = new Lishi();
                a.MdiParent = this;
                a.Show();
            }
            else
            {
                MessageBox.Show("不能同时打开多个子窗体！");
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("敬请期待");
        }
    }
}

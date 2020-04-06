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
    public partial class userManage : Form
    {
        string lpwd;
        string ltype;
        public userManage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void shuaxin()
        {
            DataSet ds = new DataSet();
            ds = DBhelp.getSql("select * from [users]");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void userMange_Load(object sender, EventArgs e)
        {
            shuaxin();
            dataGridView1.Columns[0].HeaderText = "用户名";
            dataGridView1.Columns[1].HeaderText = "密码";
            dataGridView1.Columns[2].HeaderText = "权限";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtusername.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lpwd = txtuserpwd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ltype= comType.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string uname = txtusername.Text.Trim();
            string upwd = txtuserpwd.Text.Trim();
            string utype = comType.Text.Trim();
            if (uname == "" || upwd == "")
            {
                MessageBox.Show("请先选择要修改的信息");
            }
            else
            {
                if (upwd != lpwd || utype != ltype)
                {
                    int i = DBhelp.exeSql("update [users] set userPwd=N'" + upwd + "',userType=N'" + utype + "' where userName=N'" + uname + "'");
                    if (i > 0)
                    {
                        MessageBox.Show("修改成功");
                        txtusername.Text = "";
                        txtuserpwd.Text = "";
                        comType.Text = "";
                        shuaxin();
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                }
                else
                {
                    MessageBox.Show("请输入修改的内容");
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string uname = txtusername.Text.Trim();
            if (uname == "")
            {
                MessageBox.Show("请先选择要删除的信息");
            }
            else
            {
                int i = DBhelp.exeSql("delete from [users] where userName=N'" + uname + "'");
                if (i > 0)
                {
                    MessageBox.Show("删除成功");
                    txtusername.Text = "";
                    txtuserpwd.Text = "";
                    comType.Text = "";
                    shuaxin();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }


    }
}

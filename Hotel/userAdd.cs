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
    public partial class userAdd : Form
    {
        public userAdd()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string uname = txtusername.Text.Trim();
            string upwd = txtuserpwd.Text.Trim();
            string utype = comType.Text.Trim();
            if (uname == "" || upwd == "")
            {
                MessageBox.Show("输入的数据不完整，无法添加");
            }
            else
            {
                DataSet ds = DBhelp.getSql("select * from [users] where userName='" + uname + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("此用户已存在");
                }
                else
                {
                    int i = DBhelp.exeSql("insert into [users] values(N'" + uname + "',N'" + upwd + "',N'" + utype + "')");
                    if (i > 0)
                    {
                        MessageBox.Show("添加成功");
                        txtusername.Text = "";
                        txtuserpwd.Text = "";
                        comType.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }
                }
            }
        }


    }
}

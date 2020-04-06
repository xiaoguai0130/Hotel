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
    public partial class roomAdd : Form
    {
        public roomAdd()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rtype = comType.Text.Trim();
            string rnum = txtNum.Text.Trim();
            string rmoney = txtMoney.Text.Trim();
            string rbeizhu = txtBeizhu.Text.Trim();
            string zhuangtai = "空";
            if (rtype == "" || rnum == "" || rmoney == "")
            {
                MessageBox.Show("输入的信息不完整，无法添加");
            }
            else
            {
                DataSet ds = DBhelp.getSql("select * from [rooms] where rNum='" + rnum + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("该房间号已存在");
                }
                else
                {
                    int i = DBhelp.exeSql("insert into [rooms] values(N'" + rnum + "',N'" + rtype + "',N'" + rmoney + "',N'" + zhuangtai + "',N'" + rbeizhu + "')");
                    if (i > 0)
                    {
                        MessageBox.Show("添加成功");
                        txtMoney.Text = "";
                        txtNum.Text = "";
                        comType.Text = "";
                        txtBeizhu.Text = "";
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

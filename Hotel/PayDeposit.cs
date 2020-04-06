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
    public partial class PayDeposit : Form
    {
        public PayDeposit()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtYajin.Text == "" || txtNum.Text == "")
            {
                MessageBox.Show("信息不完整，无法提交");
            }
            else
            {
                string rnum = txtNum.Text.Trim();
                int yajin1 = Convert.ToInt32(txtByajin.Text);
                int yajin2 = Convert.ToInt32(txtYajin.Text);


                string yajin = (yajin1 + yajin2).ToString();
                int i = DBhelp.exeSql("update [Customer] set rYajin=N'" + yajin + "' where rNum=N'" + rnum + "'");
                if (i > 0)
                {
                    MessageBox.Show("补交成功");
                    txtName.Text = "";
                    txtNum.Text = "";
                    txtNum1.Text = "";
                    txtDate.Text = "";
                    txtMoney.Text = "";
                    txtYajin.Text = "";
                    txtByajin.Text = "";

                }
                else
                {
                    MessageBox.Show("补交失败");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rnum = txtNum.Text.Trim();
            string yajin = "";
            if (rnum == "")
            {
                MessageBox.Show("请输入房间号");
            }
            else
            {
                DataSet ds = new DataSet();
                ds = DBhelp.getSql("select * from [Customer] where rNum=N'" + rnum + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtNum1.Text = ds.Tables[0].Rows[0][9].ToString();
                    txtDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtMoney.Text = ds.Tables[0].Rows[0][10].ToString();
                    yajin = ds.Tables[0].Rows[0][11].ToString();
                    if (yajin == "")
                    {
                        txtYajin.Text = "0";
                    }
                    else
                    {
                        txtYajin.Text = yajin;
                    }
                }
                else
                {
                    MessageBox.Show("此房间未曾使用过");
                }
            }
        }
    }
}

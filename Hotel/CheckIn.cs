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
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void shuaxin()
        {
            DataSet ds = new DataSet();
            ds = DBhelp.getSql("select * from [rooms] where rZhuangtai =N'空'");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            shuaxin();
            dataGridView1.Columns[0].HeaderText = "房号";
            dataGridView1.Columns[1].HeaderText = "类型";
            dataGridView1.Columns[2].HeaderText = "价格";
            dataGridView1.Columns[3].HeaderText = "状态";
            dataGridView1.Columns[4].HeaderText = "备注";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comRoom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMoney.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtzhushi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnzhu_Click(object sender, EventArgs e)
        {
            string uname = txtName.Text.Trim();
            string ugender = comGender.Text.Trim();
            string uzhangjian = txtZhengjian.Text.Trim();
            string uphone = txtPhone.Text.Trim();
            string ushijian = txtDate.Text.Trim();
            string utianshu = txtTianshu.Text.Trim();
            string ubeizhu = txtBeizhu.Text.Trim();
            string uleixing = comRoom.Text.Trim();
            string ujiage = txtMoney.Text.Trim();
            string unum = txtNum.Text.Trim();
            string uyajin = comYajin.Text.Trim();
            string uybeizhu = txtzhushi.Text.Trim();
            if (uname == "" || ugender == "" || uzhangjian == "" || uphone == "" || ushijian == "" || utianshu == "" || uleixing == "" || ujiage == "" || unum == "")
            {
                MessageBox.Show("输入的信息不完整，无法入住");
            }
            else
            {
            qian:
                string id = "";         //组合随机生成的id
                int linshi = 0;         //接收随机生成的数字      
                Random aa = new Random();
                for (int i = 0; i < 4; i++)
                {
                    linshi = aa.Next(0, 9);
                    id = id + linshi;
                }
                int ID = Convert.ToInt32(id);  //将id转换为 int类型
                DataSet dc = DBhelp.getSql("select * from [lishi] where ID='" + ID + "'");
                DataSet ds = DBhelp.getSql("select * from [Customer] where ID='" + ID + "'");
                if (ds.Tables[0].Rows.Count > 0||dc.Tables[0].Rows.Count>0)
                {
                    goto qian;
                }
                else
                {
                    int i = DBhelp.exeSql("insert into [Customer] values(" + ID + ",N'" + uname + "',N'" + ugender + "',N'" + uzhangjian + "',N'" + uphone + "',N'" + ushijian + "',N'" + utianshu + "',N'" + ubeizhu + "',N'" + uleixing + "',N'" + unum + "',N'" + ujiage + "',N'" + uyajin + "',N'" + uybeizhu + "')");
                    if (i > 0)
                    {
                        string ee = "占用";
                        int a = DBhelp.exeSql("update [rooms] set rZhuangtai=N'" + ee + "' where rNum=N'" + unum + "'");
                        if (a > 0)
                        {
                            MessageBox.Show("入住成功");
                            shuaxin();
                            txtName.Text = "";
                            txtPhone.Text = "";
                            txtZhengjian.Text = "";
                            comGender.Text = "";
                            txtDate.Text = "";
                            txtTianshu.Text = "";
                            txtBeizhu.Text = "";
                            comRoom.Text = "";
                            txtMoney.Text = "";
                            txtNum.Text = "";
                            comYajin.Text = "";
                            txtzhushi.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("客房不可用");
                        }
                    }
                    else
                    {
                        MessageBox.Show("入住失败");
                    }
                }
            }
        }
    }
}

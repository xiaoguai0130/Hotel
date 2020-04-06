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
    public partial class CancelReservation : Form
    {
        public CancelReservation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void shuaxin()
        {
            DataSet ds = new DataSet();
            ds = DBhelp.getSql("select * from [yuding]");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnzhu_Click(object sender, EventArgs e)
        {
            string uname = txtName.Text.Trim();
            string ufnum = txtNum.Text.Trim();
            if (uname == "" || ufnum == "")
            {
                MessageBox.Show("请先选入客户");
            }
            else
            {
                int i = DBhelp.exeSql("delete from [yuding] where yName=N'" + uname + "' and rNum=N'" + ufnum + "'");
                if (i > 0)
                {
                    string ee = "空";
                    int a = DBhelp.exeSql("update [rooms] set rZhuangtai=N'" + ee + "' where rNum=N'" + ufnum + "'");
                    if (a > 0)
                    {
                        MessageBox.Show("取消预定成功");
                        txtName.Text = "";
                        txtPhone.Text = "";
                        txtDate.Text = "";
                        txtTianshu.Text = "";
                        txtBeizhu.Text = "";
                        comRoom.Text = "";
                        txtMoney.Text = "";
                        txtNum.Text = "";
                        comYajin.Text = "";
                        txtzhushi.Text = "";
                        shuaxin();
                    }
                    else
                    {
                        MessageBox.Show("房间状态出错");
                    }
                }
                else
                {
                    MessageBox.Show("取消预定失败");
                }
            }
        }

        private void CancelReservation_Load(object sender, EventArgs e)
        {
            shuaxin();
            dataGridView1.Columns[0].HeaderText = "编号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "手机号码";
            dataGridView1.Columns[3].HeaderText = "入住时间";
            dataGridView1.Columns[4].HeaderText = "入住天数";
            dataGridView1.Columns[5].HeaderText = "客户备注";
            dataGridView1.Columns[6].HeaderText = "房间类型";
            dataGridView1.Columns[7].HeaderText = "房间号";
            dataGridView1.Columns[8].HeaderText = "单价";
            dataGridView1.Columns[9].HeaderText = "押金";
            dataGridView1.Columns[10].HeaderText = "房间备注";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDate.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTianshu.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBeizhu.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comRoom.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtNum.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtMoney.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comYajin.Text= dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtzhushi.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }
    }
}

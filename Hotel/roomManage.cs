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
    public partial class roomManage : Form
    {
        string type;
        string money;
        string beizhu;
        public roomManage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void shuaxin()
        {
            DataSet ds = new DataSet();
            ds = DBhelp.getSql("select * from [rooms]");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string rnum = txtNum.Text.Trim();
            string rtype = comType.Text.Trim();
            string rmoney = txtMoney.Text.Trim();
            string rbeizhu = txtBeizhu.Text.Trim();
            if (rtype == "" || rnum == "" || rmoney == "")
            {
                MessageBox.Show("请先选择要修改的信息");
            }
            else
            {
                if (rtype != type || rmoney != money || rbeizhu != beizhu)
                {
                    int i = DBhelp.exeSql("update [rooms] set rType=N'" + rtype + "',rMoney=N'" + rmoney + "',rBeizhu=N'" + rbeizhu + "'  where rNum=N'" + rnum + "'");
                    if (i > 0)
                    {
                        MessageBox.Show("修改成功");
                        txtNum.Text = "";
                        txtMoney.Text = "";
                        txtBeizhu.Text = "";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            type= comType.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            money= txtMoney.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            beizhu= txtBeizhu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void roomManage_Load(object sender, EventArgs e)
        {
            shuaxin();
            dataGridView1.Columns[0].HeaderText = "房号";
            dataGridView1.Columns[1].HeaderText = "类型";
            dataGridView1.Columns[2].HeaderText = "价格";
            dataGridView1.Columns[3].HeaderText = "状态";
            dataGridView1.Columns[4].HeaderText = "备注";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string rnum = txtNum.Text.Trim();
            string rtype = comType.Text.Trim();
            string rmoney = txtMoney.Text.Trim();
            if (rtype == "" || rnum == "" || rmoney == "")
            {
                MessageBox.Show("请先选择要删除的信息");
            }
            else
            {
                int i = DBhelp.exeSql("delete from [rooms] where rNum=N'" + rnum + "'");
                if (i > 0)
                {
                    MessageBox.Show("删除成功");
                    txtNum.Text = "";
                    txtMoney.Text = "";
                    txtBeizhu.Text = "";
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

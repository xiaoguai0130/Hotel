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
    public partial class BookSearch : Form
    {
        public BookSearch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = txtName.Text.Trim();
            string uphone = txtPhone.Text.Trim();
            string rnum = txtNum.Text.Trim();
            string udate = txtDate.Text.Trim();

            if (rnum != "" && uphone != "" && uname != "" && udate != "")
            {
                DataSet ds = new DataSet();
                ds = DBhelp.getSql("select * from [yuding] where yName=N'" + uname + "' and yTime=N'" + udate + "' and yPhone =N'" + uphone + "' and rNum=N'" + rnum + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
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
                else
                {
                    MessageBox.Show("预定信息输入有误");
                }
            }
            else
            {
                MessageBox.Show("请输入完整的信息");
            }
        }
    }
}

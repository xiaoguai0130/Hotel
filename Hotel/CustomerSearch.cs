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
    public partial class CustomerSearch : Form
    {
        public CustomerSearch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = txtName.Text.Trim();
            string uzhengjian = txtZhengjian.Text.Trim();
            string rnum = txtNum.Text.Trim();
            string ugender = comGender.Text.Trim();

            if (rnum != "" && uzhengjian != "" && uname != "" && ugender!="")
            {
                DataSet ds = new DataSet();
                ds = DBhelp.getSql("select * from [Customer] where bName=N'"+uname+"' and bGender=N'"+ugender+"' and bZhengjian =N'"+uzhengjian+"' and rNum=N'"+rnum+"'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "姓名";
                    dataGridView1.Columns[2].HeaderText = "性别";
                    dataGridView1.Columns[3].HeaderText = "证件号码";
                    dataGridView1.Columns[4].HeaderText = "手机号码";
                    dataGridView1.Columns[5].HeaderText = "入住日期";
                    dataGridView1.Columns[6].HeaderText = "预计天数";
                    dataGridView1.Columns[7].HeaderText = "用户备注";
                    dataGridView1.Columns[8].HeaderText = "房间类型";
                    dataGridView1.Columns[9].HeaderText = "房间号码";
                    dataGridView1.Columns[10].HeaderText = "价格";
                    dataGridView1.Columns[11].HeaderText = "押金";
                    dataGridView1.Columns[12].HeaderText = "房间备注";
                }
                else
                {
                    MessageBox.Show("宾客信息输入有误");
                }
            }
            else
            {
                MessageBox.Show("请输入完整的信息");
            }
        }
    }
}

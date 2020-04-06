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
    public partial class CheckOut : Form
    {
        string lid;
        string lname;
        string lgender;
        string lzhengjian;
        string lphone;
        string lzdate;
        string ltdate;
        string ltianshu;
        string lxiaofei;
        string ltype;
        string lnum;
        string lbeizhu;

        public CheckOut()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int yajin = 0;

            string rnum = txtNum.Text.Trim();
            string uname = txtName.Text.Trim();
            if (uname == "" || rnum == "")
            {
                MessageBox.Show("输入的信息不完整，无法查询");
            }
            else
            {
                DataSet ds = new DataSet();
                ds = DBhelp.getSql("select * from [Customer] where rNum=N'" + rnum + "' and bName=N'" + uname + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];

                    lid = ds.Tables[0].Rows[0][0].ToString();
                    lname = ds.Tables[0].Rows[0][1].ToString();
                    lgender = ds.Tables[0].Rows[0][2].ToString();
                    lzhengjian = ds.Tables[0].Rows[0][3].ToString();
                    lphone = ds.Tables[0].Rows[0][4].ToString();
                    lzdate = ds.Tables[0].Rows[0][5].ToString();
                    ltianshu = ds.Tables[0].Rows[0][6].ToString();
                    ltype = ds.Tables[0].Rows[0][8].ToString();
                    lnum = ds.Tables[0].Rows[0][9].ToString();
                    lbeizhu= ds.Tables[0].Rows[0][12].ToString();
                    
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
                    txtYingfu.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    txtYajin.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                    int yingfu = Convert.ToInt32(txtYingfu.Text);
                    if (txtYajin.Text != "")
                    {
                        yajin = Convert.ToInt32(txtYajin.Text);
                    }
                    else
                    {
                        txtYajin.Text = "0";
                    }
                    txtZhaoling.Text = (yajin - yingfu).ToString();
                }
                else
                {
                    MessageBox.Show("没有这个人");
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rnum = txtNum.Text.Trim();
            string uname = txtName.Text.Trim();
            string yajin = txtYajin.Text.Trim();
            string ushifu = txtShifu.Text.Trim();
            if (yajin == "" )
            {
                MessageBox.Show("请先查询信息");
            }
            else
            {
                if (ushifu != "")
                {
                    int i = DBhelp.exeSql("delete from [Customer] where bName=N'" + uname + "' and rNum=N'" + rnum + "'");
                    if (i > 0)
                    {
                        string ee = "空";
                        int a = DBhelp.exeSql("update [rooms] set rZhuangtai=N'" + ee + "' where rNum=N'" + rnum + "'");
                        if (a > 0)
                        {

                            ltdate = DateTime.Now.ToShortDateString().ToString();
                            lxiaofei = txtShifu.Text.Trim();
                            int c = DBhelp.exeSql("insert into [lishi] values(N'" + lid + "',N'" + lname + "',N'" + lgender + "',N'" + lzhengjian + "',N'" + lphone + "',N'" + lzdate + "',N'" + ltdate + "',N'" + ltianshu + "',N'" + lxiaofei + "',N'" + ltype + "',N'" + lnum + "',N'" + lbeizhu + "')"); ;
                            if (c > 0)
                            {

                                MessageBox.Show("退房成功");
                                txtName.Text = "";
                                txtNum.Text = "";
                                txtShifu.Text = "";
                                txtYingfu.Text = "";
                                txtYajin.Text = "";
                                txtZhaoling.Text = "";
                                dataGridView1.DataSource = "";
                            }
                            else
                            {
                                MessageBox.Show("历史记录加载出错");
                            }
                        }


                        else
                        {
                            MessageBox.Show("房间状态出现故障");
                        }
                    }
                    else
                    {
                        MessageBox.Show("请输入宾客的消费");
                    }

                }


                else
                {
                    MessageBox.Show("退房失败");
                }
            }
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
           

        }
    }
}

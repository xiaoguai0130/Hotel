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
    public partial class roomSearch : Form
    {
        public roomSearch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void wenzi()
        {
            dataGridView1.Columns[0].HeaderText = "房号";
            dataGridView1.Columns[1].HeaderText = "类型";
            dataGridView1.Columns[2].HeaderText = "价格";
            dataGridView1.Columns[3].HeaderText = "状态";
            dataGridView1.Columns[4].HeaderText = "备注";
        }

        private void chazhao_Click(object sender, EventArgs e)
        {
            string rnum = txtNum.Text.Trim();
            string rtype = comType.Text.Trim();
            string rzhuangtai = comZhuangtai.Text.Trim();

            if (rnum == "" && rtype != "" && rzhuangtai != "")
            {
                DataSet ds = new DataSet();
                ds = DBhelp.getSql("select * from [rooms] where rType=N'" + rtype + "' and rZhuangtai=N'" + rzhuangtai + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    wenzi();

                    comType.Text = "";
                    comZhuangtai.Text = "";
                }
                else
                {
                    MessageBox.Show("房间信息输入有误");
                }
            }
            else if(rnum == "" && rtype == "" && rzhuangtai == "")
            {
                DataSet ds = new DataSet();
                ds = DBhelp.getSql("select * from [rooms] ");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    wenzi();
                }
                else
                {
                    MessageBox.Show("房间信息输入有误");
                }
            }
            else if (rnum != "" && rtype == "" && rzhuangtai == "")
            {
                DataSet ds = new DataSet();
                ds = DBhelp.getSql("select * from [rooms] where rNum=N'" + rnum + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    wenzi();
                    txtNum.Text = "";
                }
                else
                {
                    MessageBox.Show("房间信息输入有误");
                }
            }
            else if (rnum == "" && rtype != "" && rzhuangtai == "")
            {
                DataSet ds = new DataSet();
                ds = DBhelp.getSql("select * from [rooms] where rType=N'"+ rtype + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    wenzi();
                    comType.Text = "";
                }
                else
                {
                    MessageBox.Show("房间信息输入有误");
                }
            }
            else if (rnum == "" && rtype == "" && rzhuangtai != "")
            {
                DataSet ds = new DataSet();
                ds = DBhelp.getSql("select * from [rooms] where rZhuangtai=N'" + rzhuangtai + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    wenzi();
                    comZhuangtai.Text = "";
                }
                else
                {
                    MessageBox.Show("房间信息输入有误");
                }
            }
            else
            {
                MessageBox.Show("请单独输入房号，类型状态可以一起");
                comType.Text = "";
                comZhuangtai.Text = "";
                txtNum.Text = "";
            }

        }
    }
}

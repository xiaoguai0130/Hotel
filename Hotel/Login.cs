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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string uname = txtusername.Text.Trim();
            string upwd = txtusername.Text.Trim();
            DataSet ds = DBhelp.getSql("select * from [users] where userName='"+uname+"' and userPwd='"+upwd+"'");
            if(ds.Tables[0].Rows.Count>0)
            {
                MainForm m = new MainForm();
                m.UserType = ds.Tables[0].Rows[0][2].ToString();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败");
                txtuserpwd.Text = "";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

namespace Hotel
{
    partial class BooKRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnzhu = new System.Windows.Forms.Button();
            this.txtBeizhu = new System.Windows.Forms.TextBox();
            this.txtTianshu = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comYajin = new System.Windows.Forms.ComboBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtzhushi = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comRoom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnzhu
            // 
            this.btnzhu.Location = new System.Drawing.Point(238, 435);
            this.btnzhu.Name = "btnzhu";
            this.btnzhu.Size = new System.Drawing.Size(75, 23);
            this.btnzhu.TabIndex = 36;
            this.btnzhu.Text = "预定";
            this.btnzhu.UseVisualStyleBackColor = true;
            this.btnzhu.Click += new System.EventHandler(this.btnzhu_Click);
            // 
            // txtBeizhu
            // 
            this.txtBeizhu.Location = new System.Drawing.Point(169, 171);
            this.txtBeizhu.Multiline = true;
            this.txtBeizhu.Name = "txtBeizhu";
            this.txtBeizhu.Size = new System.Drawing.Size(293, 65);
            this.txtBeizhu.TabIndex = 34;
            // 
            // txtTianshu
            // 
            this.txtTianshu.Location = new System.Drawing.Point(169, 136);
            this.txtTianshu.Name = "txtTianshu";
            this.txtTianshu.Size = new System.Drawing.Size(144, 21);
            this.txtTianshu.TabIndex = 33;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(169, 106);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(144, 21);
            this.txtDate.TabIndex = 32;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(169, 76);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(144, 21);
            this.txtPhone.TabIndex = 31;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(170, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 21);
            this.txtName.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(490, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(422, 426);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comRoom);
            this.groupBox1.Controls.Add(this.comYajin);
            this.groupBox1.Controls.Add(this.txtMoney);
            this.groupBox1.Controls.Add(this.txtzhushi);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(100, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 141);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择客房";
            // 
            // comYajin
            // 
            this.comYajin.FormattingEnabled = true;
            this.comYajin.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "500"});
            this.comYajin.Location = new System.Drawing.Point(251, 54);
            this.comYajin.Name = "comYajin";
            this.comYajin.Size = new System.Drawing.Size(100, 20);
            this.comYajin.TabIndex = 16;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(251, 27);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(100, 21);
            this.txtMoney.TabIndex = 15;
            // 
            // txtzhushi
            // 
            this.txtzhushi.Location = new System.Drawing.Point(69, 85);
            this.txtzhushi.Multiline = true;
            this.txtzhushi.Name = "txtzhushi";
            this.txtzhushi.ReadOnly = true;
            this.txtzhushi.Size = new System.Drawing.Size(282, 50);
            this.txtzhushi.TabIndex = 14;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(70, 54);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(104, 21);
            this.txtNum.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(180, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "押    金：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "客房价格：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "客房备注：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "客房号码：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "客房类型：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "备注信息：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "预订天数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "预订时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "联系电话：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "宾客姓名：";
            // 
            // comRoom
            // 
            this.comRoom.Location = new System.Drawing.Point(69, 28);
            this.comRoom.Name = "comRoom";
            this.comRoom.ReadOnly = true;
            this.comRoom.Size = new System.Drawing.Size(105, 21);
            this.comRoom.TabIndex = 17;
            // 
            // BooKRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 499);
            this.Controls.Add(this.btnzhu);
            this.Controls.Add(this.txtBeizhu);
            this.Controls.Add(this.txtTianshu);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "BooKRoom";
            this.RightToLeftLayout = true;
            this.Text = "宾客预定";
            this.Load += new System.EventHandler(this.BooKRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnzhu;
        private System.Windows.Forms.TextBox txtBeizhu;
        private System.Windows.Forms.TextBox txtTianshu;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comYajin;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtzhushi;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox comRoom;
    }
}
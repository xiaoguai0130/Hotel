namespace Hotel
{
    partial class CheckIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comYajin = new System.Windows.Forms.ComboBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtzhushi = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtZhengjian = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTianshu = new System.Windows.Forms.TextBox();
            this.txtBeizhu = new System.Windows.Forms.TextBox();
            this.comGender = new System.Windows.Forms.ComboBox();
            this.btnzhu = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comRoom = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "宾客姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "性    别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "证件号码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "联系电话：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "入住时间：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "预计天数：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "备注信息：";
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
            this.groupBox1.Location = new System.Drawing.Point(65, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 141);
            this.groupBox1.TabIndex = 8;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(440, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(422, 426);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 21);
            this.txtName.TabIndex = 10;
            // 
            // txtZhengjian
            // 
            this.txtZhengjian.Location = new System.Drawing.Point(135, 88);
            this.txtZhengjian.Name = "txtZhengjian";
            this.txtZhengjian.Size = new System.Drawing.Size(144, 21);
            this.txtZhengjian.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(134, 118);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(144, 21);
            this.txtPhone.TabIndex = 12;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(134, 148);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(144, 21);
            this.txtDate.TabIndex = 13;
            // 
            // txtTianshu
            // 
            this.txtTianshu.Location = new System.Drawing.Point(134, 178);
            this.txtTianshu.Name = "txtTianshu";
            this.txtTianshu.Size = new System.Drawing.Size(144, 21);
            this.txtTianshu.TabIndex = 14;
            // 
            // txtBeizhu
            // 
            this.txtBeizhu.Location = new System.Drawing.Point(134, 208);
            this.txtBeizhu.Name = "txtBeizhu";
            this.txtBeizhu.Size = new System.Drawing.Size(293, 21);
            this.txtBeizhu.TabIndex = 15;
            // 
            // comGender
            // 
            this.comGender.FormattingEnabled = true;
            this.comGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comGender.Location = new System.Drawing.Point(135, 58);
            this.comGender.Name = "comGender";
            this.comGender.Size = new System.Drawing.Size(143, 20);
            this.comGender.TabIndex = 16;
            // 
            // btnzhu
            // 
            this.btnzhu.Location = new System.Drawing.Point(181, 404);
            this.btnzhu.Name = "btnzhu";
            this.btnzhu.Size = new System.Drawing.Size(75, 34);
            this.btnzhu.TabIndex = 17;
            this.btnzhu.Text = "入住";
            this.btnzhu.UseVisualStyleBackColor = true;
            this.btnzhu.Click += new System.EventHandler(this.btnzhu_Click);
            // 
            // comRoom
            // 
            this.comRoom.Location = new System.Drawing.Point(69, 27);
            this.comRoom.Name = "comRoom";
            this.comRoom.ReadOnly = true;
            this.comRoom.Size = new System.Drawing.Size(105, 21);
            this.comRoom.TabIndex = 17;
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 471);
            this.Controls.Add(this.btnzhu);
            this.Controls.Add(this.comGender);
            this.Controls.Add(this.txtBeizhu);
            this.Controls.Add(this.txtTianshu);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtZhengjian);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CheckIn";
            this.Text = "宾客登记";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comYajin;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtzhushi;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtZhengjian;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTianshu;
        private System.Windows.Forms.TextBox txtBeizhu;
        private System.Windows.Forms.ComboBox comGender;
        private System.Windows.Forms.Button btnzhu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox comRoom;
    }
}
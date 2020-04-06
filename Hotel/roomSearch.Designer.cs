namespace Hotel
{
    partial class roomSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chazhao = new System.Windows.Forms.Button();
            this.comZhuangtai = new System.Windows.Forms.ComboBox();
            this.comType = new System.Windows.Forms.ComboBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chazhao);
            this.groupBox1.Controls.Add(this.comZhuangtai);
            this.groupBox1.Controls.Add(this.comType);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(58, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请输入客房信息";
            // 
            // chazhao
            // 
            this.chazhao.Location = new System.Drawing.Point(654, 21);
            this.chazhao.Name = "chazhao";
            this.chazhao.Size = new System.Drawing.Size(58, 30);
            this.chazhao.TabIndex = 6;
            this.chazhao.Text = "查找";
            this.chazhao.UseVisualStyleBackColor = true;
            this.chazhao.Click += new System.EventHandler(this.chazhao_Click);
            // 
            // comZhuangtai
            // 
            this.comZhuangtai.FormattingEnabled = true;
            this.comZhuangtai.Items.AddRange(new object[] {
            "空",
            "占用",
            "预定"});
            this.comZhuangtai.Location = new System.Drawing.Point(494, 27);
            this.comZhuangtai.Name = "comZhuangtai";
            this.comZhuangtai.Size = new System.Drawing.Size(121, 20);
            this.comZhuangtai.TabIndex = 5;
            // 
            // comType
            // 
            this.comType.FormattingEnabled = true;
            this.comType.Items.AddRange(new object[] {
            "单人房",
            "大床房",
            "双人房",
            "家庭房"});
            this.comType.Location = new System.Drawing.Point(284, 27);
            this.comType.Name = "comType";
            this.comType.Size = new System.Drawing.Size(108, 20);
            this.comType.TabIndex = 4;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(87, 27);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 21);
            this.txtNum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "客房状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "客房类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客房号码：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(677, 306);
            this.dataGridView1.TabIndex = 1;
            // 
            // roomSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "roomSearch";
            this.Text = "房态查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button chazhao;
        private System.Windows.Forms.ComboBox comZhuangtai;
        private System.Windows.Forms.ComboBox comType;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
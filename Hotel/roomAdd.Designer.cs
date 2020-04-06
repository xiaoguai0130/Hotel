namespace Hotel
{
    partial class roomAdd
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
            this.button1 = new System.Windows.Forms.Button();
            this.comType = new System.Windows.Forms.ComboBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtBeizhu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客房类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "客房号码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "客房价格：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "客房备注：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comType
            // 
            this.comType.FormattingEnabled = true;
            this.comType.Items.AddRange(new object[] {
            "单人房",
            "双人房",
            "家庭房",
            "大床房"});
            this.comType.Location = new System.Drawing.Point(157, 43);
            this.comType.Name = "comType";
            this.comType.Size = new System.Drawing.Size(121, 20);
            this.comType.TabIndex = 5;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(157, 85);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(121, 21);
            this.txtNum.TabIndex = 6;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(157, 130);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(121, 21);
            this.txtMoney.TabIndex = 7;
            // 
            // txtBeizhu
            // 
            this.txtBeizhu.Location = new System.Drawing.Point(157, 175);
            this.txtBeizhu.Multiline = true;
            this.txtBeizhu.Name = "txtBeizhu";
            this.txtBeizhu.Size = new System.Drawing.Size(253, 71);
            this.txtBeizhu.TabIndex = 8;
            // 
            // roomAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 384);
            this.Controls.Add(this.txtBeizhu);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.comType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "roomAdd";
            this.Text = "客房添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comType;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtBeizhu;
    }
}
namespace _02计算器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.cboCaoZuoFu = new System.Windows.Forms.ComboBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnJiSuan = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(12, 36);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 21);
            this.txtNum1.TabIndex = 0;
            // 
            // cboCaoZuoFu
            // 
            this.cboCaoZuoFu.FormattingEnabled = true;
            this.cboCaoZuoFu.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboCaoZuoFu.Location = new System.Drawing.Point(127, 36);
            this.cboCaoZuoFu.Name = "cboCaoZuoFu";
            this.cboCaoZuoFu.Size = new System.Drawing.Size(121, 20);
            this.cboCaoZuoFu.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(265, 36);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 21);
            this.txtNum2.TabIndex = 0;
            // 
            // btnJiSuan
            // 
            this.btnJiSuan.Location = new System.Drawing.Point(371, 36);
            this.btnJiSuan.Name = "btnJiSuan";
            this.btnJiSuan.Size = new System.Drawing.Size(75, 23);
            this.btnJiSuan.TabIndex = 2;
            this.btnJiSuan.Text = "=";
            this.btnJiSuan.UseVisualStyleBackColor = true;
            this.btnJiSuan.Click += new System.EventHandler(this.btnJiSuan_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 86);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(41, 12);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 217);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnJiSuan);
            this.Controls.Add(this.cboCaoZuoFu);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.ComboBox cboCaoZuoFu;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnJiSuan;
        private System.Windows.Forms.Label lblResult;
    }
}


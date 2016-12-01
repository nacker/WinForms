namespace 计算矩形的面积
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textChang = new System.Windows.Forms.TextBox();
            this.textKuan = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.resultLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(131, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "计算矩形的面积";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "长";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "宽";
            // 
            // textChang
            // 
            this.textChang.Location = new System.Drawing.Point(136, 107);
            this.textChang.Name = "textChang";
            this.textChang.Size = new System.Drawing.Size(256, 21);
            this.textChang.TabIndex = 1;
            // 
            // textKuan
            // 
            this.textKuan.Location = new System.Drawing.Point(136, 154);
            this.textKuan.Name = "textKuan";
            this.textKuan.Size = new System.Drawing.Size(256, 21);
            this.textKuan.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(89, 203);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(290, 23);
            this.btn.TabIndex = 3;
            this.btn.Text = "计算面积";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // resultLab
            // 
            this.resultLab.AutoSize = true;
            this.resultLab.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultLab.Location = new System.Drawing.Point(218, 257);
            this.resultLab.Name = "resultLab";
            this.resultLab.Size = new System.Drawing.Size(0, 16);
            this.resultLab.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 386);
            this.Controls.Add(this.resultLab);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.textKuan);
            this.Controls.Add(this.textChang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算矩形面积";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textChang;
        private System.Windows.Forms.TextBox textKuan;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label resultLab;
    }
}


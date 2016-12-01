namespace _02习题
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
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.关闭 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(87, 291);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(230, 97);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "喜 欢";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(488, 291);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(230, 97);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "不 喜 欢";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            this.btnNo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNo_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(208, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "你喜欢我吗?";
            // 
            // 关闭
            // 
            this.关闭.Location = new System.Drawing.Point(719, 47);
            this.关闭.Name = "关闭";
            this.关闭.Size = new System.Drawing.Size(75, 23);
            this.关闭.TabIndex = 3;
            this.关闭.Text = "close";
            this.关闭.UseVisualStyleBackColor = true;
            this.关闭.Click += new System.EventHandler(this.关闭_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 443);
            this.Controls.Add(this.关闭);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "你喜欢我吗?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 关闭;
    }
}


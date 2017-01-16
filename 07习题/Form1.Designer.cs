namespace _07.习题
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
            this.textStart = new System.Windows.Forms.TextBox();
            this.textEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textStart
            // 
            this.textStart.Location = new System.Drawing.Point(110, 42);
            this.textStart.Name = "textStart";
            this.textStart.Size = new System.Drawing.Size(100, 21);
            this.textStart.TabIndex = 0;
            this.textStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textStart_KeyPress);
            // 
            // textEnd
            // 
            this.textEnd.Location = new System.Drawing.Point(110, 93);
            this.textEnd.Name = "textEnd";
            this.textEnd.Size = new System.Drawing.Size(100, 21);
            this.textEnd.TabIndex = 1;
            this.textEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textStart_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始数:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "结束数:";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(33, 136);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(177, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "计算";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(33, 188);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(177, 21);
            this.textResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 535);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEnd);
            this.Controls.Add(this.textStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textStart;
        private System.Windows.Forms.TextBox textEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox textResult;
    }
}


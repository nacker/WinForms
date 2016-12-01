using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01第一个窗体程序
{
    public partial class Form1 : Form
    {
        private int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "关闭")
            {
                button1.Text = "显示";
                button2.Visible = false;
            }
            else {
                button1.Text = "关闭";
                button2.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            i++;
            this.Text = "MouseEnter" + i.ToString();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            i++;
            this.Text = "MouseMove" + i.ToString();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            i++;
            this.Text = "MouseLeave" + i.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult re = MessageBox.Show("helloWord!","消息", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            if (re == DialogResult.Yes)
            {
                this.Text = "你点了'是'按钮";
            }
            else if (re == DialogResult.No)
            {
                this.Text = "你点了'否'按钮";
            }
            else
            {
                this.Text = "你点了'取消'按钮";
            }
        }
    }
}        
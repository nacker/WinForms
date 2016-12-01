using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07.习题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int start, end;

            if (!int.TryParse(textStart.Text, out start))
            {
                MessageBox.Show("起始值输入有误,请重新输入!");
                textStart.Focus();
                textStart.SelectAll();
                return;
            }

            if (!int.TryParse(textEnd.Text, out end))
            {
                MessageBox.Show("结束值输入有误,请重新输入!");
                textEnd.Focus();
                textEnd.SelectAll();
                return;
            }

            if (start > end)
            {
                MessageBox.Show("起始值必须小于结束值,请重新输入!");
                textStart.Focus();
                textStart.SelectAll();
                return;
            }

            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum = sum + i;
            }

            textResult.Text = sum.ToString();
        }

        private void textStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                // 说明用户输入的不是一个数字字符
                e.Handled = true; // 阻止用户的输入
            }

            if (e.KeyChar == 8)
            {
                // 退格键
                e.Handled = false;
            }
        }
    }
}

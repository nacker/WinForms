using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04加法计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int num1, num2;
            if (int.TryParse(textNum1.Text, out num1) == false)
            {
                MessageBox.Show("输入的第一个数字有问题!");
                textNum1.Focus();
                textNum1.SelectAll();
                return;
            }

            if (int.TryParse(textNum2.Text, out num2) == false)
            {
                MessageBox.Show("输入的第二个数字有问题!");
                textNum2.Focus();
                textNum2.SelectAll();
                return;
            }


            int sum = num1 + num2;

            result.Text = sum.ToString();

        }

        private void textNum1_TextChanged(object sender, EventArgs e)
        {
            result.Text = "";
        }
    }
}
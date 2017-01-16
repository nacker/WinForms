using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08身份证检验算法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = 0;
            int year = 0;
            string id = textBox1.Text.Trim();
            if (id.Length == 15)
            {
                year = Convert.ToInt32(id.Substring(6, 2)) + 1900;
                
            }
            else if (id.Length == 18)
            {
                if (!this.CheckCardId(id))
                {
                    MessageBox.Show("身份证号码输入有误！");
                    return;
                }

                year = Convert.ToInt32(id.Substring(6, 2));

            }
            else
            {
                MessageBox.Show("身份证长度有误！");
                return;
            }

            age = DateTime.Now.Year - year;
            if (age >= 18)
            {
                pictureBox.Visible = true;
            }
            else
            {
                MessageBox.Show("你太小了！");
            }
        }

        /// <summary>
        /// 校验身份证号,如果正确则返回true
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool CheckCardId(string id) {
            int[] wQuan = { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
            string checkWei = "10X98765432";
            string num17 = id.Substring(0, 17);
            string num18 = id.Substring(17);

            int sum = 0;

            for (int i = 0; i < 17; i++)
            {
                sum = sum + Convert.ToInt32(num17[i]) * wQuan[i];
            }

            int mod = sum % 11;

            string result = checkWei[mod].ToString();

            if (num18.Equals(result,StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                // 用户输入数字以外的字符就阻止掉
                e.Handled = true; // 阻止用户的输入
            }

            // 如果第18位输入的是x，则不阻止
            if (tb.SelectionStart == 17 && (e.KeyChar == 'x' || e.KeyChar == 'X'))
            {
                e.Handled = false;
            }

            if (e.KeyChar == 8)
            {
                // 退格键
                e.Handled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox.Visible = false;
        }
    }
}

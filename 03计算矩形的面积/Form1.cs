using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算矩形的面积
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                double chang = Convert.ToDouble(textChang.Text);
                double kuan = Convert.ToDouble(textKuan.Text);

                double mianji = chang * kuan;

                resultLab.Text = mianji.ToString();
            }
            catch(Exception ex) {
                MessageBox.Show("计算发生错误,错误原因:" + ex.Message);
            }
            
        }
    }
}

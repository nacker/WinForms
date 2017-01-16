using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11美女时钟
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //string filePath = Application.StartupPath + "\\mm\\" + DateTime.Now.ToString("HH_mm") + "jpg";
            //this.pictureBox1.Image = Image.FromFile(filePath);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02习题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也喜欢你!");
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我还不喜欢你呢!");
        }

        private void btnNo_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            int x = r.Next(0,this.Size.Width - this.btnNo.Size.Width);
            int y = r.Next(0, this.ClientSize.Height - this.btnNo.Size.Height);

            Point p = new Point(x,y);
            btnNo.Location = p;
        }

        private void 关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

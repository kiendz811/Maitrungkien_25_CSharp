using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maitrungkien_25_CSharp
{
    public partial class lblInfor : Form
    {
        public lblInfor()
        {
            InitializeComponent();
        }

        private void tiệnÍchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String HovaTen = "Mai Trung Kiên";
            String Mssv = "1223360078";
            String MonThi = "Lập Trình WINDOWS2-C#";


            lbl1.Text = "Họ và tên: " + HovaTen;
            lbl1.Text += "\nMSSV: " + Mssv;
            lbl1.Text += "\nMônThi: " + MonThi;
            lbl1.Text += "\nThời Gian: " + System.DateTime.Now.ToString();

        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DinhDang dd = new DinhDang();
            dd.Show();
        }

        private void giớiThiệuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chương trình tiện ích", "Thông Tin");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giảiPTBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaiPhuongTrinhBac2 gpt = new GiaiPhuongTrinhBac2();
            gpt.Show();
        }
    }
}

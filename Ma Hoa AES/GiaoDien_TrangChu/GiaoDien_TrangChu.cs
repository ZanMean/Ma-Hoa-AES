using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ma_Hoa_AES.GiaoDien_TrangChu
{
    public partial class GiaoDien_TrangChu : Form
    {
        public GiaoDien_TrangChu()
        {
            InitializeComponent();
        }

        private void thuậtToánCeasarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaHoa_Ceasar.MaHoa_Ceasar form1 = new MaHoa_Ceasar.MaHoa_Ceasar();
            form1.ShowDialog();
            this.Close();
        }

        private void thuậtToánTrimethiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaHoa_Trimethius.MaHoa_Trimethius form1 = new MaHoa_Trimethius.MaHoa_Trimethius();
            form1.ShowDialog();
            this.Close();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            GiaoDien_TrangChu.GiaoDien_TrangChu form1 = new MaHoa_Trimethius.MaHoa_Trimethius();
            form1.ShowDialog();
            this.Close();*/
        }

        private void Form1Belasco_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaHoa_Belasco.MaHoa_Belasco form1 = new MaHoa_Belasco.MaHoa_Belasco();
            form1.ShowDialog();
            this.Close();
        }

        private void Form1Vignere_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaHoa_Vignere.MaHoa_Vignere form1 = new MaHoa_Vignere.MaHoa_Vignere();
            form1.ShowDialog();
            this.Close();
        }

        private void Form1Xor_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaHoa_Xor.MaHoa_Xor form1 = new MaHoa_Xor.MaHoa_Xor();
            form1.ShowDialog();
            this.Close();
        }
    }
}

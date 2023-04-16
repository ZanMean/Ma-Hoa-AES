using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ma_Hoa_AES.MaHoa_Ceasar
{
    public partial class MaHoa_Ceasar : Form
    {
        public MaHoa_Ceasar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void thuậtToánCeasarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thuậtToánTrimethiusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thuậtToánJCeasarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDien_TrangChu.GiaoDien_TrangChu form2 = new GiaoDien_TrangChu.GiaoDien_TrangChu();
            form2.ShowDialog();
            this.Close();
        }

        private void thuậtToánTrimethiusToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MaHoa_Trimethius.MaHoa_Trimethius form2 = new MaHoa_Trimethius.MaHoa_Trimethius();
            form2.ShowDialog();
            this.Close();
        }

        private void Form2Ceasar_Click(object sender, EventArgs e)
        {

        }

        private void Form2Belesco_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaHoa_Belasco.MaHoa_Belasco form2 = new MaHoa_Belasco.MaHoa_Belasco();
            form2.ShowDialog();
            this.Close();
        }

        private void Form2Vignere_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaHoa_Vignere.MaHoa_Vignere form2 = new MaHoa_Vignere.MaHoa_Vignere();
            form2.ShowDialog();
            this.Close();
        }

        private void Form2Xor_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaHoa_Xor.MaHoa_Xor form2 = new MaHoa_Xor.MaHoa_Xor();
            form2.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ma_Hoa_AES.MaHoa_Trimethius
{
    public partial class MaHoa_Trimethius : Form
    {
        public MaHoa_Trimethius()
        {
            InitializeComponent();
        }

        private void btnLuuGM_Click(object sender, EventArgs e)
        {

        }

        private void cmddecr_Click(object sender, EventArgs e)
        {

        }

        private void cmdreset2_Click(object sender, EventArgs e)
        {

        }

        private void Form3TrangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDien_TrangChu.GiaoDien_TrangChu form3 = new GiaoDien_TrangChu.GiaoDien_TrangChu();
            form3.ShowDialog();
            this.Close();
        }

        private void Form3Ceasar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaHoa_Ceasar.MaHoa_Ceasar form3 = new MaHoa_Ceasar.MaHoa_Ceasar();
            form3.ShowDialog();
            this.Close();
        }

        private void Form3Belasco_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaHoa_Belasco.MaHoa_Belasco form3 = new MaHoa_Belasco.MaHoa_Belasco();
            form3.ShowDialog();
            this.Close();
        }

        private void Form3Vignere_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaHoa_Vignere.MaHoa_Vignere form3 = new MaHoa_Vignere.MaHoa_Vignere();
            form3.ShowDialog();
            this.Close();
        }

        private void Form3Xor_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaHoa_Xor.MaHoa_Xor form3 = new MaHoa_Xor.MaHoa_Xor();
            form3.ShowDialog();
            this.Close();
        }
    }
}

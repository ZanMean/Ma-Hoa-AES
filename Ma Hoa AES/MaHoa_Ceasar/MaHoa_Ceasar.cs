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

        private void cmdmahoa_Click(object sender, EventArgs e)
        {
            try
            {
                txtreencr.Clear();
                txtdecr.Clear();
                txtkey1.Clear();
                txtrsdecr.Clear();
                string plaintext = txtencr.Text;
                int key = int.Parse(txtkey2.Text);
                if(string.IsNullOrEmpty(plaintext))
                {
                    MessageBox.Show("Không được để trống");
                }
                else
                {
                    if (key >= 100000)
                    {
                        MessageBox.Show("Số quá lớn, vui lòng nhập lại key");
                        txtkey1.Clear();
                    }
                    else
                    {
                        txtreencr.AppendText(CEASAR.encryppt(plaintext, key));
                    }
                }  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void cmddecr_Click(object sender, EventArgs e)
        {
            try
            {
                txtrsdecr.Clear();
                string cipherText = txtdecr.Text;
                int key = int.Parse(txtkey1.Text);
                if (string.IsNullOrEmpty(cipherText))
                {
                    MessageBox.Show("Không được để trống");
                }
                else
                {
                    if (key >= 100000)
                    {
                        MessageBox.Show("Số quá lớn, vui lòng nhập lại key");
                        txtkey1.Clear();
                    }
                    else
                    {
                        txtrsdecr.AppendText(CEASAR.decrypt(cipherText, key));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

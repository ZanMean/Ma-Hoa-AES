using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ma_Hoa_AES
{
    public partial class Ma_HOa : Form
    {
        Sec_AES aes = new Sec_AES();
        public Ma_HOa()
        {
            InitializeComponent();
        }

        private void cmdreset1_Click(object sender, EventArgs e)
        {
            txtencr.Text = "";
            txtreencr.Text = "";
            txtkey2.Text = "";

        }

        private void cmdreset2_Click(object sender, EventArgs e)
        {
            txtdecr.Text = "";
            txtrsdecr.Text = "";
            txtkey1.Text = "";

        }

        private void cmdmahoa_Click(object sender, EventArgs e)
        {
            if (txtencr.Text != "")
            {
                try
                {
                    txtreencr.Text = aes.Encrypt(txtencr.Text,txtkey2.Text , 128);
                }
                catch
                {
                    MessageBox.Show("Không Mã Hóa được", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa điền nội dung mã hóa", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmddecr_Click(object sender, EventArgs e)
        {
            if (txtdecr.Text != "")
            {
                try
                {
                    txtrsdecr.Text = aes.Decrypt(txtdecr.Text, txtkey1.Text, 128);
                }
                catch
                {
                    MessageBox.Show("Không Giải Mã được", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ô Nội Dung không được rỗng", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        OpenFileDialog open;
        SaveFileDialog save;

        private void btnNhapfileMH_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "|*.txt";
            if (open.ShowDialog()== DialogResult.OK)
            {
                
                StreamReader read = new StreamReader(open.FileName);
                txtencr.Text = read.ReadToEnd();
                read.Close();
            }

        }

        private void btnLuuMH_Click(object sender, EventArgs e)
        {
            save = new SaveFileDialog();
            save.Filter  = "|*.txt";
            save.RestoreDirectory = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(save.FileName);
                write.WriteLine(txtreencr.Text);
                write.Close();
                
            }
        }

        private void btnfileGM_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {

                StreamReader read = new StreamReader(open.FileName);
                txtdecr.Text = read.ReadToEnd();
                read.Close();
            }

        }

        private void btnLuuGM_Click(object sender, EventArgs e)
        {
            save = new SaveFileDialog();
            save.Filter = "|*.txt";
            save.RestoreDirectory = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(save.FileName);
                write.WriteLine(txtrsdecr.Text);
                write.Close();

            }

        }

        private void btnkey_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {

                StreamReader read = new StreamReader(open.FileName);
                txtkey2.Text = read.ReadToEnd();
                read.Close();
            }
        }

        private void btnKeyGM_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {

                StreamReader read = new StreamReader(open.FileName);
                txtkey1.Text = read.ReadToEnd();
                read.Close();
            }
        }

       
    }
}
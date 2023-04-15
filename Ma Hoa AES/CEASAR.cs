using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ma_Hoa_AES
{
    internal class CEASAR
    {
        public CEASAR(string plaintext, int key, string ciphertext)
        {
            this.plaintext = plaintext;
            this.key = key;
            this.ciphertext = ciphertext;
        }

        public string plaintext { get; set; }
        public int key { get; set; }
        public string ciphertext { get; set; }

        private string encryppt (string plaintext,int key)
        {
            ciphertext = "";
            int so;
            foreach(var c in plaintext)
            {
                if(c!= ' ')
                {
                    so = (int)c - 33;
                    so = (so + key) % 65500;
                    ciphertext = ciphertext + (char)(so + 33);
                }
                else
                {
                    ciphertext = ciphertext + c;
                }
            }
            return ciphertext;
        }
        private string decrypt(string plaintext, int key)
        {
            plaintext = "";
            int so;
            foreach(var c in ciphertext)
            {
                if (c != ' ')
                {
                    so = (int)c - 33;
                    so = (so - key + 65500) % 65500;
                    plaintext = plaintext + (char)(so + 33);
                }
                else
                {
                    plaintext = plaintext + c;
                }
            }
            return plaintext;
        }
    }
}

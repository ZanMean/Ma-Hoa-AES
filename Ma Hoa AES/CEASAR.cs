using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ma_Hoa_AES
{
    internal class CEASAR
    {
        public CEASAR(){ }
        public string cipher (string text, int key, string action)
        {
            return "";
        }
        public static string encryppt (string plaintext,int key)
        {
            string ciphertext = "";
            int so;
            foreach(var c in plaintext)
            {
                if(c!= ' ')
                {
                    so = (Int32)c - 33;
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
        public static string decrypt(string ciphertext, int key)
        {
            string plaintext = "";
            int so;
            foreach(var c in ciphertext)
            {
                if (c != ' ')
                {
                    so = (Int32)c - 33;
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

using System;

namespace Ma_Hoa_AES
{
    internal static class CEASARHelpers
    {

        public static string encryppt(string plaintext, int key)
        {
            string ciphertext = "";
            int so;
            foreach (var c in plaintext)
            {
                if (c != ' ')
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
    }
}
using System;
using System.Text;
using System.Windows.Forms;

namespace UM
{
    public static class KeygenPart
    {
        //Forgot from where
        public static bool ValidateLicense(string wc, string s)
        {
            byte[] ss = Encoding.UTF8.GetBytes(s);
            byte[] dr4k0nia =
{
    0x47, 0xbe, 0xb2, 0xd6, 0xdb, 0xa2, 0xaa, 0xc6,
    0xc2, 0xb3, 0x63, 0xa3, 0xa2, 0xbe, 0x52, 0x83,
    0x4e, 0x66, 0x86, 0x63, 0x56, 0x3a, 0x5a, 0x43,
    0x66, 0x6e, 0x16, 0x6a, 0x1b, 0x52, 0x3a, 0x16,
    0xf6, 0xae, 0xd6, 0xe3, 0x73, 0xdf, 0xa7, 0x43
};

            for (uint i = 0; i < dr4k0nia.Length; i++)
            {
                byte xyz = dr4k0nia[i];
                xyz = (byte)((xyz >> 0x2) | (xyz << 0x6));
                xyz += (byte)i;
                xyz = (byte)~xyz;
                xyz -= 0xe1;
                xyz ^= (byte)i;
                dr4k0nia[i] = xyz;
            }

            if (wc.Length <= 6 || s.Length <= 6)
            {
                MessageBox.Show(Encoding.UTF8.GetString(dr4k0nia));
                return false;
            }
            int PH = 0, x = 0;
            string P1 = null, P2 = null, P3 = null;
            string[] One = { "E", "z" }, Hello = { "H", "e", "l", "l", "o" };
            char[] ab = Encoding.UTF8.GetString((byte[])Encoding.Default.GetBytes(wc)).ToCharArray();
            byte[] a = { 11, 0, 0, 0, 6, 0, 0, 0, 17, 0, 0, 0, 13, 0, 0, 0, 13, 0, 0, 0, 14, 0, 0, 0, 5, 0, 0, 0, 13, 0, 0, 0, 16, 0, 0, 0, 10, 0, 0, 0, 11, 0, 0, 0, 6, 0, 0, 0, 14, 0, 0, 0, 14, 0, 0, 0, 4, 0, 0, 0, 11, 0, 0, 0, 6, 0, 0, 0, 14, 0, 0, 0, 14, 0, 0, 0, 4, 0, 0, 0, 11, 0, 0, 0, 9, 0, 0, 0, 13, 0, 0, 0, 11, 0, 0, 0, 10, 0, 0, 0, 8, 0, 0, 0, 10, 0, 0, 0, 10, 0, 0, 0, 16, 0, 0, 0, 8, 0, 0, 0, 4, 0, 0, 0, 6, 0, 0, 0, 10, 0, 0, 0, 13, 0, 0, 0, 16, 0, 0, 0, 8, 0, 0, 0, 10, 0, 0, 0, 4, 0, 0, 0, 16 };
            x = 3;
            for (int i = x; i < wc.Length; ++i)
            {
                PH += ab[i] * a[(i - 3) * 4];
                P1 = PH.ToString();
            }
            PH = 0;
            x = 6;
            for (int i = x; i < wc.Length; ++i)
            {
                PH += ab[i] * a[(i - 3) * 4];
                P2 = PH.ToString();
            }
            P3 = $"{int.Parse(P1) + int.Parse(P2)/ Hello.Length >> One.Length}"; 
            string finalSerial = Aes256.Encrypt(String.Format("{0}|{1}|{2}", P1, P2, P3), "................................");
            byte[] fs = Encoding.UTF8.GetBytes(Aes256.Decrypt(finalSerial, "................................"));
            if (ss.Length != fs.Length)
                return false;
            for (int i = 0; i < fs.Length; i++)
                if (fs[i] != ss[i])
                    return false;
            return true;
        }
    }
}

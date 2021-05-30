using System;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace UnpackMe
{
    public partial class UM : Form
    {
        public static bool r;
        public static string[] s = { "S", "u", "c", "c", "e", "s", "s" };
        public static string[] f = { "F", "a", "i", "l", "e", "d" };
        public static string[] h = { "H", "i", " ", "B", "r", "o" }; //SUCCESS = "Hi Bro"! :)
        public static string[] hx = { "1", "3", "3", "7" };
        public static string[] hlmao = { "H", "i", "d", "e", "a", "k", "i" };
        public static string[] x6 = { "x", "6", "4" };
        public static string[] x8 = { "x", "8", "6" };
        public static string[] a = { "A", "r", "c", "h", ":", " " };
        public static string[] u = { "U", "s", "e", "r", "n", "a", "m", "e", ":", " " };
        public static string[] EAA = { "A", "s", " ", "A", "d", "m", "i", "n", ":", " " };
        public static string[] dhm = { "D", "o", "n", "'", "t", " ", "h", "a", "c", "k", " ", "m", "e", "!" };
        public static string[] dm = { "W", "h", "y", " ", "a", "r", "e", " ", "Y", "o", "u", " ", "t", "r", "y", "i", "n", "g", " ", "t", "h", "e", " ", "d", "e", "f", "a", "u", "l", "t", " ", "t", "e", "x", "t", "!" };
        public static string[] v = { "V", "e", "r", "i", "f", "y", "!" };
        public static string[] ER = { "E", "x", "p", "e", "c", "t", "e", "d", " ", "r", "e", "s", "u", "l", "t", ":", " " };
        public static string[] nt = { "N", "i", "c", "e", " ", "t", "r", "y", "!" };
        public static string[] y = { "Y", "o", "u", " ", "a", "r", "e", " ", "r", "i", "g", "h", "t", " ", "i", "t", "'", "s", " ", "a", " ", "f", "a", "i", "l", "!" };
        public static string[] CSM = { "W", "e", "l", "l", " ", "d", "o", "n", "e", " ", "f", "o", "r", " ", "y", "o", "u", "r", " ", "s", "u", "c", "c", "e", "s", "s", "!" };
        public static string[] CFM = { "S", "a", "d", "l", "y", " ", "y", "o", "u", " ", "f", "a", "i", "l", "e", "d", ",", " ", "t", "r", "y", " ", "a", "g", "a", "i", "n", " ", "l", "a", "t", "e", "r", "!" };
        public static string[] CST = { "T", "r", "u", "e" };
        public static string[] CSF = { "F", "a", "l", "s", "e" };

        public UM()
        {
            MessageBox.Show("If you are lazy to click:\n- Enter = Verify.\n- ESC = Close.");
            InitializeComponent();
        }
        public void lmao()
        {
            for(; ; )
            {
                try
                {
                    this.Name = RS(15);
                    this.Text = RS(15);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Thread.Sleep(100);
            }
        }
        public static string RS(int length)
        {
            string c = "!-_\\/@#$€%^&*~'\"{}()[]^|`=+*%?<>";
            var sr = new char[8];
            var r = new Random();

            for (int i = 0; i < sr.Length; i++)
            {
                sr[i] = c[r.Next(c.Length)];
            }

            var f = new String(sr);

            return f;
        }
        private void UnpackMe_Load(object sender, EventArgs e)
        {
            this.FormClosing += UM_Close;
            CheckForIllegalCrossThreadCalls = false;
            r = false;
            string ar = Environment.Is64BitOperatingSystem ? string.Join("", x6) : string.Join("", x8);
            AL.Text = $"{string.Join("", a)}{ar}";
            UL.Text = $"{string.Join("", u)}{Environment.UserName}";
            AAL.Text = $"{string.Join("", EAA)}{new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)}";
            Ps.Text = string.Join("", hlmao);
            VBtn.Text = string.Join("", v);
            ERL.Text = $"{string.Join("", ER)}{string.Join("", s)}";
            new Thread(lmao).Start();
        }
        private void VBtn_Click(object sender, EventArgs e)
        {
            switch (Ps.Text)
            {
                case var value when value == $"{string.Join("", hx)}":
                    MessageBox.Show(string.Join("", dhm));
                    break;
                case var value when value == $"{string.Join("", hlmao)}":
                    MessageBox.Show(string.Join("", dm));
                    break;
                case var value when value == $"{string.Join("", h)}":
                    r = true;
                    MessageBox.Show(string.Join("", s));
                    break;
                case var value when value == $"{string.Join("", s)}":
                    MessageBox.Show(string.Join("", nt));
                    break;
                case var value when value == $"{string.Join("", f)}":
                    MessageBox.Show(string.Join("", y));
                    break;

                default:
                    MessageBox.Show(string.Join("", f));
                    break;
            }
        }

        private void UM_Close(Object sender, FormClosingEventArgs e)
        {
            switch (r.ToString())
            {
                case var value when value == $"{string.Join("", CST)}":
                    MessageBox.Show(string.Join("", CSM));
                    Environment.Exit(0);
                    break;
                case var value when value == $"{string.Join("", CSF)}":
                    MessageBox.Show(string.Join("", CFM));
                    Environment.Exit(-1);
                    break;
            }
        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
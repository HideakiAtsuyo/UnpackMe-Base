using System;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using UM;

namespace UnpackMe //Separated Stuff from the Form
{
    public partial class UM : Form
    {
        public static bool r = false, k = false;
        public static string[] s = { "S", "u", "c", "c", "e", "s", "s" };
        public static string[] sbn = { "S", "u", "c", "c", "e", "s", "s", ".", ".", ".", " ", "B", "u", "t", " ", "n", "o", " ", "y", "o", "u", " ", "j", "u", "s", "t", " ", "u", "s", "e", "d", " ", "t", "h", "e", " ", "e", "x", "a", "m", "p", "l", "e", " ", ":", "'", "(" };
        public static string[] f = { "F", "a", "i", "l", "e", "d" };
        public static string[] h = { "H", "i", " ", "B", "r", "o", " ", "!" }; //SUCCESS = "Hi Bro !"! :)
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
        public static string[] CSM2 = { "W", "e", "l", "l", " ", "d", "o", "n", "e", " ", "f", "o", "r", " ", "t", "h", "e", " ", "k", "e", "y", " ", "t", "o", "o", " ", "!" };
        public static string[] CFM = { "S", "a", "d", "l", "y", " ", "y", "o", "u", " ", "f", "a", "i", "l", "e", "d", ",", " ", "t", "r", "y", " ", "a", "g", "a", "i", "n", " ", "l", "a", "t", "e", "r", "!" };
        public static string[] CST = { "T", "r", "u", "e" };
        public static string[] CSF = { "F", "a", "l", "s", "e" };
        public static string[] an = { "A", "c", "c", "e", "p", "t", " ", "N", "o", " ", "?", "\n", "L", "a", "z", "y", " ", "a", "s", "s", " ", "!", " ", "x", "D" };



        public UM()
        {
            LoadLmao();
        }
        public void LoadLmao()
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
                    /* Useless If */
                    if(this.Name == this.Text || this.Name.Contains(this.Text) || this.Equals(this.Text))
                    {

                    }
                    /* Useless If */
                }
                catch (System.Collections.Generic.KeyNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } catch
                {

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
            LoadSomeThings();
            new Thread(lmao).Start();
        }
        public void LoadSomeThings()
        {
            r = false;
            string ar = Environment.Is64BitOperatingSystem ? string.Join(string.Empty, x6) : string.Join(string.Empty, x8);
            AL.Text = $"{string.Join(string.Empty, a)}{ar}";
            UL.Text = $"{string.Join(string.Empty, u)}{Environment.UserName}";
            AAL.Text = $"{string.Join(string.Empty, EAA)}{new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)}";
            Ps.Text = string.Join(string.Empty, hlmao);
            VBtn.Text = string.Join(string.Empty, v);
            ERL.Text = $"{string.Join(string.Empty, ER)}{string.Join(string.Empty, s)}";
        }
        
        private void VBtn_Click(object sender, EventArgs e)
        {
            if (!AcceptOrDie.Checked)
            {
                MessageBox.Show(string.Join(string.Empty, an) + "\nI did it for you !");
                AcceptOrDie.Checked = true;
                return;
            }
            switch (Ps.Text)
            {
                case var value when value == $"{string.Join(string.Empty, hx)}":
                    MessageBox.Show(string.Join(string.Empty, dhm));
                    break;
                case var value when value == $"{string.Join(string.Empty, hlmao)}":
                    MessageBox.Show(string.Join(string.Empty, dm));
                    break;
                case var value when value == $"{string.Join(string.Empty, h)}":
                    r = true;
                    if(PsS.Enabled != true)
                    {
                        PsS.Enabled = true;
                        MessageBox.Show(string.Join(string.Empty, s) + " you got it! Now try to get a valid key :)");
                        //Clipboard.SetText("Format: `user:pass`\n\nAkame ga Kill!:10308|10308|20616");
                        NotePad.Show("Valid Example:\n\nU: Akame ga Kill!\nK: 10308|7959|2974");
                    } else
                    {
                        MessageBox.Show("Huh you forgot the example?");
                        //Clipboard.SetText("Format: `user:pass`\n\nAkame ga Kill!:10308|10308|20616");
                        NotePad.Show("Valid Example:\n\nU: Akame ga Kill!\nK: 10308|7959|2974");
                    }

                    break;
                case var value when value == $"{string.Join(string.Empty, s)}":
                    MessageBox.Show(string.Join(string.Empty, nt));
                    break;
                case var value when value == $"{string.Join(string.Empty, f)}":
                    MessageBox.Show(string.Join(string.Empty, y));
                    break;

                default:
                    if(PsS.Enabled == true)
                    {
                        if (KeygenPart.ValidateLicense(Ps.Text, PsS.Text))
                        {
                            if (Ps.Text == "Akame ga Kill!" && PsS.Text == "10308|7959|2974")
                            {
                                MessageBox.Show(string.Join(string.Empty, sbn));
                            }
                            else
                            {
                                k = true;
                                MessageBox.Show(string.Join(string.Empty, s));
                            }
                        }
                        else
                        {
                            MessageBox.Show(string.Join(string.Empty, f));
                        }
                    } else
                    {
                        MessageBox.Show(string.Join(string.Empty, f));
                    }
                    break;
            }
        }
        
        private void UM_Close(Object sender, FormClosingEventArgs e)
        {
            switch (r.ToString())
            {
                case var value when value == $"{string.Join(string.Empty, CST)}":
                    MessageBox.Show(string.Join(string.Empty, CSM));
                    //Environment.Exit(0);
                    break;
                case var value when value == $"{string.Join(string.Empty, CSF)}":
                    MessageBox.Show(string.Join(string.Empty, CFM));
                    //Environment.Exit(-1);
                    break;
            }
            if (k)
            {
                MessageBox.Show(string.Join(string.Empty, CSM2));
            }
            Environment.Exit(0);
        }
        private void CBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Ps_TextChanged(object sender, EventArgs e)
        {
            if (r)
            {
                PsL.Text = Ps.Text.Length.ToString();
            }
            else
            {
                PsL.Text = "Waiting";
            }
        }
    }
}

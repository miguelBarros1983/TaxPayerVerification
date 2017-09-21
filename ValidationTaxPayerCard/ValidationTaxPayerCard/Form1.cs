// <summary>
// This form is used to make a verification of Tax Payr number in Portugal
// </summary>
 
namespace ValidationTaxPayerCard
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLblMiguelBarros.LinkVisited = true;
            System.Diagnostics.Process.Start($"https://www.linkedin.com/in/miguel-barros-08b4297/");
        }

        private void Button1Click(object sender, EventArgs e)
        {
            bool resultOfValidation = IsValidContrib(txtNumber.Text); ;
            if (resultOfValidation)
            {
                tbxResultColor.Text = Resource.Messages.CorrectNumber;
                tbxResultColor.BackColor = Color.LightGreen;
            }
            else
            {
                tbxResultColor.Text = Resource.Messages.IncorrectNumber;
                tbxResultColor.BackColor = Color.Red;
            }
        }

        public bool IsValidContrib(string Contrib)
        {
            bool functionReturnValue = false;
            string[] s = new string[9];

            s[0] = Convert.ToString(Contrib[0]);
            s[1] = Convert.ToString(Contrib[1]);
            s[2] = Convert.ToString(Contrib[2]);
            s[3] = Convert.ToString(Contrib[3]);
            s[4] = Convert.ToString(Contrib[4]);
            s[5] = Convert.ToString(Contrib[5]);
            s[6] = Convert.ToString(Contrib[6]);
            s[7] = Convert.ToString(Contrib[7]);
            s[8] = Convert.ToString(Contrib[8]);

            if (Contrib.Length == 9)
            {
                string c = s[0];

                if (c == null)
                {
                    throw new ArgumentNullException(nameof(Contrib));
                }

                if (s[0] == "1" || s[0] == "2" || s[0] == "5" || s[0] == "6" || s[0] == "9")
                {
                    long checkDigit = Convert.ToInt32(c) * 9;
                    int i;
                    for (i = 2; i <= 8; i++)
                    {
                        checkDigit = checkDigit + (Convert.ToInt32(s[i - 1]) * (10 - i));
                    }
                    checkDigit = 11 - (checkDigit % 11);
                    if ((checkDigit >= 10))
                        checkDigit = 0;
                    if ((checkDigit == Convert.ToInt32(s[8])))
                        functionReturnValue = true;
                }
            }
            return functionReturnValue;
        }
    }
}

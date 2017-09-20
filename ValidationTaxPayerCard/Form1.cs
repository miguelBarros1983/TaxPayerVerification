using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidationTaxPayerCard
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLblMiguelBarros.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/miguel-barros-08b4297/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool resultOfValidation = IsValidContrib(txtNumber.Text.ToString()); ;
            if (resultOfValidation)
            {
                tbxResultColor.Text = "CORRECT";
                tbxResultColor.BackColor = Color.LightGreen;
            }
            else
            {
                tbxResultColor.Text = "INCORRECT";
                tbxResultColor.BackColor = Color.Red;
            }
        }

        public bool IsValidContrib(string Contrib)
        {
            bool functionReturnValue = false;
            string[] s = new string[9];
            string Ss = null;
            string C = null;
            int i = 0;
            long checkDigit = 0;

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
                C = s[0];
                if (s[0] == "1" || s[0] == "2" || s[0] == "5" || s[0] == "6" || s[0] == "9")
                {
                    checkDigit = Convert.ToInt32(C) * 9;
                    for (i = 2; i <= 8; i++)
                    {
                        checkDigit = checkDigit + (Convert.ToInt32(s[i - 1]) * (10 - i));
                    }
                    checkDigit = 11 - (checkDigit % 11);
                    if ((checkDigit >= 10))
                        checkDigit = 0;
                    Ss = s[0] + s[1] + s[2] + s[3] + s[4] + s[5] + s[6] + s[7] + s[8];
                    if ((checkDigit == Convert.ToInt32(s[8])))
                        functionReturnValue = true;
                }
            }
            return functionReturnValue;
        }
    }
}

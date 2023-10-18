using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formhafta3V
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int s1, s2, toplam1, toplam2;
        int sayac = 1;
        private void b1_Click(object sender, EventArgs e)
        {
            Random zar = new Random();
            s1 = zar.Next(1, 7);
            s2 = zar.Next(1, 7);
            l3.Text = "= " + s1;
            l4.Text = "= " + s2;
            if (sayac % 2 == 1)
            {

                toplam1 = s1 + s2;
                MessageBox.Show("birinci = " + toplam1, "Sayıların Toplamı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sayac++;
            }
            else
            {
                toplam2 = s1 + s2;
                MessageBox.Show("ikinici =" + toplam2, "Sayıların Toplamı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (toplam1 > toplam2)
                {
                    MessageBox.Show("butona birinci basan oyuna başlayacak.", "W İ N", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    b1.Enabled = false;
                    b2.Enabled = true;
                }
                else if (toplam1 < toplam2)
                {
                    MessageBox.Show("butona ikinci basan oyuna başlayacak.", "W İ N", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    b1.Enabled = false;
                    b2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Sayıların toplamı eşit. Lütfen tekrar deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sayac++;
                }
            }

        }

        private void b2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            b2.Enabled = false;
        }
    }
}

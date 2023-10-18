namespace formhafta3V
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s1, s2, toplam;
        int sayac = 1;
        //týklama kontrolunu saðlamak için sayaç kullanýldý.
        private void b1_Click(object sender, EventArgs e)
        {
            Random zar = new Random();
            //rastgele sayý üretimi için random kullanýldý.
            s1 = zar.Next(1, 7);
            s2 = zar.Next(1, 7);
            l3.Text = "=" + s1;
            l4.Text = "=" + s2;
            toplam = s1 + s2;
            if (sayac % 2 == 1)
            {//sayac:týklama tek mi çift mi bakmak için 2 mod aldýk.
                if (pbar1.Value + toplam >= pbar1.Maximum)
                {//>=: 100 e gelen oyunu kazanacaðý için kullandýk.
                    pbar1.Value = pbar1.Maximum;
                    l7.Text = "=" + pbar1.Value;
                    MessageBox.Show("OYUNCU 1 oyunu kazandý. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    l7.Text = "=" + " ";
                    l8.Text = "=" + " ";
                    l3.Text = "=" + " ";
                    l4.Text = "=" + " ";
                    pbar1.Value = 0;
                    pbar2.Value = 0;
                }
                else
                {
                    pbar1.Value += toplam;
                    l7.Text = "=" + pbar1.Value;
                    sayac++;
                }
            }
            else
            {
                if (pbar2.Value + toplam >= pbar2.Maximum)
                {
                    pbar2.Value = pbar2.Maximum;
                    l8.Text = "=" + pbar2.Value;
                    MessageBox.Show("OYUNCU 2 oyunu kazandý. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    l7.Text = "=" + " ";
                    l8.Text = "=" + " ";
                    l3.Text = "=" + " ";
                    l4.Text = "=" + " ";
                    pbar1.Value = 0;
                    pbar2.Value = 0;
                }
                else
                {
                    pbar2.Value += toplam;
                    l8.Text = "=" + pbar2.Value;
                    sayac++;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 start = new Form2();
            start.Text = "START";
            start.Size = new Size(590, 325);
            start.ShowDialog();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
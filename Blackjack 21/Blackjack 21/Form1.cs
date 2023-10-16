using System.Security.Cryptography;

namespace Blackjack_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;


            if (sayac == 1)
            {
                int a1, a2, toplam;
                a1 = rastgele.Next(1, 11);
                a2 = rastgele.Next(1, 11);
                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                toplam = a1 + a2;
                label10.Text = toplam.ToString();
            }
            if (sayac == 2)
            {
                int toplam;
                int a3 = rastgele.Next(1, 11);
                label3.Text = a3.ToString();
                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + a3;
                label10.Text = toplam.ToString();
            }
            if (sayac == 3)
            {
                int toplam;
                int a4 = rastgele.Next(1, 11);
                label4.Text = a4.ToString();
                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + a4;
                label10.Text = toplam.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int b1, b2, b3, b4, toplam;

            b1 = rastgele.Next(1, 11);
            b2 = rastgele.Next(1, 11);
            toplam = b1 + b2;
            label5.Text = b1.ToString();
            label6.Text = b2.ToString();

            label12.Text = toplam.ToString();

            if (toplam < 16)

            {
                b3 = rastgele.Next(1, 11);
                label7.Text = b3.ToString();
                toplam = toplam + b3;
                label12.Text = toplam.ToString();
            }
            if (toplam < 16)

            {
                b4 = rastgele.Next(1, 11);
                label8.Text = b4.ToString();
                toplam = toplam + b4;
                label12.Text = toplam.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button3.Enabled = false;
            int oyuncuskor = 0, bilgisayarskor = 0;
            int oyuncutoplam, bilgisayartoplam;
            oyuncutoplam = Convert.ToInt32(label10.Text);
            bilgisayartoplam = Convert.ToInt32(label12.Text);
            if (oyuncutoplam > bilgisayartoplam && oyuncutoplam <= 21)
            {
                oyuncuskor = oyuncuskor + 10;
                label20.Text = oyuncuskor.ToString();
            }
            if (bilgisayartoplam > oyuncutoplam && bilgisayartoplam <= 21)
            {
                bilgisayarskor = bilgisayarskor + 10;
                label21.Text = bilgisayarskor.ToString();
            }
            if (oyuncutoplam == bilgisayartoplam && oyuncutoplam <= 21)
            {
                oyuncuskor = oyuncuskor + 10;
                bilgisayarskor = bilgisayarskor + 10;
                label20.Text = oyuncuskor.ToString();
                label21.Text = bilgisayarskor.ToString();

            }
            if (bilgisayartoplam > 21 && oyuncutoplam > 21)
            {
                MessageBox.Show("Deðerler büyük berabere!!!");
            }
            if (oyuncuskor == 50)
            {
                MessageBox.Show("Tebrikler kazandýnýz");


            }
            if (bilgisayarskor == 50)
            {
                MessageBox.Show("Maalesef kaybettiniz");
            }
            if (oyuncutoplam <= 21 && bilgisayartoplam > oyuncutoplam)
            {
                oyuncuskor = oyuncuskor + 10;
                label21.Text = oyuncuskor.ToString();
            }
            if (bilgisayartoplam <= 21 && oyuncutoplam > bilgisayartoplam)
            {
                bilgisayarskor = bilgisayarskor + 10;
                label21.Text = bilgisayarskor.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button4.Enabled = false;
            sayac = 0;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label10.Text = "0";
            label12.Text = "0";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            sayac = 0;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label10.Text = "0";
            label12.Text = "0";
            label20.Text = "0";
            label21.Text = "0";

        }
    }
}

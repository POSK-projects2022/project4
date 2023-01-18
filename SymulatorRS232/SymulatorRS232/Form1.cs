namespace SymulatorRS232
{
    public partial class Nadajnik : Form
    {
        public Nadajnik()
        {
            InitializeComponent();
            odbiornik = new Odbiornik();
            odbiornik.Show();
        }

        private void konwertuj_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            string text = this.textBox1.Text;
            int iter = 0;
            bool[][] textBin = new bool[text.Length][];
            foreach (char znak in text)
            {
                int kod = (int)znak;
                textBin[iter] = spakujZnakBin(znakToBin(kod));
                iter++;
            }
            iter = 0;

            odbiornik.odbTextBin = textBin;
            this.textBox2.Text += boolToText(textBin);
        }

        private bool[] znakToBin(int kod)
        {
            bool[] bin = new bool[16];
            for (int i = 15; i >= 0; i--)
            {
                if (kod % 2 == 1) bin[i] = true;
                else bin[i] = false;

                kod /= 2;
            }

            return bin;
        }

        private bool[] spakujZnakBin(bool[] bin)
        {
            bool[] buff = new bool[bin.Length];
            bool[] znakSlowo = new bool[11];
            

            for (int i = 0; i < bin.Length; i++)
            {
                buff[i] = bin[bin.Length - 1 - i];
            }

            znakSlowo[0] = false;
            for (int i = 0; i < 8; i++)
            {
                znakSlowo[i + 1] = buff[i];
            }
            znakSlowo[9] = true;
            znakSlowo[10] = true;


            return znakSlowo;
        }

        private string boolToText(bool[][] textBin)
        {
            string buff = "";
            foreach (bool[] bin in textBin)
            {
                for (int i = 0; i < bin.Length; i++)
                {
                    if (bin[i]) buff += "1";
                    else buff += "0";
                }
                buff += " ";
            }

            return buff;
        }

        private void wyslij_Click(object sender, EventArgs e)
        {
            odbiornik.textBox2.Text = this.textBox2.Text;
        }
    }
}
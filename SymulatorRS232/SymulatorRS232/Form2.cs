using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymulatorRS232
{
    public partial class Odbiornik : Form
    {
        public Odbiornik()
        {
            InitializeComponent();
        }

        private void konwertuj_Click(object sender, EventArgs e)
        {
           

            string resText = "";

            foreach (bool[] bin in odbTextBin)
            {
                resText += binToZnak(bin);
            }
            
            if (this.label1.Text != "")
            {
                try
                {
                    string buffResText = resText.ToLower();
                    StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                    string word = streamReader.ReadLine();
                    StringBuilder sb = new StringBuilder(resText);


                    while (word != null)
                    {
                        
                        while (buffResText.Contains(word.ToLower()))
                        {
                            
                            
                            for (int i = buffResText.IndexOf(word.ToLower()); i < buffResText.IndexOf(word.ToLower()) + word.Length; i++)
                            {
                                    sb[i] = '*';
                            }
                            streamReader = new StreamReader(openFileDialog1.FileName);
                            buffResText = sb.ToString();
                            buffResText = buffResText.ToLower();  
                        }
                        word = streamReader.ReadLine();
                    }
                    resText = sb.ToString();
                }
                catch
                {

                }
            }



            this.textBox1.Text = resText;
            
        }
        private static char binToZnak(bool[] slowoBinarne)
        {
            bool[] bajt = new bool[8];
            bajt = rozpakuj(slowoBinarne);
            int kodASCIIZnaku = binToDec(odwroc(bajt));
            char znak = (char)kodASCIIZnaku;
            return znak;
        }

        private static bool[] rozpakuj(bool[] slowo)
        {
            bool[] bajt = new bool[8];
            for (int i = 0; i < 8; i++)
            {
                bajt[i] = slowo[i + 1];
            }
            return bajt;
        }

        private static bool[] odwroc(bool[] tablica)
        {
            bool[] buff = new bool[tablica.Length];
            for (int i = 0; i < tablica.Length; i++)
            {
                buff[i] = tablica[tablica.Length - 1 - i];
            }
            return buff;
        }

        private static int binToDec(bool[] bin)
        {
            int dec = 0;
            int n = 1;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (bin[i])
                {
                    dec += n;
                }
                n *= 2;
            }
            return dec;
        }

        private void wybierzPlik_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {   
                label1.Text = openFileDialog1.FileName;
            }
        }
    }
}

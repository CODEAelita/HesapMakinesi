using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekrantemizlenecekmi;
        private int _ilksayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRakamBir_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                labelEkran.Text = "";
                (_ekrantemizlenecekmi) = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "1 ";
        }

        private void buttonRakamİki_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                labelEkran.Text = "";
                (_ekrantemizlenecekmi) = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "2 ";
        }

        private void buttonRakamÜç_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                labelEkran.Text = "";
                (_ekrantemizlenecekmi) = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "3 ";
        }

        private void buttonRakamDört_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                labelEkran.Text = "";
                (_ekrantemizlenecekmi) = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "4 ";
        }

        private void buttonRakamBeş_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                labelEkran.Text = "";
                (_ekrantemizlenecekmi) = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "5 ";
        }

        private void buttonRakamAltı_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                labelEkran.Text = "";
                (_ekrantemizlenecekmi) = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "6 ";
        }

        private void buttonRakamYedi_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                labelEkran.Text = "";
                (_ekrantemizlenecekmi) = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "7 ";
        }

        private void buttonRakamSekiz_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                labelEkran.Text = "";
                (_ekrantemizlenecekmi) = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "8 ";
        }

        private void buttonRakamDokuz_Click(object sender, EventArgs e)
        {
            if(_ekrantemizlenecekmi)
            {
                labelEkran.Text = "";
                (_ekrantemizlenecekmi) = false;
            }
            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "9 ";
        }

        private void buttonRakamSıfır_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                labelEkran.Text = "";
                (_ekrantemizlenecekmi) = false;
            }

            if (labelEkran.Text == "0") labelEkran.Text = "";
            labelEkran.Text += "0 ";
        }

        private void buttonToplama_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(labelEkran.Text);
        }

        private void buttonEşittir_Click(object sender, EventArgs e)
        {
            int İkinciSayi = Convert.ToInt32(labelEkran.Text);
            int sonuc;
            switch(_islem)
            {
                case '+':
                    sonuc = _ilksayi + İkinciSayi;
                    break;

                case '-':
                    sonuc = _ilksayi - İkinciSayi;
                    break;

                case '*':
                    sonuc = _ilksayi * İkinciSayi;
                    break;

                case '/':
                    sonuc = _ilksayi / İkinciSayi;
                    break;

                default:
                    sonuc = 0;
                        break;
            }
            labelEkran.Text = Convert.ToString(sonuc);
        }

        private void buttonÇıkarma_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(labelEkran.Text);
        }

        private void buttonÇarpma_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(labelEkran.Text);
        }

        private void buttonBölme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(labelEkran.Text);
        }

        private void buttonSilmeTuşu_Click(object sender, EventArgs e)
        {
            labelEkran.Text = "0";
        }
    }
}

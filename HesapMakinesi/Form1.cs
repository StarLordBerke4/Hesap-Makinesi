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
        public Form1()
        {
            InitializeComponent();
        }

        private void birbtn_Click(object sender, EventArgs e)
        {
            if (göstertxt.Text == "0")
            {
                göstertxt.Text = "1";
            }
            else
            {
                göstertxt.Text += 1;
            }
        }

        private void ikibtn_Click(object sender, EventArgs e)
        {
            if (göstertxt.Text == "0")
            {
                göstertxt.Text = "2";
            }
            else
            {
                göstertxt.Text += 2;
            }
        }

        private void üçbtn_Click(object sender, EventArgs e)
        {
            if (göstertxt.Text == "0")
            {
                göstertxt.Text = "3";
            }
            else
            {
                göstertxt.Text += 3;
            }
        }

        private void dörtbtn_Click(object sender, EventArgs e)
        {
            if (göstertxt.Text == "0")
            {
                göstertxt.Text = "4";
            }
            else
            {
                göstertxt.Text += 4;
            }
        }

        private void beşbtn_Click(object sender, EventArgs e)
        {
            if (göstertxt.Text == "0")
            {
                göstertxt.Text = "5";
            }
            else
            {
                göstertxt.Text += 5;
            }
        }

        private void altıbtn_Click(object sender, EventArgs e)
        {
            if (göstertxt.Text == "0")
            {
                göstertxt.Text = "6";
            }
            else
            {
                göstertxt.Text += 6;
            }
        }

        private void yedibtn_Click(object sender, EventArgs e)
        {
            if (göstertxt.Text == "0")
            {
                göstertxt.Text = "7";
            }
            else
            {
                göstertxt.Text += 7;
            }
        }

        private void sekizbtn_Click(object sender, EventArgs e)
        {
            if (göstertxt.Text == "0")
            {
                göstertxt.Text = "8";
            }
            else
            {
                göstertxt.Text += 8;
            }
        }

        private void dokuzbtn_Click(object sender, EventArgs e)
        {
            if (göstertxt.Text == "0")
            {
                göstertxt.Text = "9";
            }
            else
            {
                göstertxt.Text += 9;
            }
        }

        private void sıfırbtn_Click(object sender, EventArgs e)
        {
            if (göstertxt.Text == "0")
            {
                göstertxt.Text = "0";
            }
            else
            {
                göstertxt.Text += 0;
            }
        }

        private void noktabtn_Click(object sender, EventArgs e)
        {
            if (göstertxt.Text == "0")
            {
                göstertxt.Text = ".";
            }
            else
            {
                göstertxt.Text += ".";
            }
        }

        string işlem;

        double ilk, ikinci;

        private void button1_Click(object sender, EventArgs e)
        {
            ilk = Convert.ToDouble(göstertxt.Text);
            işlem = "+";

            alttxt.Text = göstertxt.Text + "+";
            göstertxt.Text = "0";
        }

        private void çıkarbtn_Click(object sender, EventArgs e)
        {
            ilk = Convert.ToDouble(göstertxt.Text);
            işlem = "-";

            alttxt.Text = göstertxt.Text + "-";
            göstertxt.Text = "0";
        }

        private void bölmebtn_Click(object sender, EventArgs e)
        {
            ilk = Convert.ToDouble(göstertxt.Text);
            işlem = "/";

            alttxt.Text = göstertxt.Text + "/";
            göstertxt.Text = "0";
        }

        private void gerisilbtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble (göstertxt.Text) > 0)
            {
                göstertxt.Text = göstertxt.Text.Remove(göstertxt.Text.Length - 1, 1);
            }
            if (göstertxt.Text.Length == 0)
            {
                göstertxt.Text = "0";
            }
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            göstertxt.Text = "0";
            alttxt.Text = "";
        }

        double sonuç;
        private void eşittirbtn_Click(object sender, EventArgs e)
        {
            ikinci = Convert.ToDouble(göstertxt.Text);

            if (işlem == "+")
            {
                alttxt.Text += göstertxt.Text;
                sonuç = ilk + ikinci;
                göstertxt.Text = sonuç.ToString();
            }
            if (işlem == "-")
            {
                alttxt.Text += göstertxt.Text;
                sonuç = ilk - ikinci;
                göstertxt.Text = sonuç.ToString();
            }
            if (işlem == "*")
            {
                alttxt.Text += göstertxt.Text;
                sonuç = ilk * ikinci;
                göstertxt.Text = sonuç.ToString();
            }
            if (işlem == "/")
            {
                alttxt.Text += göstertxt.Text;
                sonuç = ilk / ikinci;
                göstertxt.Text = sonuç.ToString();
            }
            if (işlem == "yüzde")
            {
                alttxt.Text += göstertxt.Text;
                sonuç = ilk * ikinci / 100;
                göstertxt.Text = sonuç.ToString();
            }

            temizlebtn.Visible = true;
            richTextBox1.AppendText("\n\t " + alttxt.Text + " = " + göstertxt.Text + "\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ilk = Convert.ToDouble(göstertxt.Text);
            işlem = "yüzde";
            alttxt.Text += göstertxt.Text + "%";
            göstertxt.Text = "0";
        }

        private void xkarebtn_Click(object sender, EventArgs e)
        {
            ikinci = Convert.ToDouble(göstertxt.Text);
            alttxt.Text = göstertxt.Text + "x²";

            ikinci = Math.Pow(ikinci, 2);
            göstertxt.Text = ikinci.ToString();
        }

        private void kökbtn_Click(object sender, EventArgs e)
        {
            ikinci = Convert.ToDouble(göstertxt.Text);
            alttxt.Text = göstertxt.Text + "√";

            ikinci = Math.Sqrt(ikinci);
            göstertxt.Text = ikinci.ToString();
        }

        private void birbölüxbtn_Click(object sender, EventArgs e)
        {
            ikinci = Convert.ToDouble(göstertxt.Text);
            alttxt.Text = göstertxt.Text + "1/x";

            
            göstertxt.Text = ikinci.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            richTextBox1.ScrollBars = 0;
            temizlebtn.Visible = false;
        }

        private void çarpmabtn_Click(object sender, EventArgs e)
        {
            ilk = Convert.ToDouble(göstertxt.Text);
            işlem = "*";

            alttxt.Text = göstertxt.Text + "*";
            göstertxt.Text = "0";
        }
    }
}

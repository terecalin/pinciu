using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace education
{
    public partial class Form1 : Form
    {
        Int64 i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlFormare.Visible = false;
            pnlRomania.Visible = false;
            pnlFf.Visible = false;
            pnlTest.Visible = false;
        }

        private void btnFormare_Click(object sender, EventArgs e)
        {
            pnlFormare.Visible = true;
            pnlFormare.Size =new Size(769, 552);
            pnlFormare.Location = new Point(0, 0);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            i = i + 1;
            if (i % 2 == 1)
            {
                lblAn1945.Visible = false;
                lbl1945.Visible = false;
                lblAn1960.Visible = false;
                lbl1960.Visible = false;
                btnHide.Text = "Arata Textul";
            }
            else
            {
                lblAn1945.Visible = true;
                lbl1945.Visible = true;
                lblAn1960.Visible = true;
                lbl1960.Visible = true;
                btnHide.Text = "Ascunde Textul";
            }
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            pnlFormare.Visible = false;
        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            pnlRomania.Visible = false;
        }

        private void btnRomania_Click(object sender, EventArgs e)
        {
            pnlRomania.Visible = true;
            pnlRomania.Size = new Size(769, 552);
            pnlRomania.Location = new Point(0, 0);
        }

        private void btnFf_Click(object sender, EventArgs e)
        {
            pnlFf.Visible = true;
            pnlFf.Size = new Size(770, 552);
            pnlFf.Location = new Point(0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlFf.Visible = false;
        }

        private void btnIntr1_Click(object sender, EventArgs e)
        {
            if (rbtn1.Checked == true)
            {
                MessageBox.Show("Raspuns gresit, mai incearca!");
                    return;
            }
            if (rbtn2.Checked == true)
            {
                MessageBox.Show("Bravo, ai raspuns corect!");
                return;
            }
            if(rbtn3.Checked == true)
            {
                MessageBox.Show("Raspuns gresit, mai incearca!");
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlTest.Size = new Size(770, 552);
            pnlTest.Location = new Point(0, 0);
            pnlTest.Visible = true;
        }

        private void btnIntr2_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true && checkBox3.Checked == true)
            {
                MessageBox.Show("Bravo, ai raspuns corect!");
            }
            if(checkBox1.Checked == true && checkBox3.Checked == false)
            {
                MessageBox.Show("Una dintre variante este corecta, mai incearca!");
            }
            if (checkBox1.Checked == false && checkBox3.Checked == true)
            {
                MessageBox.Show("Una dintre variante este corecta, mai incearca!");
            }
            if(checkBox1.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("Ambele variante sunt gresite, mai incearca!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtRaspuns.Text == "1950")
            {
                MessageBox.Show("Bravo, ai raspuns corect!");
            }
            else
            {
                MessageBox.Show("Raspunsul este gresit, mai incearca!");
            }
        }

        private void btnHome3_Click(object sender, EventArgs e)
        {
            pnlTest.Visible = false;
        }
    }
}

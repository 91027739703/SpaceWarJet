using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jangfazaee
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        bool Townumber = false;
        int PLAYER = 0;
        int GOLOLE = 0;
        int PLAYER2 = 0;
        int GOLOLE2 = 0;
        int nobat = 0;
        int nobat2 = 0;
        string speed;

        private void plane1_Click(object sender, EventArgs e)
        {
            if (nobat % 2 == 0)
            {
                nobat++;
                label2.Text = "Choose your desired plane :(enemi)";
                PLAYER = 1;
            }
            else if (nobat % 2 == 1)
            {
                nobat++;
                label2.Text = "Choose your desired plane :(player)";
                PLAYER2 = 1;
            }
        }

        private void plane2_Click(object sender, EventArgs e)
        {
            if (nobat % 2 == 0)
            {
                nobat++;
                label2.Text = "Choose your desired plane :(enemi)";
                PLAYER = 2;
            }
            else if (nobat % 2 == 1)
            {
                nobat++;
                label2.Text = "Choose your desired plane :(player)";
                PLAYER2 = 2;
            }
        }

        private void plane3_Click(object sender, EventArgs e)
        {
            if (nobat % 2 == 0)
            {
                nobat++;
                label2.Text = "Choose your desired plane :(enemi)";
                PLAYER = 3;
            }
            else if (nobat % 2 == 1)
            {
                nobat++;
                label2.Text = "Choose your desired plane :(player)";
                PLAYER2 = 3;
            }
        }

        private void bullet1_Click(object sender, EventArgs e)
        {
            if (nobat2 % 2 == 0)
            {
                nobat2++;
                label3.Text = "Choose the bullet you want :(enemi)";
                GOLOLE = 1;
            }
            else if (nobat2 % 2 == 1)
            {
                nobat2++;
                label3.Text = "Choose the bullet you want :(player)";
                GOLOLE2 = 1;
            }
        }

        private void bullet2_Click(object sender, EventArgs e)
        {
            if (nobat2 % 2 == 0)
            {
                nobat2++;
                label3.Text = "Choose the bullet you want :(enemi)";
                GOLOLE = 2;
            }
            else if (nobat2 % 2 == 1)
            {
                nobat2++;
                label3.Text = "Choose the bullet you want :(player)";
                GOLOLE2 = 2;
            }
        }

        private void bullet3_Click(object sender, EventArgs e)
        {
            if (nobat2 % 2 == 0)
            {
                nobat2++;
                label3.Text = "Choose the bullet you want :(enemi)";
                GOLOLE = 3;
            }
            else if (nobat2 % 2 == 1)
            {
                nobat2++;
                label3.Text = "Choose the bullet you want :(player)";
                GOLOLE2 = 3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Townumber == true)
            {
                new Form3(GOLOLE, PLAYER, PLAYER2, GOLOLE2).ShowDialog();
                this.Close();
            }
            else
            {
                new seve(PLAYER, GOLOLE, PLAYER2, GOLOLE2,speed).ShowDialog();
                this.Close();
            }
        }

        private void twoumber_Click(object sender, EventArgs e)
        {
            Townumber = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speed = "e";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            speed = "m";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            speed = "i";
        }
    }
}

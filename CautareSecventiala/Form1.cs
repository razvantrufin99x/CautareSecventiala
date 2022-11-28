using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CautareSecventiala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            Random rnd;


        private void button1_Click(object sender, EventArgs e)
        {
            rnd = new Random(200);
            for(int i = 0 ; i< 100; i++)
            {
                this.listBox1.Items.Add(rnd.Next(200).ToString());
                this.listBox1.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Cautare Secventiala de la 0 la n-1
            //nu se opreste dupa gasire ci cauta in continuare urmataorele aparitii

            for (int i = 0; i < this.listBox1.Items.Count; i++)
            {
                listBox1.SelectedIndex = i;

                if (this.listBox1.Text == this.textBox1.Text)
                {
                    MessageBox.Show(" exista ");
                }
                else { 
                    if(i>=this.listBox1.Items.Count)
                    {
                        MessageBox.Show(" nu exista ");
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

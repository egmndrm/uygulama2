using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int sayi;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int yas = Convert.ToInt32(textBox1.Text);
                if (yas > 18)
                {
                    label2.Text = "Askere gidebilir";

                }
                else
                {
                    label2.Text = "Askere Gidemez";
                }
                    
            }
            catch { 
                MessageBox.Show("Hatali bir yas  girdiniz" , "Hata" , MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox2.Text);
            int s2 = Convert.ToInt32(textBox3.Text);
            if (s1 > s2)
            {
                label5.Text = "1. sayi buyuk";

            }
            else if (s1 < s2)
            {
                label5.Text = "2. sayi buyuk";

            }
            else {

                label5.Text = "Sayilar esit";



            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tekcift = Convert.ToInt32(textBox4.Text);
            if (tekcift%2==0)
            {
                label6.Text = " Sayi cifttir";
            }
            else
            {
                label6.Text = "Sayi Tektir";
            }
            
        }
    }
}

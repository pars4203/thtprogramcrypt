using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SoftwareCryptt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Registry.Users.SetValue("Anahtar", textBox1.Text);
                MessageBox.Show("Kısayol başarıyla eklendi!", "SoftwareCrypt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Width = 323;
                this.Height = 282;

            }

            catch
            {
                MessageBox.Show("Kısayol eklenemedi! Lütfen Software Crypt'ı Yönetici olarak çalıştırın.", "SofwareCrypt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
              
               
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                label3.Text = Registry.Users.GetValue("Anahtar").ToString();

            }
            catch
            {
                MessageBox.Show("Önceden yazılmış bir kısayol bulunamadı. Lütfen kısayol ekleyiniz!", "SoftwareCrypt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = Registry.Users.GetValue("Anahtar").ToString();
            if(textBox2.Text == "1TurkHackTeam1")
            {
               
                    System.Diagnostics.Process.Start(@label3.Text);
               
              
            }
            else
            {
                MessageBox.Show("Şifre yanlış.", "SoftwareCrypt", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Width = 636;
            this.Height = 282;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.Users.DeleteValue("Anahtar");
                MessageBox.Show("Kayıt silindi. Yeni kayıt ekleyiniz.", "SoftwareCrypt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Kayıt silinemedi. Yönetici olarak çalıştırdığınızdan emin olunuz.", "SoftwareCrypt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fikir babası: THTKingKong - Esat, Derleyen: pars4203 - Yavuz", "SoftwareCrypt", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

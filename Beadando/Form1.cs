using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando
{
    public partial class Form1 : Form
    {

        public string ido;

        public Form1()
        {
            InitializeComponent();
        }

      


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            int b = int.Parse(textBox2.Text);
            bool l = checkBox1.Checked ? true : false;
            listBox1.Items.Add(new Pekaru(a,b,l));
            
         }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string [] ws =listBox1.SelectedItem.ToString().Split('(');
            textBox1.Text = ws[0];
            string[] ws2 = ws[1].Split(':');
            string[] ws3 = ws2[1].Split('F');
            string[] ws4 = ws3[1].Split('/');
            textBox2.Text = ws3[0];
            

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ido = DateTime.Now.ToString("yyyy.MM.dd");
            DateTime wasd = (Convert.ToDateTime(ido));            
            listBox2.Items.Add(textBox3.Text+"-"+ido);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add(listBox2.SelectedItem.ToString());
            label1.Text = textBox3.Text+"\nAlapitva:"+ido+"";
            string[] ws = listBox1.SelectedItem.ToString().Split('(');
            textBox1.Text = ws[0];
            string[] ws2 = ws[1].Split(':');
            string[] ws3 = ws2[1].Split('/');
            textBox2.Text = ws3[0];
            if (listBox1.SelectedItem != null && listBox2.SelectedItem != null)
            {
                listBox3.Items.Add(ws[0] + " (" + ws3[0]+"Ft/db)");
            }
            else {
                MessageBox.Show("Kérem jelöljön ki mind 2 listából!");
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}

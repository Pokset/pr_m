using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pr_m
{
    public partial class Form_register : Form
    {
        public Form_register()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            using (StreamWriter zapis = new StreamWriter("users.txt", true))
            {
                zapis.WriteLine(textBox5.Text + ";" + tb_.Text + ";" +"0"+";"+"0");
                zapis.Close();
            }
            MessageBox.Show("Готово!");
            form_user fu = new form_user();
            fu.Show();
            this.Hide();
        }

        private void Form_register_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                tb_.PasswordChar = '\0';
            }
            else
            {
                tb_.PasswordChar = '*';
            }
        }
    }
}

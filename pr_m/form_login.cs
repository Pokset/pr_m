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
    public partial class form_login : Form
    {
        StreamReader rea = null;
        List<Client> listClints = new List<Client>(); // лист для записи элементов из файла
        string path = "users.txt";
        static public int select_user;
        class Client
        {
            public string login;
            public string password;
            public string personal_diskaunt;
            public string allbyprice;

            public Client(string login, string password, string personal_diskaunt, string allbyprice)
            {
                this.password = password;
                this.login = login;
                this.personal_diskaunt = personal_diskaunt;
                this.allbyprice = allbyprice;
            }
        }
        public form_login()
        {
            InitializeComponent();
        }

        private void form_login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tb_pasword.PasswordChar = '\0';
            }
            else
            {
                tb_pasword.PasswordChar = '*';
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            // функция считывания данных из файла, их сплитовка, запись отдельных элементов в массив mas
            rea = new StreamReader("users.txt");
            
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            string[] mas = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                mas = lines[i].Split(';');
                Client client = new Client(mas[0], mas[1], mas[2], mas[3]);
                listClints.Add(client);
            }
            rea.Close();
            for (int i = 0; i <lines.Length; i++)
            {
                if(tb_login.Text == listClints[i].login && tb_pasword.Text == listClints[i].password)
                {
                    form_base.flag = true;
                    select_user = i;
                    MessageBox.Show("Готово!");
                    form_user fu = new form_user();
                    fu.Show();
                    this.Hide();
                }
            }
        }
    }
}

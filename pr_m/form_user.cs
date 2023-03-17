using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pr_m
{
    public partial class form_user : Form
    {
        StreamReader rea = null;
        List<Client> listClints = new List<Client>(); // лист для записи элементов из файла
        string path = "users.txt";
        static public double discount;
        static public double AS;
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
        public form_user()
        {
            InitializeComponent();
            rea = new StreamReader("users.txt");

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            string[] mas = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                mas = lines[i].Split(';');
                Client client = new Client(mas[0], mas[1], mas[2], mas[3]);
                listClints.Add(client);
            }
            
            discount  = Convert.ToDouble( listClints[form_login.select_user].personal_diskaunt);
            AS = Convert.ToDouble( listClints[form_login.select_user].allbyprice);
            label1.Text = listClints[form_login.select_user].login;
            tb_discount.Text = listClints[form_login.select_user].personal_diskaunt;
            tb_amount_spent.Text = listClints[form_login.select_user].allbyprice;
            rea.Close();
            string[] arrLine = File.ReadAllLines("users.txt");
            arrLine[form_login.select_user] = "23";
            File.WriteAllLines("users.txt", arrLine);
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            form_base.flag = false;
            this.Dispose();
        }

        private void form_user_Load(object sender, EventArgs e)
        {

        }
    }
}

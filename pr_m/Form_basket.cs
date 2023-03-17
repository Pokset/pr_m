using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace pr_m
{
    public partial class Form_basket : Form
    {
        StreamReader rea = null;
        public List<cpu_info> listClints = new List<cpu_info>(); // лист для записи элементов из файла
        string path = "basket.txt";
        public int all_price = 0;
        static public double personal_discount;
        static public double amount_spent;
        public class cpu_info
        {
            public string Name; // Name
            public string Price; // цена

            public cpu_info(string name, string price)
            {
                this.Name = name;
                this.Price = price;

            }
        }
        public Form_basket()
        {
            personal_discount = form_user.discount;
            amount_spent = form_user.AS;
            // функция считывания данных из файла, их сплитовка, запись отдельных элементов в массив mas
            rea = new StreamReader("basket.txt");
            InitializeComponent();
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            string[] mas = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                mas = lines[i].Split(';');
                cpu_info Cpu_Info = new cpu_info(mas[0], mas[1]);
                listClints.Add(Cpu_Info);
            }
            rea.Close();
            for(int i = 0; i < lines.Length; i++ )
            {
                listBox1.Items.Add(listClints[i].Name);
                all_price = all_price + Convert.ToInt32(listClints[i].Price);
            }

            textBox4.Text = Convert.ToString(all_price);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                string q1 = Convert.ToString(listBox1.SelectedItem);
                string q2 = Convert.ToString(listClints[listBox1.SelectedIndex].Name);
                if (q1 == q2)
                {
                    textBox1.Text = Convert.ToString(listClints[listBox1.SelectedIndex].Price);
                }
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_basket_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            File.WriteAllText(@"basket.txt", string.Empty);
            MessageBox.Show("Покупка совершена");
            textBox1.Text = null;
            textBox4.Text = null;
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            Form Form_Base = new form_base();
            Form_Base.Left = this.Left;
            Form_Base.Top = this.Top;
            Form_Base.Show();
            this.Hide();
        }
        public void SaveFile(List<cpu_info> goods)
        {

            for (int i = 0; i < goods.Count; i++)
            {
                FileStream fs = new FileStream("basket.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                fs.Close();
                using (StreamWriter zapis = new StreamWriter("basket.txt", true))
                {
                    zapis.WriteLine(Convert.ToString( goods[i].Name + ";" + Convert.ToString(goods[i].Price)));
                    zapis.Close();
                }
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            all_price = all_price - Convert.ToInt32(listClints[listBox1.SelectedIndex].Price);
            listClints.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            SaveFile(listClints);
            textBox4.Text = (Convert.ToString( all_price));

        }
    }
}

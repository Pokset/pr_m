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
    public partial class Form_cooling : Form
    {
        StreamReader rea = null;
        List<cpu_info> listClints = new List<cpu_info>(); // лист для записи элементов из файла
        string path = "cooling_info.txt";
        public string select_item = null;
        public string select_item_price = null;
        class cpu_info
        {
            public string Name; // Name
            public string Socket; // Socket
            public string TNoC; // Total number of cores
            public string MNoT; // Maximum number of threads
            public string CPUbc; // CPU base frequency
            public string MFiTM; // Maximum frequency in turbo mode
            public string TecPr; // Technical Process
            public string Core; // Core
            public string Price; // цена

            public cpu_info(string name, string socket, string tnoc, string mnoc, string cpubc, string mfitm, string tecpr, string core, string price)
            {
                this.Name = name;
                this.Socket = socket;
                this.MNoT = mnoc;
                this.TNoC = tnoc;
                this.CPUbc = cpubc;
                this.MFiTM = mfitm;
                this.TecPr = tecpr;
                this.Core = core;
                this.Price = price;

            }
        }
        public void fill()
        {
            tb_Name.Text = Convert.ToString(listClints[listBox1.SelectedIndex].Name);
            tb_Socket.Text = Convert.ToString(listClints[listBox1.SelectedIndex].Socket);
            tb_TNoC.Text = Convert.ToString(listClints[listBox1.SelectedIndex].TNoC);
            tb_MNoT.Text = Convert.ToString(listClints[listBox1.SelectedIndex].MNoT);
            tb_CPUbf.Text = Convert.ToString(listClints[listBox1.SelectedIndex].CPUbc);
            tb_MFiTM.Text = Convert.ToString(listClints[listBox1.SelectedIndex].MFiTM);
            tb_TecPr.Text = Convert.ToString(listClints[listBox1.SelectedIndex].TecPr);
            tb_Core.Text = Convert.ToString(listClints[listBox1.SelectedIndex].Core);
            tb_price.Text = Convert.ToString(listClints[listBox1.SelectedIndex].Price);
        }
        public Form_cooling()
        {
            // функция считывания данных из файла, их сплитовка, запись отдельных элементов в массив mas
            rea = new StreamReader("cooling_info.txt");
            InitializeComponent();
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            string[] mas = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                mas = lines[i].Split(';');
                cpu_info Cpu_Info = new cpu_info(mas[0], mas[1], mas[2], mas[3], mas[4], mas[5], mas[6], mas[7], mas[8]);
                listClints.Add(Cpu_Info);
            }
            rea.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string SItem = Convert.ToString(listBox1.SelectedItem);
                string SIndex = Convert.ToString(listClints[listBox1.SelectedIndex].Name);
                if (SItem == SIndex)
                {
                    tb_Name.Text = Convert.ToString(listClints[listBox1.SelectedIndex].Name);
                    tb_Socket.Text = Convert.ToString(listClints[listBox1.SelectedIndex].Socket);
                    tb_TNoC.Text = Convert.ToString(listClints[listBox1.SelectedIndex].TNoC);
                    tb_MNoT.Text = Convert.ToString(listClints[listBox1.SelectedIndex].MNoT);
                    tb_CPUbf.Text = Convert.ToString(listClints[listBox1.SelectedIndex].CPUbc);
                    tb_MFiTM.Text = Convert.ToString(listClints[listBox1.SelectedIndex].MFiTM);
                    tb_TecPr.Text = Convert.ToString(listClints[listBox1.SelectedIndex].TecPr);
                    tb_Core.Text = Convert.ToString(listClints[listBox1.SelectedIndex].Core);
                    tb_price.Text = Convert.ToString(listClints[listBox1.SelectedIndex].Price);
                }
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form Form_Base = new form_base();
            Form_Base.Left = this.Left;
            Form_Base.Top = this.Top;
            Form_Base.Show();
            this.Hide();
        }

        private void Form_cooling_Load(object sender, EventArgs e)
        {

        }

        private void bt_add_to_basket_Click(object sender, EventArgs e)
        {
            select_item = listClints[listBox1.SelectedIndex].Name;
            select_item_price = listClints[listBox1.SelectedIndex].Price;
            Form form_basket = new Form_basket();
            using (StreamWriter zapis = new StreamWriter("basket.txt", true))
            {
                zapis.WriteLine(select_item + ";" + select_item_price);
                zapis.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_m
{
    public partial class form_base : Form
    {
        static public bool flag = false;
        public form_base()

        {
            InitializeComponent();
        }

        private void cb_close_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_profile_Click(object sender, EventArgs e)
        {
            if(flag == false)
            {
                Form formP = new Form_plofil();
                formP.Left = this.Left;
                formP.Top = this.Top;
                formP.Show();
            }
            else
            {
                Form fu = new form_user();
                fu.Left = this.Left;
                fu.Top = this.Top;
                fu.Show();
            }
            
          //  this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formCPU = new Form_cpu();
            formCPU.Left = this.Left;
            formCPU.Top = this.Top;
            formCPU.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formGPU = new Form_gpu();
            formGPU.Left = this.Left;
            formGPU.Top = this.Top;
            formGPU.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formmb = new Form_motherboard();
            formmb.Left = this.Left;
            formmb.Top = this.Top;
            formmb.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formram = new Form_RAM();
            formram.Left = this.Left;
            formram.Top = this.Top;
            formram.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formbp = new Form_BP();
            formbp.Left = this.Left;
            formbp.Top = this.Top;
            formbp.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formbp1 = new Form_body();
            formbp1.Left = this.Left;
            formbp1.Top = this.Top;
            formbp1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form formbp2 = new Form_cooling();
            formbp2.Left = this.Left;
            formbp2.Top = this.Top;
            formbp2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form formbp3 = new Form_ssd();
            formbp3.Left = this.Left;
            formbp3.Top = this.Top;
            formbp3.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form formbp4 = new Form_HDD();
            formbp4.Left = this.Left;
            formbp4.Top = this.Top;
            formbp4.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form form_corzina = new Form_basket();
            form_corzina.Left = this.Left;
            form_corzina.Top = this.Top;
            form_corzina.Show();
            this.Hide();
        }

        private void form_base_Load(object sender, EventArgs e)
        {

        }
    }
}

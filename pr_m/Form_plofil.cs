using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pr_m
{
    public partial class Form_plofil : Form
    {
        public Form_plofil()
        {
            InitializeComponent();
        }

        private void button_bak_Click(object sender, EventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.StartPosition = FormStartPosition.Manual;
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
            this.Hide();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Form formR = new Form_register();
            formR.Left = this.Left;
            formR.Top = this.Top;
            formR.Show();
            this.Hide();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Form formR = new form_login();
            formR.Left = this.Left;
            formR.Top = this.Top;
            formR.Show();
            this.Hide();
        }
    }
}

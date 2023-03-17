
namespace pr_m
{
    partial class Form_gpu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.lb_price = new System.Windows.Forms.Label();
            this.tb_Core = new System.Windows.Forms.TextBox();
            this.tb_TecPr = new System.Windows.Forms.TextBox();
            this.tb_MFiTM = new System.Windows.Forms.TextBox();
            this.tb_CPUbf = new System.Windows.Forms.TextBox();
            this.tb_MNoT = new System.Windows.Forms.TextBox();
            this.tb_TNoC = new System.Windows.Forms.TextBox();
            this.tb_Socket = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_CPUbf = new System.Windows.Forms.Label();
            this.lb_TNoC = new System.Windows.Forms.Label();
            this.lb_Core = new System.Windows.Forms.Label();
            this.lb_MFiTM = new System.Windows.Forms.Label();
            this.lb_TecPr = new System.Windows.Forms.Label();
            this.lb_MNoT = new System.Windows.Forms.Label();
            this.lb_Socket = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.bt_add_to_basket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "GeForce GTX 1650",
            "GeForce RTX 3090 Ti",
            "GeForce GTX 1050 Ti"});
            this.listBox1.Location = new System.Drawing.Point(12, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(409, 424);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(711, 414);
            this.tb_price.Name = "tb_price";
            this.tb_price.ReadOnly = true;
            this.tb_price.Size = new System.Drawing.Size(197, 23);
            this.tb_price.TabIndex = 36;
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Location = new System.Drawing.Point(444, 422);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(35, 15);
            this.lb_price.TabIndex = 35;
            this.lb_price.Text = "Цена";
            // 
            // tb_Core
            // 
            this.tb_Core.Location = new System.Drawing.Point(711, 364);
            this.tb_Core.Name = "tb_Core";
            this.tb_Core.ReadOnly = true;
            this.tb_Core.Size = new System.Drawing.Size(197, 23);
            this.tb_Core.TabIndex = 34;
            // 
            // tb_TecPr
            // 
            this.tb_TecPr.Location = new System.Drawing.Point(711, 314);
            this.tb_TecPr.Name = "tb_TecPr";
            this.tb_TecPr.ReadOnly = true;
            this.tb_TecPr.Size = new System.Drawing.Size(197, 23);
            this.tb_TecPr.TabIndex = 33;
            // 
            // tb_MFiTM
            // 
            this.tb_MFiTM.Location = new System.Drawing.Point(711, 264);
            this.tb_MFiTM.Name = "tb_MFiTM";
            this.tb_MFiTM.ReadOnly = true;
            this.tb_MFiTM.Size = new System.Drawing.Size(197, 23);
            this.tb_MFiTM.TabIndex = 32;
            // 
            // tb_CPUbf
            // 
            this.tb_CPUbf.Location = new System.Drawing.Point(711, 214);
            this.tb_CPUbf.Name = "tb_CPUbf";
            this.tb_CPUbf.ReadOnly = true;
            this.tb_CPUbf.Size = new System.Drawing.Size(197, 23);
            this.tb_CPUbf.TabIndex = 31;
            // 
            // tb_MNoT
            // 
            this.tb_MNoT.Location = new System.Drawing.Point(711, 164);
            this.tb_MNoT.Name = "tb_MNoT";
            this.tb_MNoT.ReadOnly = true;
            this.tb_MNoT.Size = new System.Drawing.Size(197, 23);
            this.tb_MNoT.TabIndex = 30;
            // 
            // tb_TNoC
            // 
            this.tb_TNoC.Location = new System.Drawing.Point(711, 114);
            this.tb_TNoC.Name = "tb_TNoC";
            this.tb_TNoC.ReadOnly = true;
            this.tb_TNoC.Size = new System.Drawing.Size(197, 23);
            this.tb_TNoC.TabIndex = 29;
            // 
            // tb_Socket
            // 
            this.tb_Socket.Location = new System.Drawing.Point(711, 64);
            this.tb_Socket.Name = "tb_Socket";
            this.tb_Socket.ReadOnly = true;
            this.tb_Socket.Size = new System.Drawing.Size(197, 23);
            this.tb_Socket.TabIndex = 28;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(711, 14);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.ReadOnly = true;
            this.tb_Name.Size = new System.Drawing.Size(197, 23);
            this.tb_Name.TabIndex = 27;
            // 
            // lb_CPUbf
            // 
            this.lb_CPUbf.AutoSize = true;
            this.lb_CPUbf.Location = new System.Drawing.Point(444, 222);
            this.lb_CPUbf.Name = "lb_CPUbf";
            this.lb_CPUbf.Size = new System.Drawing.Size(70, 15);
            this.lb_CPUbf.TabIndex = 26;
            this.lb_CPUbf.Text = "Тип памяти";
            // 
            // lb_TNoC
            // 
            this.lb_TNoC.AutoSize = true;
            this.lb_TNoC.Location = new System.Drawing.Point(444, 122);
            this.lb_TNoC.Name = "lb_TNoC";
            this.lb_TNoC.Size = new System.Drawing.Size(71, 15);
            this.lb_TNoC.TabIndex = 25;
            this.lb_TNoC.Text = "Техпроцесс";
            // 
            // lb_Core
            // 
            this.lb_Core.AutoSize = true;
            this.lb_Core.Location = new System.Drawing.Point(444, 372);
            this.lb_Core.Name = "lb_Core";
            this.lb_Core.Size = new System.Drawing.Size(162, 15);
            this.lb_Core.TabIndex = 24;
            this.lb_Core.Text = "Максимальное разрешение";
            // 
            // lb_MFiTM
            // 
            this.lb_MFiTM.AutoSize = true;
            this.lb_MFiTM.Location = new System.Drawing.Point(444, 272);
            this.lb_MFiTM.Name = "lb_MFiTM";
            this.lb_MFiTM.Size = new System.Drawing.Size(204, 15);
            this.lb_MFiTM.TabIndex = 23;
            this.lb_MFiTM.Text = "Штатная частота работы видеочипа";
            // 
            // lb_TecPr
            // 
            this.lb_TecPr.AutoSize = true;
            this.lb_TecPr.Location = new System.Drawing.Point(444, 322);
            this.lb_TecPr.Name = "lb_TecPr";
            this.lb_TecPr.Size = new System.Drawing.Size(82, 15);
            this.lb_TecPr.TabIndex = 22;
            this.lb_TecPr.Text = "Турбочастота";
            // 
            // lb_MNoT
            // 
            this.lb_MNoT.AutoSize = true;
            this.lb_MNoT.Location = new System.Drawing.Point(444, 172);
            this.lb_MNoT.Name = "lb_MNoT";
            this.lb_MNoT.Size = new System.Drawing.Size(120, 15);
            this.lb_MNoT.TabIndex = 21;
            this.lb_MNoT.Text = "Объем видеопамяти";
            // 
            // lb_Socket
            // 
            this.lb_Socket.AutoSize = true;
            this.lb_Socket.Location = new System.Drawing.Point(444, 72);
            this.lb_Socket.Name = "lb_Socket";
            this.lb_Socket.Size = new System.Drawing.Size(112, 15);
            this.lb_Socket.TabIndex = 20;
            this.lb_Socket.Text = "Микроархитектура";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(444, 22);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(144, 15);
            this.lb_Name.TabIndex = 19;
            this.lb_Name.Text = "Графический процессор";
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(12, 443);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(100, 23);
            this.button_back.TabIndex = 37;
            this.button_back.Text = "<------";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // bt_add_to_basket
            // 
            this.bt_add_to_basket.Location = new System.Drawing.Point(773, 443);
            this.bt_add_to_basket.Name = "bt_add_to_basket";
            this.bt_add_to_basket.Size = new System.Drawing.Size(160, 23);
            this.bt_add_to_basket.TabIndex = 38;
            this.bt_add_to_basket.Text = "Добавить в корзину";
            this.bt_add_to_basket.UseVisualStyleBackColor = true;
            this.bt_add_to_basket.Click += new System.EventHandler(this.bt_add_to_basket_Click);
            // 
            // Form_gpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 476);
            this.Controls.Add(this.bt_add_to_basket);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.tb_Core);
            this.Controls.Add(this.tb_TecPr);
            this.Controls.Add(this.tb_MFiTM);
            this.Controls.Add(this.tb_CPUbf);
            this.Controls.Add(this.tb_MNoT);
            this.Controls.Add(this.tb_TNoC);
            this.Controls.Add(this.tb_Socket);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lb_CPUbf);
            this.Controls.Add(this.lb_TNoC);
            this.Controls.Add(this.lb_Core);
            this.Controls.Add(this.lb_MFiTM);
            this.Controls.Add(this.lb_TecPr);
            this.Controls.Add(this.lb_MNoT);
            this.Controls.Add(this.lb_Socket);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.listBox1);
            this.Name = "Form_gpu";
            this.Text = "Видеокарты";
            this.Load += new System.EventHandler(this.Form_gpu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.TextBox tb_Core;
        private System.Windows.Forms.TextBox tb_TecPr;
        private System.Windows.Forms.TextBox tb_MFiTM;
        private System.Windows.Forms.TextBox tb_CPUbf;
        private System.Windows.Forms.TextBox tb_MNoT;
        private System.Windows.Forms.TextBox tb_TNoC;
        private System.Windows.Forms.TextBox tb_Socket;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_CPUbf;
        private System.Windows.Forms.Label lb_TNoC;
        private System.Windows.Forms.Label lb_Core;
        private System.Windows.Forms.Label lb_MFiTM;
        private System.Windows.Forms.Label lb_TecPr;
        private System.Windows.Forms.Label lb_MNoT;
        private System.Windows.Forms.Label lb_Socket;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button bt_add_to_basket;
    }
}
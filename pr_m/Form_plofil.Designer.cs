
namespace pr_m
{
    partial class Form_plofil
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
            this.button_bak = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_bak
            // 
            this.button_bak.BackColor = System.Drawing.SystemColors.Window;
            this.button_bak.Location = new System.Drawing.Point(58, 286);
            this.button_bak.Name = "button_bak";
            this.button_bak.Size = new System.Drawing.Size(102, 33);
            this.button_bak.TabIndex = 0;
            this.button_bak.Text = "<----";
            this.button_bak.UseVisualStyleBackColor = false;
            this.button_bak.Click += new System.EventHandler(this.button_bak_Click);
            // 
            // button_register
            // 
            this.button_register.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_register.Location = new System.Drawing.Point(12, 74);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(200, 100);
            this.button_register.TabIndex = 1;
            this.button_register.Text = "Регистрация";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_login.Location = new System.Drawing.Point(12, 180);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(200, 100);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Войти";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-2, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вы не вошли в аккаунт";
            // 
            // Form_plofil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(231, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_bak);
            this.Name = "Form_plofil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Профиль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_bak;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label1;
    }
}
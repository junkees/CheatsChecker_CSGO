
namespace Cheats_Checker_by_onlyawp.ru
{
    partial class loginform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainzagolovok = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minimazelabel = new System.Windows.Forms.Label();
            this.closelabel = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.rememberme = new System.Windows.Forms.CheckBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.mainzagolovok);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.loginbutton);
            this.panel1.Controls.Add(this.rememberme);
            this.panel1.Controls.Add(this.password_textbox);
            this.panel1.Controls.Add(this.login_textbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cheats_Checker_by_onlyawp.ru.Properties.Resources.passicon;
            this.pictureBox2.Location = new System.Drawing.Point(186, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cheats_Checker_by_onlyawp.ru.Properties.Resources.usericon;
            this.pictureBox1.Location = new System.Drawing.Point(187, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // mainzagolovok
            // 
            this.mainzagolovok.AutoSize = true;
            this.mainzagolovok.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainzagolovok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(156)))), ((int)(((byte)(175)))));
            this.mainzagolovok.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainzagolovok.Location = new System.Drawing.Point(201, 108);
            this.mainzagolovok.Name = "mainzagolovok";
            this.mainzagolovok.Size = new System.Drawing.Size(384, 39);
            this.mainzagolovok.TabIndex = 2;
            this.mainzagolovok.Text = "onlyawp.ru - cheats checker";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.minimazelabel);
            this.panel2.Controls.Add(this.closelabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 32);
            this.panel2.TabIndex = 4;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // minimazelabel
            // 
            this.minimazelabel.AutoSize = true;
            this.minimazelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimazelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(156)))), ((int)(((byte)(175)))));
            this.minimazelabel.Location = new System.Drawing.Point(747, 3);
            this.minimazelabel.Name = "minimazelabel";
            this.minimazelabel.Size = new System.Drawing.Size(17, 24);
            this.minimazelabel.TabIndex = 1;
            this.minimazelabel.Text = "-";
            this.minimazelabel.Click += new System.EventHandler(this.minimazelabel_Click);
            // 
            // closelabel
            // 
            this.closelabel.AutoSize = true;
            this.closelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(156)))), ((int)(((byte)(175)))));
            this.closelabel.Location = new System.Drawing.Point(769, 7);
            this.closelabel.Name = "closelabel";
            this.closelabel.Size = new System.Drawing.Size(19, 18);
            this.closelabel.TabIndex = 0;
            this.closelabel.Text = "X";
            this.closelabel.Click += new System.EventHandler(this.closelabel_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.loginbutton.FlatAppearance.BorderSize = 0;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(156)))), ((int)(((byte)(175)))));
            this.loginbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginbutton.Location = new System.Drawing.Point(351, 284);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(223, 23);
            this.loginbutton.TabIndex = 3;
            this.loginbutton.Text = "ВОЙТИ";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // rememberme
            // 
            this.rememberme.AutoSize = true;
            this.rememberme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.rememberme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(156)))), ((int)(((byte)(175)))));
            this.rememberme.Location = new System.Drawing.Point(247, 288);
            this.rememberme.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.rememberme.Name = "rememberme";
            this.rememberme.Size = new System.Drawing.Size(101, 17);
            this.rememberme.TabIndex = 2;
            this.rememberme.Text = "ЗАПОМНИТЬ?";
            this.rememberme.UseVisualStyleBackColor = false;
            // 
            // password_textbox
            // 
            this.password_textbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password_textbox.Location = new System.Drawing.Point(244, 243);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(330, 20);
            this.password_textbox.TabIndex = 1;
            // 
            // login_textbox
            // 
            this.login_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_textbox.Location = new System.Drawing.Point(244, 189);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(330, 20);
            this.login_textbox.TabIndex = 0;
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginform";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.CheckBox rememberme;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closelabel;
        private System.Windows.Forms.Label minimazelabel;
        private System.Windows.Forms.Label mainzagolovok;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
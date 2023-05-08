namespace WindowsFormsApplication3
{
    partial class Form3
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
            this.Usr = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SignUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usr
            // 
            this.Usr.AutoSize = true;
            this.Usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usr.ForeColor = System.Drawing.Color.White;
            this.Usr.Location = new System.Drawing.Point(57, 135);
            this.Usr.Name = "Usr";
            this.Usr.Size = new System.Drawing.Size(97, 24);
            this.Usr.TabIndex = 0;
            this.Usr.Text = "Username";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.Color.White;
            this.Pass.Location = new System.Drawing.Point(57, 195);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(92, 24);
            this.Pass.TabIndex = 1;
            this.Pass.Text = "Password";
            this.Pass.Click += new System.EventHandler(this.label2_Click);
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.ForeColor = System.Drawing.Color.White;
            this.EmailLbl.Location = new System.Drawing.Point(57, 257);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(57, 24);
            this.EmailLbl.TabIndex = 2;
            this.EmailLbl.Text = "Email";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(184, 132);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(129, 29);
            this.username.TabIndex = 3;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(184, 252);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(129, 29);
            this.email.TabIndex = 4;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(184, 192);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(129, 29);
            this.password.TabIndex = 5;
            // 
            // SignUp
            // 
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.Location = new System.Drawing.Point(112, 334);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(129, 42);
            this.SignUp.TabIndex = 6;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\pizzeria.png";
            this.pictureBox1.Location = new System.Drawing.Point(398, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 594);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(997, 587);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.username);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Usr);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usr;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
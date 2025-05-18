namespace NoteLogin
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            login_box = new TextBox();
            label2 = new Label();
            password_box = new TextBox();
            enter_button = new Button();
            label3 = new Label();
            newAccount_button = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 102);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // login_box
            // 
            login_box.Location = new Point(100, 125);
            login_box.Name = "login_box";
            login_box.Size = new Size(276, 27);
            login_box.TabIndex = 1;
            login_box.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 183);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // password_box
            // 
            password_box.Location = new Point(100, 206);
            password_box.MaxLength = 16;
            password_box.Name = "password_box";
            password_box.PasswordChar = '*';
            password_box.Size = new Size(277, 27);
            password_box.TabIndex = 3;
            password_box.UseSystemPasswordChar = true;
            // 
            // enter_button
            // 
            enter_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            enter_button.ForeColor = SystemColors.ActiveCaptionText;
            enter_button.Location = new Point(172, 266);
            enter_button.Name = "enter_button";
            enter_button.Size = new Size(132, 41);
            enter_button.TabIndex = 4;
            enter_button.Text = "ENTRAR";
            enter_button.UseVisualStyleBackColor = true;
            enter_button.Click += enter_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 20F);
            label3.Location = new Point(141, 9);
            label3.Name = "label3";
            label3.Size = new Size(226, 49);
            label3.TabIndex = 5;
            label3.Text = "BEM VINDO!";
            // 
            // newAccount_button
            // 
            newAccount_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            newAccount_button.ForeColor = SystemColors.ActiveCaptionText;
            newAccount_button.Location = new Point(172, 385);
            newAccount_button.Name = "newAccount_button";
            newAccount_button.Size = new Size(132, 48);
            newAccount_button.TabIndex = 6;
            newAccount_button.Text = "CRIAR CONTA";
            newAccount_button.UseVisualStyleBackColor = true;
            newAccount_button.Click += newAccount_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(215, 329);
            label4.Name = "label4";
            label4.Size = new Size(48, 32);
            label4.TabIndex = 7;
            label4.Text = "OU";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(501, 507);
            Controls.Add(label4);
            Controls.Add(newAccount_button);
            Controls.Add(label3);
            Controls.Add(enter_button);
            Controls.Add(password_box);
            Controls.Add(label2);
            Controls.Add(login_box);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox login_box;
        private Label label2;
        private TextBox password_box;
        private Button enter_button;
        private Label label3;
        private Button newAccount_button;
        private Label label4;
    }
}

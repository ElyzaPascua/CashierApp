namespace CashierApp
{
    partial class Form2
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
            label1 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            label2 = new Label();
            butt_Login = new Button();
            cb_show = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(112, 24);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(12, 60);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(314, 34);
            txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(12, 147);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(314, 34);
            txt_password.TabIndex = 3;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 120);
            label2.Name = "label2";
            label2.Size = new Size(107, 24);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // butt_Login
            // 
            butt_Login.BackColor = Color.FromArgb(255, 192, 192);
            butt_Login.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_Login.Location = new Point(12, 235);
            butt_Login.Name = "butt_Login";
            butt_Login.Size = new Size(314, 54);
            butt_Login.TabIndex = 4;
            butt_Login.Text = "Login";
            butt_Login.UseVisualStyleBackColor = false;
            butt_Login.Click += butt_Login_Click;
            // 
            // cb_show
            // 
            cb_show.AutoSize = true;
            cb_show.Location = new Point(12, 187);
            cb_show.Name = "cb_show";
            cb_show.Size = new Size(132, 24);
            cb_show.TabIndex = 5;
            cb_show.Text = "Show Password";
            cb_show.UseVisualStyleBackColor = true;
            cb_show.CheckedChanged += cb_show_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(338, 331);
            Controls.Add(cb_show);
            Controls.Add(butt_Login);
            Controls.Add(txt_password);
            Controls.Add(label2);
            Controls.Add(txt_username);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            Text = "User Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label2;
        private Button butt_Login;
        private CheckBox cb_show;
    }
}
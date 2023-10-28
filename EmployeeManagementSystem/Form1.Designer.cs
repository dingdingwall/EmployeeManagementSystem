namespace EmployeeManagementSystem
{
    partial class Login
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
            label3 = new Label();
            label2 = new Label();
            UserTxtbox = new TextBox();
            login_btn = new Button();
            PasswordTxtBox = new TextBox();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            exitbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(129, 128);
            label1.Name = "label1";
            label1.Size = new Size(122, 45);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(129, 214);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(129, 287);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // UserTxtbox
            // 
            UserTxtbox.Location = new Point(135, 242);
            UserTxtbox.Multiline = true;
            UserTxtbox.Name = "UserTxtbox";
            UserTxtbox.Size = new Size(265, 29);
            UserTxtbox.TabIndex = 4;
            // 
            // login_btn
            // 
            login_btn.FlatAppearance.BorderColor = Color.White;
            login_btn.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            login_btn.Location = new Point(135, 377);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(269, 43);
            login_btn.TabIndex = 6;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Location = new Point(135, 326);
            PasswordTxtBox.Multiline = true;
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.Size = new Size(265, 29);
            PasswordTxtBox.TabIndex = 7;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(135, 437);
            button1.Name = "button1";
            button1.Size = new Size(269, 43);
            button1.TabIndex = 8;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 593);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(542, 12);
            progressBar1.TabIndex = 9;
            // 
            // exitbutton
            // 
            exitbutton.Location = new Point(488, 12);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(42, 23);
            exitbutton.TabIndex = 10;
            exitbutton.Text = "EXIT";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 3, 149);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(542, 607);
            Controls.Add(exitbutton);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(PasswordTxtBox);
            Controls.Add(login_btn);
            Controls.Add(UserTxtbox);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox UserTxtbox;
        private Button login_btn;
        private TextBox PasswordTxtBox;
        private Button button1;
        private ProgressBar progressBar1;
        private Button exitbutton;
    }
}
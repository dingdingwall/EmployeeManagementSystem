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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            UserTxtbox = new TextBox();
            login_btn = new Button();
            PasswordTxtBox = new TextBox();
            clear_btn = new Button();
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(135, 145);
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
            label3.Location = new Point(135, 214);
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
            label2.Location = new Point(135, 296);
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
            UserTxtbox.Size = new Size(237, 29);
            UserTxtbox.TabIndex = 4;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.White;
            login_btn.FlatAppearance.BorderColor = Color.White;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            login_btn.ForeColor = Color.Indigo;
            login_btn.Location = new Point(135, 368);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(237, 42);
            login_btn.TabIndex = 6;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Location = new Point(135, 324);
            PasswordTxtBox.Multiline = true;
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PasswordChar = '*';
            PasswordTxtBox.Size = new Size(237, 29);
            PasswordTxtBox.TabIndex = 7;
            PasswordTxtBox.TextChanged += PasswordTxtBox_TextChanged;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.White;
            clear_btn.FlatAppearance.BorderColor = Color.White;
            clear_btn.FlatStyle = FlatStyle.Flat;
            clear_btn.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            clear_btn.ForeColor = Color.Indigo;
            clear_btn.Location = new Point(135, 426);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(237, 38);
            clear_btn.TabIndex = 8;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 593);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(542, 12);
            progressBar1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(493, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(263, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 3, 149);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(544, 607);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(clear_btn);
            Controls.Add(PasswordTxtBox);
            Controls.Add(login_btn);
            Controls.Add(UserTxtbox);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Button clear_btn;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
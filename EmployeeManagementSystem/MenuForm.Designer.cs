namespace EmployeeManagementSystem
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            label1 = new Label();
            groupBox1 = new GroupBox();
            salary_txtbox = new TextBox();
            designation_txtbox = new TextBox();
            employeeName_txtbox = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            employeeId_txtbox = new TextBox();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label5 = new Label();
            logout = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            view_picturebox = new PictureBox();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)view_picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(348, 9);
            label1.Name = "label1";
            label1.Size = new Size(387, 29);
            label1.TabIndex = 0;
            label1.Text = "Employee Management System";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(salary_txtbox);
            groupBox1.Controls.Add(designation_txtbox);
            groupBox1.Controls.Add(employeeName_txtbox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(employeeId_txtbox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(12, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1023, 243);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // salary_txtbox
            // 
            salary_txtbox.BorderStyle = BorderStyle.None;
            salary_txtbox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            salary_txtbox.Location = new Point(493, 146);
            salary_txtbox.Multiline = true;
            salary_txtbox.Name = "salary_txtbox";
            salary_txtbox.Size = new Size(132, 23);
            salary_txtbox.TabIndex = 14;
            // 
            // designation_txtbox
            // 
            designation_txtbox.BorderStyle = BorderStyle.None;
            designation_txtbox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            designation_txtbox.Location = new Point(493, 69);
            designation_txtbox.Multiline = true;
            designation_txtbox.Name = "designation_txtbox";
            designation_txtbox.Size = new Size(132, 23);
            designation_txtbox.TabIndex = 13;
            // 
            // employeeName_txtbox
            // 
            employeeName_txtbox.BorderStyle = BorderStyle.None;
            employeeName_txtbox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            employeeName_txtbox.Location = new Point(182, 153);
            employeeName_txtbox.Multiline = true;
            employeeName_txtbox.Name = "employeeName_txtbox";
            employeeName_txtbox.Size = new Size(132, 23);
            employeeName_txtbox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(425, 146);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 11;
            label6.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(379, 69);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 10;
            label4.Text = "Designation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 153);
            label3.Name = "label3";
            label3.Size = new Size(146, 23);
            label3.TabIndex = 8;
            label3.Text = "Employee Name";
            // 
            // employeeId_txtbox
            // 
            employeeId_txtbox.BorderStyle = BorderStyle.None;
            employeeId_txtbox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            employeeId_txtbox.Location = new Point(182, 69);
            employeeId_txtbox.Multiline = true;
            employeeId_txtbox.Name = "employeeId_txtbox";
            employeeId_txtbox.Size = new Size(132, 23);
            employeeId_txtbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 69);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 0;
            label2.Text = "Employee Id";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(780, 146);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 18);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(780, 111);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(49, 18);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(722, 69);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            // 
            // logout
            // 
            logout.AutoSize = true;
            logout.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            logout.ForeColor = SystemColors.ButtonHighlight;
            logout.Location = new Point(941, 22);
            logout.Name = "logout";
            logout.Size = new Size(52, 16);
            logout.TabIndex = 6;
            logout.Text = "Logout";
            logout.Click += label7_Click;
            // 
            // button1
            // 
            button1.Location = new Point(260, 537);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(389, 537);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "SELECT";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(537, 537);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(678, 537);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "RESET";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(999, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // view_picturebox
            // 
            view_picturebox.Image = (Image)resources.GetObject("view_picturebox.Image");
            view_picturebox.Location = new Point(12, 12);
            view_picturebox.Name = "view_picturebox";
            view_picturebox.Size = new Size(73, 65);
            view_picturebox.SizeMode = PictureBoxSizeMode.CenterImage;
            view_picturebox.TabIndex = 12;
            view_picturebox.TabStop = false;
            view_picturebox.Click += view_picturebox_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(12, 90);
            label8.Name = "label8";
            label8.Size = new Size(114, 16);
            label8.TabIndex = 14;
            label8.Text = "View  Employees";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(437, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 3, 149);
            ClientSize = new Size(1047, 678);
            Controls.Add(pictureBox2);
            Controls.Add(label8);
            Controls.Add(view_picturebox);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(logout);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuForm";
            Load += MenuForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)view_picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox employeeId_txtbox;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label4;
        private RadioButton radioButton1;
        private Label label5;
        private RadioButton radioButton2;
        private Label logout;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private TextBox employeeName_txtbox;
        private PictureBox view_picturebox;
        private TextBox salary_txtbox;
        private TextBox designation_txtbox;
        private Label label8;
        private PictureBox pictureBox2;
    }
}
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            radioButton1 = new RadioButton();
            label5 = new Label();
            radioButton2 = new RadioButton();
            logout = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(234, 9);
            label1.Name = "label1";
            label1.Size = new Size(599, 45);
            label1.TabIndex = 0;
            label1.Text = "Employee Management System";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(103, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(856, 229);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(626, 158);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(183, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(626, 69);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(183, 23);
            textBox3.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(494, 158);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 11;
            label6.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(494, 69);
            label4.Name = "label4";
            label4.Size = new Size(115, 23);
            label4.TabIndex = 10;
            label4.Text = "Employee Id";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 153);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 23);
            textBox2.TabIndex = 9;
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
            // textBox1
            // 
            textBox1.Location = new Point(182, 69);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 2;
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
            radioButton1.Location = new Point(112, 402);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(49, 18);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(112, 366);
            label5.Name = "label5";
            label5.Size = new Size(115, 23);
            label5.TabIndex = 4;
            label5.Text = "Employee Id";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(112, 442);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(49, 18);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            logout.AutoSize = true;
            logout.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            logout.ForeColor = SystemColors.ButtonHighlight;
            logout.Location = new Point(948, 9);
            logout.Name = "logout";
            logout.Size = new Size(97, 29);
            logout.TabIndex = 6;
            logout.Text = "Logout";
            logout.Click += label7_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 3, 149);
            ClientSize = new Size(1047, 678);
            Controls.Add(logout);
            Controls.Add(radioButton2);
            Controls.Add(label5);
            Controls.Add(radioButton1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "MenuForm";
            Text = "MenuForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label6;
        private Label label4;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private Label label5;
        private RadioButton radioButton2;
        private Label logout;
    }
}
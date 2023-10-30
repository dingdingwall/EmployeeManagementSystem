using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EmployeeManagementSystem
{
    public partial class MenuForm : Form
    {








        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        public MenuForm()
        {
            InitializeComponent();

            btn_reset.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_reset.Width, btn_reset.Height, 30, 30));





        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Hide();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Hide();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void view_picturebox_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }


        void Reset()
        {
            employeeId_txtbox.Text = employeeName_txtbox.Text = designation_txtbox.Text = salary_txtbox.Text = "";
            radiobtn_male.Checked = false;
            radiobtn_female.Checked = false;

        }
    }
}

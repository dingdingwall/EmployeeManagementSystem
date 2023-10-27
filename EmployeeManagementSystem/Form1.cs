using System.Data;
using System;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace EmployeeManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void login_btn_Click(object sender, EventArgs e)
        {
            string connectionString = " Data Source=DESKTOP-DCPNVH9\\SQLEXPRESS;Initial Catalog=MyDataBase;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);

            string username, password;

            username = UserTxtbox.Text;
            password = PasswordTxtBox.Text;



            try
            {
                String querry = "SELECT * FROM Login WHERE username = '" + UserTxtbox.Text + "' AND password = '" + PasswordTxtBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);


                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    username = UserTxtbox.Text;
                    password = PasswordTxtBox.Text;

                    MenuForm form = new MenuForm();
                    form.Show();
                    this.Hide();


                }

                else
                {

                    MessageBox.Show("Wrong Username and Password ");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            finally
            {

                if (conn.State == ConnectionState.Open)

                {
                    conn.Close();
                }
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            UserTxtbox.Clear();
            PasswordTxtBox.Clear();

        }
    }
}
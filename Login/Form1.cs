using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HISKP3B\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username, Password;
            Username = txbUsername.Text;
            Password = txbPassword.Text;

            try
            {
                string querry = "SELECT * FROM Login WHERE Username = '"+txbUsername.Text+"' AND Password = '"+txbPassword.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    Username = txbUsername.Text;
                    Password = txbPassword.Text;
                    InLogin i = new InLogin();
                    i.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
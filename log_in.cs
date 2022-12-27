using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataBase
{
    public partial class log_in : Form
    {
        DB database = new DB();

        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '#';
            textBox_password.MaxLength = 50;
            textBox_login.MaxLength = 50;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var login = textBox_login.Text;
            var password = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"select * from register where login_user='{login}' and password_user='{password}'";

            SqlCommand command = new SqlCommand(query, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Vy voshli", "Uspeshno!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string shop = table.Rows[0].Field<string>(3);
                Form1 frm1 = new Form1(shop);
                this.Hide();
                frm1.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Net takogo", "Ne sushestvuet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up frm_sign = new sign_up();
            frm_sign.Show();
            this.Hide();
        }
    }
}

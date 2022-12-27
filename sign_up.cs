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

namespace DataBase
{
    public partial class sign_up : Form
    {
        DB database = new DB();

        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var login = textBox_login.Text;
            var password = textBox_password.Text;
            var shop = textBox_shop.Text;

            if (cheklogin())
            {
                return;
            }

            string query = $"insert into register(login_user, password_user, shop_user) values('{login}', '{password}', '{shop}')";
            SqlCommand command = new SqlCommand(query, database.getConnection());

            database.openConnection();

            if(command.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Sozdan", "Uspeh");
                log_in frm_login = new log_in();
                this.Hide();
                frm_login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ne sozdan");
            }
            database.closeConnection();

        }

        public Boolean cheklogin()
        {
            var loginUser = textBox_login.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select * from register where login_user='{loginUser}'";

            SqlCommand command = new SqlCommand(query, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Uzhe estb");
                return true;
            }
            else return false;
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
        }

    }
}

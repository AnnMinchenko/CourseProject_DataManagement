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
    public partial class storage : Form
    {
        string mainShop;

        public storage(string shop)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            mainShop = shop;
        }

        private void storage_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        DB database = new DB();
        int selectedRow;

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("adress", "adress");
            dataGridView1.Columns.Add("name", "name");
            dataGridView1.Columns.Add("amount", "amount");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetValue(2));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query;
            if (mainShop == "admin")
            {
                query = $"select * from storage";
            }
            else
            {
                query = $"select * from storage where Stor_Adress='{mainShop}'";
            }
            SqlCommand command = new SqlCommand(query, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_adress.Text = row.Cells[0].Value.ToString();
                textBox_name.Text = row.Cells[1].Value.ToString();
                textBox_amount.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var name = textBox_addName.Text;
            var adress = textBox_addAdress.Text;
            int amount;

            database.openConnection();

            try
            {
                if (name != "" && adress != "")
                {
                    if (int.TryParse(textBox_addAmount.Text, out amount))
                    {
                        string query;
                        if (mainShop == "admin" || adress == mainShop)
                        {
                            query = $"insert into storage (Stor_Adress, Stor_P_Name, Amount) values ('{adress}','{name}','{amount}')";

                            var command = new SqlCommand(query, database.getConnection());
                            command.ExecuteNonQuery();

                            MessageBox.Show("Создана новая запись", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Неверный адрес магазина", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Количество не является числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность введенных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string search = $"select * from storage where concat (Stor_Adress, Stor_P_Name, Amount) like '%" + textBox_search.Text + "%'";
            SqlCommand command = new SqlCommand(search, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var name = textBox_name.Text;
            var adress = textBox_adress.Text;
            int amount;

            if (name != "" && adress != "")
            {
                if (int.TryParse(textBox_amount.Text, out amount))
                {
                    DialogResult result = MessageBox.Show("Изменить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var query = $"update storage set Amount='{amount}' where Stor_Adress='{adress}' and Stor_P_Name='{name}'";

                        var command = new SqlCommand(query, database.getConnection());
                        command.ExecuteNonQuery();

                        MessageBox.Show("Запись изменена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Количество не является числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                database.closeConnection();
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }
}

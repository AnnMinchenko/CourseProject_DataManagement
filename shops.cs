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
    public partial class shops : Form
    {
        string mainShop;

        public shops(string shop)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            mainShop = shop;
        }

        private void shops_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        DB database = new DB();
        int selectedRow;

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("adress", "adress");
            dataGridView1.Columns.Add("number", "number");
            dataGridView1.Columns.Add("name", "name");
            dataGridView1.Columns.Add("space", "space");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetValue(3));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            string query;
            if (mainShop == "admin")
            {
                query = $"select * from shops";
            }
            else
            {
                query = $"select * from shops where Adress='{mainShop}'";
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
                textBox_number.Text = row.Cells[1].Value.ToString();
                textBox_name.Text = row.Cells[2].Value.ToString();
                textBox_space.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var name = textBox_addName.Text;
            var number = textBox_addNumber.Text;
            var adress = textBox_addAdress.Text;
            int space;

            database.openConnection();

            try
            {
                if (name != "" && number != "" && adress != "")
                {
                    if (int.TryParse(textBox_addSpace.Text, out space))
                    {
                        string query;
                        if (mainShop == "admin")
                        {
                            query = $"insert into shops (Adress, Number, S_Name, Space) values ('{adress}','{number}','{name}','{space}' )";
                            var command = new SqlCommand(query, database.getConnection());
                            command.ExecuteNonQuery();

                            MessageBox.Show("Создана новая запись", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Невозможно добавить новый магазин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Площадь не является числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch(Exception)
            {
                MessageBox.Show("Проверьте правильность введенных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string search = $"select * from shops where concat (Adress, Number, S_Name, Space) like '%" + textBox_search.Text + "%'";
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
            var number = textBox_number.Text;
            var adress = textBox_adress.Text;
            int space;

            if (name != "" && number != "" && adress != "")
            {
                if (int.TryParse(textBox_space.Text, out space))
                {
                    DialogResult result = MessageBox.Show("Изменить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var query = $"update shops set Number='{number}', S_Name='{name}', Space='{space}' where Adress='{adress}'";

                        var command = new SqlCommand(query, database.getConnection());
                        command.ExecuteNonQuery();

                        MessageBox.Show("Запись изменена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Площадь не является числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

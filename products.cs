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
    public partial class products : Form
    {
        DB database = new DB();
        int selectedRow;

        public products()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("name", "name");
            dataGridView1.Columns.Add("grade", "grade");
            dataGridView1.Columns.Add("price", "price");
            dataGridView1.Columns.Add("measure", "measure");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetValue(2), record.GetString(3));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string query = $"select * from products";
            SqlCommand command = new SqlCommand(query, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void products_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_name.Text = row.Cells[0].Value.ToString();
                textBox_grade.Text = row.Cells[1].Value.ToString();
                textBox_price.Text = row.Cells[2].Value.ToString();
                textBox_measure.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var name = textBox_addName.Text;
            var grade = textBox_addGrade.Text;
            var measure = textBox_addMeasure.Text;
            int price;

            database.openConnection();

            
                if (name != "" && grade != "" && measure != "")
                {
                    if (int.TryParse(textBox_addPrice.Text, out price))
                    {
                        var query = $"insert into products (P_Name, Grade, PricePerUnit, MeasureUnit) values ('{name}','{grade}','{price}', '{measure}')";

                        var command = new SqlCommand(query, database.getConnection());
                        command.ExecuteNonQuery();

                        MessageBox.Show("Создана новая запись", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Цена не является числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            

            database.closeConnection();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string search = $"select * from products where concat (P_Name, Grade, PricePerUnit, MeasureUnit) like '%" + textBox_search.Text + "%'";
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
            var grade = textBox_grade.Text;
            var measure = textBox_measure.Text;
            int price;

            if (name != "" && grade != "" && measure != "")
            {
                if (int.TryParse(textBox_price.Text, out price))
                {
                    DialogResult result = MessageBox.Show("Изменить запись?","Подтверждение", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        var query = $"update products set Grade='{grade}', PricePerUnit='{price}', MeasureUnit='{measure}' where P_Name='{name}'";

                        var command = new SqlCommand(query, database.getConnection());
                        command.ExecuteNonQuery();

                        MessageBox.Show("Запись изменена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Цена не является числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

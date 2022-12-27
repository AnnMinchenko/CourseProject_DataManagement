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
    public partial class query1 : Form
    {
        DB database = new DB();

        public query1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetValue(3), record.GetValue(4));
        }

        private void query1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("address", "address");
            dataGridView1.Columns.Add("number", "number");
            dataGridView1.Columns.Add("shopName", "shopName");
            dataGridView1.Columns.Add("space", "number");
            dataGridView1.Columns.Add("averageSpace", "averageSpace");
            
            dataGridView1.Rows.Clear();
            string query = "SELECT TOP (100) PERCENT Adress, Number, S_Name, Space, (SELECT AVG(Space) FROM shops) AS AverageSpace FROM shops where space> 500 ORDER BY Adress";
            SqlCommand command = new SqlCommand(query, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }
            reader.Close();
        }
    }
}

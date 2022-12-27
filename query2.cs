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
    public partial class query2 : Form
    {
        DB database = new DB();

        public query2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetValue(3), record.GetValue(4));
        }

        private void query2_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("address", "address");
            dataGridView1.Columns.Add("number", "number");
            dataGridView1.Columns.Add("productName", "productName");
            dataGridView1.Columns.Add("price", "price");
            dataGridView1.Columns.Add("total", "total");

            dataGridView1.Rows.Clear();
            string query = "SELECT TOP (100) PERCENT Adress, Number, P_Name, (cast(PricePerUnit as int) * Amount) AS Price,"+
                      " (SELECT SUM(cast(PricePerUnit as int) * Amount) AS Expr1"+
                      " FROM      products INNER JOIN"+
                                        " storage ON P_Name = Stor_P_Name"+
                      " WHERE(Stor_Adress = Adress)) AS Total"+
" FROM products INNER JOIN"+
                 " storage ON P_Name = Stor_P_Name INNER JOIN"+
                 " shops ON Stor_Adress = Adress"+
" WHERE(Number IN('88006306047', '88001589751'))"+
" ORDER BY Adress, P_Name";
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

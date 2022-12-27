using System;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        string shop;

        public Form1(string shp)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            shop = shp;
        }


        private void btnProduct_Click(object sender, EventArgs e)
        {
            products prd = new products();
            this.Hide();
            prd.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query1 qr1 = new query1();
            this.Hide();
            qr1.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            query2 qr2 = new query2();
            this.Hide();
            qr2.ShowDialog();
            this.Show();
        }

        private void btnShops_Click(object sender, EventArgs e)
        {
            shops shp = new shops(shop);
            this.Hide();
            shp.ShowDialog();
            this.Show();
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            storage str = new storage(shop);
            this.Hide();
            str.ShowDialog();
            this.Show();
        }
    }
}

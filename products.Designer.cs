
namespace DataBase
{
    partial class products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_grade = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_measure = new System.Windows.Forms.TextBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.textBox_addMeasure = new System.Windows.Forms.TextBox();
            this.textBox_addPrice = new System.Windows.Forms.TextBox();
            this.textBox_addGrade = new System.Windows.Forms.TextBox();
            this.textBox_addName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsert.Location = new System.Drawing.Point(395, 565);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(191, 30);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Добавить запись";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(174, 565);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(194, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Изменить запись";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(646, 369);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name.Location = new System.Drawing.Point(176, 436);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(192, 23);
            this.textBox_name.TabIndex = 6;
            // 
            // textBox_grade
            // 
            this.textBox_grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_grade.Location = new System.Drawing.Point(176, 465);
            this.textBox_grade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_grade.Name = "textBox_grade";
            this.textBox_grade.Size = new System.Drawing.Size(192, 23);
            this.textBox_grade.TabIndex = 7;
            // 
            // textBox_price
            // 
            this.textBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_price.Location = new System.Drawing.Point(176, 494);
            this.textBox_price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(192, 23);
            this.textBox_price.TabIndex = 8;
            // 
            // textBox_measure
            // 
            this.textBox_measure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_measure.Location = new System.Drawing.Point(176, 523);
            this.textBox_measure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_measure.Name = "textBox_measure";
            this.textBox_measure.Size = new System.Drawing.Size(192, 23);
            this.textBox_measure.TabIndex = 9;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(460, 20);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(196, 20);
            this.textBox_search.TabIndex = 10;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(9, 15);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 28);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // textBox_addMeasure
            // 
            this.textBox_addMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_addMeasure.Location = new System.Drawing.Point(395, 523);
            this.textBox_addMeasure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_addMeasure.Name = "textBox_addMeasure";
            this.textBox_addMeasure.Size = new System.Drawing.Size(192, 23);
            this.textBox_addMeasure.TabIndex = 15;
            // 
            // textBox_addPrice
            // 
            this.textBox_addPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_addPrice.Location = new System.Drawing.Point(395, 494);
            this.textBox_addPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_addPrice.Name = "textBox_addPrice";
            this.textBox_addPrice.Size = new System.Drawing.Size(192, 23);
            this.textBox_addPrice.TabIndex = 14;
            // 
            // textBox_addGrade
            // 
            this.textBox_addGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_addGrade.Location = new System.Drawing.Point(395, 465);
            this.textBox_addGrade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_addGrade.Name = "textBox_addGrade";
            this.textBox_addGrade.Size = new System.Drawing.Size(192, 23);
            this.textBox_addGrade.TabIndex = 13;
            // 
            // textBox_addName
            // 
            this.textBox_addName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_addName.Location = new System.Drawing.Point(395, 436);
            this.textBox_addName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_addName.Name = "textBox_addName";
            this.textBox_addName.Size = new System.Drawing.Size(192, 23);
            this.textBox_addName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(400, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Поиск:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 434);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(46, 520);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ед. измерения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(73, 491);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Цена за ед.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(116, 463);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Сорт";
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 614);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_addMeasure);
            this.Controls.Add(this.textBox_addPrice);
            this.Controls.Add(this.textBox_addGrade);
            this.Controls.Add(this.textBox_addName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.textBox_measure);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_grade);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "products";
            this.Text = "products";
            this.Load += new System.EventHandler(this.products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_grade;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_measure;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox textBox_addMeasure;
        private System.Windows.Forms.TextBox textBox_addPrice;
        private System.Windows.Forms.TextBox textBox_addGrade;
        private System.Windows.Forms.TextBox textBox_addName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
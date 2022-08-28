namespace updateform
{
    partial class search
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.objectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectName,
            this.price,
            this.count,
            this.number,
            this.inventoryNumber,
            this.date,
            this.productType});
            this.dataGridView3.Location = new System.Drawing.Point(12, 101);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(621, 211);
            this.dataGridView3.TabIndex = 0;
            // 
            // objectName
            // 
            this.objectName.HeaderText = "objectName";
            this.objectName.MinimumWidth = 6;
            this.objectName.Name = "objectName";
            this.objectName.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // count
            // 
            this.count.HeaderText = "count";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.Width = 125;
            // 
            // number
            // 
            this.number.HeaderText = "number";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.Width = 125;
            // 
            // inventoryNumber
            // 
            this.inventoryNumber.HeaderText = "inventoryNumber";
            this.inventoryNumber.MinimumWidth = 6;
            this.inventoryNumber.Name = "inventoryNumber";
            this.inventoryNumber.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // productType
            // 
            this.productType.HeaderText = "productType";
            this.productType.MinimumWidth = 6;
            this.productType.Name = "productType";
            this.productType.Width = 125;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(12, 24);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(101, 20);
            this.Name.TabIndex = 1;
            this.Name.Text = "productName";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(264, 27);
            this.textBox3.TabIndex = 2;
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(472, 22);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(75, 23);
            this.tbsearch.TabIndex = 3;
            this.tbsearch.Text = "search";
            this.tbsearch.UseVisualStyleBackColor = true;
            this.tbsearch.Click += new System.EventHandler(this.tbsearch_Click);
            // 
            // search
            // 
            this.ClientSize = new System.Drawing.Size(645, 324);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.dataGridView3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            // this.Name = "search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private DataGridView dataGridView1;
        
        private Label label1;
        private TextBox textBox1;
        private Button searchbttn;
        
        private DataGridViewTextBoxColumn objectName2;
        private Label prodname;
        private TextBox textBox2;
        private Button button1;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn objectName;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn count;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn inventoryNumber;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn productType;
        private Label Name;
        private TextBox textBox3;
        private Button tbsearch;

        public DataGridViewCellEventHandler dataGridView3_CellContentClick { get; private set; }
    }
}
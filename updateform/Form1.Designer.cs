namespace updateform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Number = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.inv_num = new System.Windows.Forms.Label();
            this.obj_name = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.tbinvnum = new System.Windows.Forms.TextBox();
            this.tbnum = new System.Windows.Forms.TextBox();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.tbcount = new System.Windows.Forms.TextBox();
            this.tbobjName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DGV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number.Location = new System.Drawing.Point(27, 49);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(84, 28);
            this.Number.TabIndex = 0;
            this.Number.Text = "Number";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.Location = new System.Drawing.Point(206, 49);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(53, 28);
            this.date.TabIndex = 1;
            this.date.Text = "Date";
            // 
            // inv_num
            // 
            this.inv_num.AutoSize = true;
            this.inv_num.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inv_num.Location = new System.Drawing.Point(477, 49);
            this.inv_num.Name = "inv_num";
            this.inv_num.Size = new System.Drawing.Size(172, 28);
            this.inv_num.TabIndex = 2;
            this.inv_num.Text = "Inventory Number";
            // 
            // obj_name
            // 
            this.obj_name.AutoSize = true;
            this.obj_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.obj_name.Location = new System.Drawing.Point(27, 128);
            this.obj_name.Name = "obj_name";
            this.obj_name.Size = new System.Drawing.Size(125, 28);
            this.obj_name.TabIndex = 3;
            this.obj_name.Text = "object name ";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count.Location = new System.Drawing.Point(27, 220);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(62, 28);
            this.count.TabIndex = 4;
            this.count.Text = "count";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.Location = new System.Drawing.Point(221, 220);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(55, 28);
            this.price.TabIndex = 5;
            this.price.Text = "price";
            this.price.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbinvnum
            // 
            this.tbinvnum.Location = new System.Drawing.Point(477, 85);
            this.tbinvnum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbinvnum.Name = "tbinvnum";
            this.tbinvnum.Size = new System.Drawing.Size(244, 27);
            this.tbinvnum.TabIndex = 6;
            this.tbinvnum.TextChanged += new System.EventHandler(this.tbinvnum_TextChanged);
            // 
            // tbnum
            // 
            this.tbnum.Location = new System.Drawing.Point(27, 85);
            this.tbnum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(138, 27);
            this.tbnum.TabIndex = 7;
            this.tbnum.TextChanged += new System.EventHandler(this.tbnum_TextChanged);
            // 
            // tbprice
            // 
            this.tbprice.Location = new System.Drawing.Point(221, 268);
            this.tbprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(114, 27);
            this.tbprice.TabIndex = 8;
            // 
            // tbcount
            // 
            this.tbcount.Location = new System.Drawing.Point(27, 268);
            this.tbcount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbcount.Name = "tbcount";
            this.tbcount.Size = new System.Drawing.Size(114, 27);
            this.tbcount.TabIndex = 9;
            // 
            // tbobjName
            // 
            this.tbobjName.Location = new System.Drawing.Point(27, 173);
            this.tbobjName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbobjName.Name = "tbobjName";
            this.tbobjName.Size = new System.Drawing.Size(531, 27);
            this.tbobjName.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(206, 85);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 27);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(426, 548);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(592, 548);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(27, 319);
            this.DGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 25;
            this.DGV.Size = new System.Drawing.Size(801, 200);
            this.DGV.TabIndex = 14;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "current user";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(757, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "product category";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(757, 92);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 24);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "food";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(598, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "product type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(784, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "availability";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(806, 180);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(105, 24);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "is available";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(613, 179);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 24);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "variable";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(614, 220);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 24);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "simple";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbobjName);
            this.Controls.Add(this.tbcount);
            this.Controls.Add(this.tbprice);
            this.Controls.Add(this.tbnum);
            this.Controls.Add(this.tbinvnum);
            this.Controls.Add(this.price);
            this.Controls.Add(this.count);
            this.Controls.Add(this.obj_name);
            this.Controls.Add(this.inv_num);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label Number;
        private Label date;
        private Label inv_num;
        private Label obj_name;
        private Label count;
        private Label price;
        private TextBox tbinvnum;
        private TextBox tbnum;
        private TextBox tbprice;
        private TextBox tbcount;
        private TextBox tbobjName;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private ErrorProvider errorProvider1;
        private DataGridView DGV;
        private Label label7;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox checkBox2;
        private Label label10;
        private Label label9;
        private CheckBox checkBox1;
        private Label label8;
    }
}
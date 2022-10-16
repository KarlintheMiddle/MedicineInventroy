namespace Medicine_Inventory
{
    partial class formHCInitialBalance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxHealthCenter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxMedicine = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 52);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health Center Initial Balance Setup";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Health Center:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboxHealthCenter
            // 
            this.cboxHealthCenter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxHealthCenter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxHealthCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxHealthCenter.FormattingEnabled = true;
            this.cboxHealthCenter.Items.AddRange(new object[] {
            "Almanza 1",
            "Balagtas",
            "Basa",
            "Bernabe",
            "BF Carnival",
            "Caa-A",
            "Caa-B",
            "Caa-C",
            "Caa-D",
            "Daniel Fajardo",
            "Elias Aldana",
            "Gatchalian",
            "Golden Acres",
            "Ilaya",
            "Manuyo 1",
            "Pamplona 1",
            "Pamplona 2",
            "Pamplona 3",
            "Pilar",
            "Pugad Lawin",
            "Pulang Lupa 1",
            "Pulang Lupa 2",
            "Talon 1",
            "Talon 2",
            "Talon 3",
            "Talon 4",
            "Talon 5",
            "TS Cruz",
            "Urbanville",
            "Zapote"});
            this.cboxHealthCenter.Location = new System.Drawing.Point(149, 101);
            this.cboxHealthCenter.Name = "cboxHealthCenter";
            this.cboxHealthCenter.Size = new System.Drawing.Size(290, 28);
            this.cboxHealthCenter.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 43);
            this.label3.TabIndex = 3;
            this.label3.Text = "Medicine:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboxMedicine
            // 
            this.cboxMedicine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMedicine.FormattingEnabled = true;
            this.cboxMedicine.Location = new System.Drawing.Point(149, 226);
            this.cboxMedicine.Name = "cboxMedicine";
            this.cboxMedicine.Size = new System.Drawing.Size(290, 28);
            this.cboxMedicine.TabIndex = 4;
            this.cboxMedicine.SelectedIndexChanged += new System.EventHandler(this.cboxMedicine_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 43);
            this.label4.TabIndex = 5;
            this.label4.Text = "Initial Balance:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(149, 271);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(290, 26);
            this.numericUpDown1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = "Expiry Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 316);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(290, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(470, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(402, 616);
            this.dataGridView1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(423, 38);
            this.label6.TabIndex = 9;
            this.label6.Text = "Add Medicine";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formHCInitialBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(884, 722);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboxHealthCenter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxMedicine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "formHCInitialBalance";
            this.Text = "formHCInitialBalance";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxHealthCenter;
        private System.Windows.Forms.ComboBox cboxMedicine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
    }
}
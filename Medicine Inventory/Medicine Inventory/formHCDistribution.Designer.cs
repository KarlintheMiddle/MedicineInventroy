namespace Medicine_Inventory
{
    partial class formHCDistribution
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Distributed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HealthCenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numDist = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMedicineDist = new System.Windows.Forms.ComboBox();
            this.dtpDateDist = new System.Windows.Forms.DateTimePicker();
            this.comboBoxHealthCenterDist = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "Health Center Distribution";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 61);
            this.panel1.TabIndex = 4;
            // 
            // Distributed
            // 
            this.Distributed.FillWeight = 30F;
            this.Distributed.HeaderText = "Distributed";
            this.Distributed.Name = "Distributed";
            // 
            // Medicine
            // 
            this.Medicine.HeaderText = "Medicine";
            this.Medicine.Name = "Medicine";
            // 
            // HealthCenter
            // 
            this.HealthCenter.FillWeight = 75F;
            this.HealthCenter.HeaderText = "Health Center";
            this.HealthCenter.Name = "HealthCenter";
            // 
            // Date
            // 
            this.Date.FillWeight = 40F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.HealthCenter,
            this.Medicine,
            this.Distributed});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(86, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(726, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.07438F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.92562F));
            this.tableLayoutPanel2.Controls.Add(this.comboBoxMedicineDist, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.numDist, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(86, 171);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.73494F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.26506F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(726, 83);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxHealthCenterDist, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpDateDist, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(86, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 83);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // numDist
            // 
            this.numDist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDist.Location = new System.Drawing.Point(519, 31);
            this.numDist.Name = "numDist";
            this.numDist.Size = new System.Drawing.Size(204, 26);
            this.numDist.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(519, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Distributed:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(510, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medicine:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // comboBoxMedicineDist
            // 
            this.comboBoxMedicineDist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMedicineDist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMedicineDist.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxMedicineDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMedicineDist.FormattingEnabled = true;
            this.comboBoxMedicineDist.Items.AddRange(new object[] {
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
            this.comboBoxMedicineDist.Location = new System.Drawing.Point(3, 31);
            this.comboBoxMedicineDist.Name = "comboBoxMedicineDist";
            this.comboBoxMedicineDist.Size = new System.Drawing.Size(510, 28);
            this.comboBoxMedicineDist.TabIndex = 4;
            // 
            // dtpDateDist
            // 
            this.dtpDateDist.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpDateDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateDist.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDist.Location = new System.Drawing.Point(366, 36);
            this.dtpDateDist.Name = "dtpDateDist";
            this.dtpDateDist.Size = new System.Drawing.Size(357, 26);
            this.dtpDateDist.TabIndex = 4;
            // 
            // comboBoxHealthCenterDist
            // 
            this.comboBoxHealthCenterDist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxHealthCenterDist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxHealthCenterDist.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxHealthCenterDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHealthCenterDist.FormattingEnabled = true;
            this.comboBoxHealthCenterDist.Items.AddRange(new object[] {
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
            this.comboBoxHealthCenterDist.Location = new System.Drawing.Point(3, 36);
            this.comboBoxHealthCenterDist.Name = "comboBoxHealthCenterDist";
            this.comboBoxHealthCenterDist.Size = new System.Drawing.Size(357, 28);
            this.comboBoxHealthCenterDist.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Health Center:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(366, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // formHCDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(884, 722);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "formHCDistribution";
            this.Text = "HCDistribution";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distributed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn HealthCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBoxMedicineDist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDist;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxHealthCenterDist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateDist;
    }
}
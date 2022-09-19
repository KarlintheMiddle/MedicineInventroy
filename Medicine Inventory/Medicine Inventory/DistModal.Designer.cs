namespace Medicine_Inventory
{
    partial class DistModal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxDistModalHCSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDistTrans = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthcenterCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distributedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirydateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cboxDistModalHCSelect);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 0;
            // 
            // cboxDistModalHCSelect
            // 
            this.cboxDistModalHCSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxDistModalHCSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxDistModalHCSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxDistModalHCSelect.FormattingEnabled = true;
            this.cboxDistModalHCSelect.Items.AddRange(new object[] {
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
            this.cboxDistModalHCSelect.Location = new System.Drawing.Point(182, 10);
            this.cboxDistModalHCSelect.Name = "cboxDistModalHCSelect";
            this.cboxDistModalHCSelect.Size = new System.Drawing.Size(357, 28);
            this.cboxDistModalHCSelect.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health Center:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDistTrans
            // 
            this.dgvDistTrans.AllowUserToAddRows = false;
            this.dgvDistTrans.AllowUserToDeleteRows = false;
            this.dgvDistTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDistTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteCol,
            this.dateCol,
            this.healthcenterCol,
            this.medicineCol,
            this.priceCol,
            this.distributedCol,
            this.expirydateCol});
            this.dgvDistTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDistTrans.Location = new System.Drawing.Point(0, 44);
            this.dgvDistTrans.Name = "dgvDistTrans";
            this.dgvDistTrans.ReadOnly = true;
            this.dgvDistTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDistTrans.Size = new System.Drawing.Size(800, 625);
            this.dgvDistTrans.TabIndex = 1;
            this.dgvDistTrans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDistTrans_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteCol
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.deleteCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.deleteCol.FillWeight = 35F;
            this.deleteCol.HeaderText = "Delete";
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.ReadOnly = true;
            this.deleteCol.Text = "Delete";
            this.deleteCol.ToolTipText = "Delete";
            this.deleteCol.UseColumnTextForButtonValue = true;
            // 
            // dateCol
            // 
            this.dateCol.DataPropertyName = "Date";
            this.dateCol.FillWeight = 30F;
            this.dateCol.HeaderText = "Date";
            this.dateCol.Name = "dateCol";
            this.dateCol.ReadOnly = true;
            // 
            // healthcenterCol
            // 
            this.healthcenterCol.DataPropertyName = "Health Center";
            this.healthcenterCol.FillWeight = 50F;
            this.healthcenterCol.HeaderText = "Health Center";
            this.healthcenterCol.Name = "healthcenterCol";
            this.healthcenterCol.ReadOnly = true;
            // 
            // medicineCol
            // 
            this.medicineCol.DataPropertyName = "Medicine";
            this.medicineCol.HeaderText = "Medicine";
            this.medicineCol.Name = "medicineCol";
            this.medicineCol.ReadOnly = true;
            // 
            // priceCol
            // 
            this.priceCol.DataPropertyName = "Price";
            this.priceCol.FillWeight = 40F;
            this.priceCol.HeaderText = "Price";
            this.priceCol.Name = "priceCol";
            this.priceCol.ReadOnly = true;
            // 
            // distributedCol
            // 
            this.distributedCol.DataPropertyName = "Distributed";
            this.distributedCol.FillWeight = 30F;
            this.distributedCol.HeaderText = "Distributed";
            this.distributedCol.Name = "distributedCol";
            this.distributedCol.ReadOnly = true;
            // 
            // expirydateCol
            // 
            this.expirydateCol.DataPropertyName = "Expiry Date";
            this.expirydateCol.FillWeight = 30F;
            this.expirydateCol.HeaderText = "Expiry Date";
            this.expirydateCol.Name = "expirydateCol";
            this.expirydateCol.ReadOnly = true;
            // 
            // DistModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 669);
            this.Controls.Add(this.dgvDistTrans);
            this.Controls.Add(this.panel1);
            this.Name = "DistModal";
            this.Text = "Distribution Per Health Center";
            this.Load += new System.EventHandler(this.DistModal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistTrans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDistTrans;
        private System.Windows.Forms.ComboBox cboxDistModalHCSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn deleteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthcenterCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirydateCol;
    }
}
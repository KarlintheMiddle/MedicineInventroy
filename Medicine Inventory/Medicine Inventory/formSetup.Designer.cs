namespace Medicine_Inventory
{
    partial class formSetup
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxItemCodeSetup = new System.Windows.Forms.TextBox();
            this.txtboxSupplierSetup = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numUDIntBalSetup = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numUDPriceSetup = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxMedicineSetup = new System.Windows.Forms.TextBox();
            this.txtboxMedicineID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicineInventoryDataSet = new Medicine_Inventory.MedicineInventoryDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmitSetup = new System.Windows.Forms.Button();
            this.medicineTableAdapter = new Medicine_Inventory.MedicineInventoryDataSetTableAdapters.MedicineTableAdapter();
            this.btnUpdateSetup = new System.Windows.Forms.Button();
            this.btnDeleteSetup = new System.Windows.Forms.Button();
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.medicineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearText = new System.Windows.Forms.Button();
            this.cboxUOMSetup = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDIntBalSetup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPriceSetup)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineInventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.94389F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.05611F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtboxItemCodeSetup, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtboxSupplierSetup, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numUDIntBalSetup, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numUDPriceSetup, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtboxMedicineSetup, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtboxMedicineID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboxUOMSetup, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 183);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(370, 273);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 39);
            this.label9.TabIndex = 0;
            this.label9.Text = "Medicine ID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 39);
            this.label8.TabIndex = 10;
            this.label8.Text = "Item Code:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtboxItemCodeSetup
            // 
            this.txtboxItemCodeSetup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtboxItemCodeSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxItemCodeSetup.Location = new System.Drawing.Point(147, 247);
            this.txtboxItemCodeSetup.Name = "txtboxItemCodeSetup";
            this.txtboxItemCodeSetup.Size = new System.Drawing.Size(220, 23);
            this.txtboxItemCodeSetup.TabIndex = 6;
            // 
            // txtboxSupplierSetup
            // 
            this.txtboxSupplierSetup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtboxSupplierSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSupplierSetup.Location = new System.Drawing.Point(147, 208);
            this.txtboxSupplierSetup.Name = "txtboxSupplierSetup";
            this.txtboxSupplierSetup.Size = new System.Drawing.Size(220, 23);
            this.txtboxSupplierSetup.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 39);
            this.label7.TabIndex = 8;
            this.label7.Text = "Supplier";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "Initial Balance:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numUDIntBalSetup
            // 
            this.numUDIntBalSetup.DecimalPlaces = 2;
            this.numUDIntBalSetup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numUDIntBalSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDIntBalSetup.Location = new System.Drawing.Point(147, 169);
            this.numUDIntBalSetup.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numUDIntBalSetup.Name = "numUDIntBalSetup";
            this.numUDIntBalSetup.Size = new System.Drawing.Size(220, 23);
            this.numUDIntBalSetup.TabIndex = 4;
            this.numUDIntBalSetup.Enter += new System.EventHandler(this.numUDIntBalSetup_Enter);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "Units of Measure:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numUDPriceSetup
            // 
            this.numUDPriceSetup.DecimalPlaces = 2;
            this.numUDPriceSetup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numUDPriceSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDPriceSetup.Location = new System.Drawing.Point(147, 91);
            this.numUDPriceSetup.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numUDPriceSetup.Name = "numUDPriceSetup";
            this.numUDPriceSetup.Size = new System.Drawing.Size(220, 23);
            this.numUDPriceSetup.TabIndex = 2;
            this.numUDPriceSetup.Enter += new System.EventHandler(this.numUDPriceSetup_Enter);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Medicine:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtboxMedicineSetup
            // 
            this.txtboxMedicineSetup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtboxMedicineSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMedicineSetup.Location = new System.Drawing.Point(147, 52);
            this.txtboxMedicineSetup.Name = "txtboxMedicineSetup";
            this.txtboxMedicineSetup.Size = new System.Drawing.Size(220, 23);
            this.txtboxMedicineSetup.TabIndex = 1;
            // 
            // txtboxMedicineID
            // 
            this.txtboxMedicineID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtboxMedicineID.Enabled = false;
            this.txtboxMedicineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMedicineID.Location = new System.Drawing.Point(147, 13);
            this.txtboxMedicineID.Name = "txtboxMedicineID";
            this.txtboxMedicineID.ReadOnly = true;
            this.txtboxMedicineID.Size = new System.Drawing.Size(220, 23);
            this.txtboxMedicineID.TabIndex = 10;
            this.txtboxMedicineID.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 68);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1031, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setup Medicine Inventory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataMember = "Medicine";
            this.medicineBindingSource.DataSource = this.medicineInventoryDataSet;
            // 
            // medicineInventoryDataSet
            // 
            this.medicineInventoryDataSet.DataSetName = "MedicineInventoryDataSet";
            this.medicineInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input Information:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmitSetup
            // 
            this.btnSubmitSetup.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmitSetup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmitSetup.FlatAppearance.BorderSize = 3;
            this.btnSubmitSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitSetup.Location = new System.Drawing.Point(18, 462);
            this.btnSubmitSetup.Name = "btnSubmitSetup";
            this.btnSubmitSetup.Size = new System.Drawing.Size(361, 48);
            this.btnSubmitSetup.TabIndex = 7;
            this.btnSubmitSetup.Text = "Submit";
            this.btnSubmitSetup.UseVisualStyleBackColor = false;
            this.btnSubmitSetup.Click += new System.EventHandler(this.btnSubmitSetup_Click);
            // 
            // medicineTableAdapter
            // 
            this.medicineTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdateSetup
            // 
            this.btnUpdateSetup.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateSetup.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnUpdateSetup.FlatAppearance.BorderSize = 3;
            this.btnUpdateSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSetup.Location = new System.Drawing.Point(18, 516);
            this.btnUpdateSetup.Name = "btnUpdateSetup";
            this.btnUpdateSetup.Size = new System.Drawing.Size(361, 48);
            this.btnUpdateSetup.TabIndex = 8;
            this.btnUpdateSetup.Text = "Update";
            this.btnUpdateSetup.UseVisualStyleBackColor = false;
            this.btnUpdateSetup.Click += new System.EventHandler(this.btnUpdateSetup_Click);
            // 
            // btnDeleteSetup
            // 
            this.btnDeleteSetup.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteSetup.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteSetup.FlatAppearance.BorderSize = 3;
            this.btnDeleteSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSetup.Location = new System.Drawing.Point(18, 570);
            this.btnDeleteSetup.Name = "btnDeleteSetup";
            this.btnDeleteSetup.Size = new System.Drawing.Size(361, 48);
            this.btnDeleteSetup.TabIndex = 9;
            this.btnDeleteSetup.Text = "Delete";
            this.btnDeleteSetup.UseVisualStyleBackColor = false;
            this.btnDeleteSetup.Click += new System.EventHandler(this.btnDeleteSetup_Click);
            // 
            // dgvMedicine
            // 
            this.dgvMedicine.AllowUserToAddRows = false;
            this.dgvMedicine.AllowUserToDeleteRows = false;
            this.dgvMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicine.AutoGenerateColumns = false;
            this.dgvMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicineIDDataGridViewTextBoxColumn,
            this.medicineDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.uOMDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.itemCodeDataGridViewTextBoxColumn});
            this.dgvMedicine.DataSource = this.medicineBindingSource;
            this.dgvMedicine.Location = new System.Drawing.Point(388, 81);
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.ReadOnly = true;
            this.dgvMedicine.Size = new System.Drawing.Size(631, 629);
            this.dgvMedicine.TabIndex = 13;
            this.dgvMedicine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicine_CellClick);
            // 
            // medicineIDDataGridViewTextBoxColumn
            // 
            this.medicineIDDataGridViewTextBoxColumn.DataPropertyName = "MedicineID";
            this.medicineIDDataGridViewTextBoxColumn.FillWeight = 20F;
            this.medicineIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.medicineIDDataGridViewTextBoxColumn.Name = "medicineIDDataGridViewTextBoxColumn";
            this.medicineIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicineDataGridViewTextBoxColumn
            // 
            this.medicineDataGridViewTextBoxColumn.DataPropertyName = "Medicine";
            this.medicineDataGridViewTextBoxColumn.HeaderText = "Medicine";
            this.medicineDataGridViewTextBoxColumn.Name = "medicineDataGridViewTextBoxColumn";
            this.medicineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.FillWeight = 30F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uOMDataGridViewTextBoxColumn
            // 
            this.uOMDataGridViewTextBoxColumn.DataPropertyName = "UOM";
            this.uOMDataGridViewTextBoxColumn.FillWeight = 30F;
            this.uOMDataGridViewTextBoxColumn.HeaderText = "UOM";
            this.uOMDataGridViewTextBoxColumn.Name = "uOMDataGridViewTextBoxColumn";
            this.uOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.FillWeight = 40F;
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Bal";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.FillWeight = 50F;
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemCodeDataGridViewTextBoxColumn
            // 
            this.itemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode";
            this.itemCodeDataGridViewTextBoxColumn.FillWeight = 30F;
            this.itemCodeDataGridViewTextBoxColumn.HeaderText = "Item Code";
            this.itemCodeDataGridViewTextBoxColumn.Name = "itemCodeDataGridViewTextBoxColumn";
            this.itemCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnClearText
            // 
            this.btnClearText.Location = new System.Drawing.Point(288, 154);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(91, 23);
            this.btnClearText.TabIndex = 14;
            this.btnClearText.Text = "Clear Fields";
            this.btnClearText.UseVisualStyleBackColor = true;
            this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // cboxUOMSetup
            // 
            this.cboxUOMSetup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxUOMSetup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxUOMSetup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboxUOMSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxUOMSetup.FormattingEnabled = true;
            this.cboxUOMSetup.Items.AddRange(new object[] {
            "btls.",
            "bxs.",
            "nebule",
            "pcs.",
            "units",
            "cycle",
            "vial"});
            this.cboxUOMSetup.Location = new System.Drawing.Point(147, 132);
            this.cboxUOMSetup.Name = "cboxUOMSetup";
            this.cboxUOMSetup.Size = new System.Drawing.Size(220, 24);
            this.cboxUOMSetup.TabIndex = 3;
            // 
            // formSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1031, 722);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMedicine);
            this.Controls.Add(this.btnDeleteSetup);
            this.Controls.Add(this.btnUpdateSetup);
            this.Controls.Add(this.btnSubmitSetup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "formSetup";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.formSetup_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDIntBalSetup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPriceSetup)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineInventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxMedicineSetup;
        private System.Windows.Forms.NumericUpDown numUDPriceSetup;
        private System.Windows.Forms.NumericUpDown numUDIntBalSetup;
        private System.Windows.Forms.TextBox txtboxSupplierSetup;
        private System.Windows.Forms.TextBox txtboxItemCodeSetup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmitSetup;
        private MedicineInventoryDataSet medicineInventoryDataSet;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private MedicineInventoryDataSetTableAdapters.MedicineTableAdapter medicineTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtboxMedicineID;
        private System.Windows.Forms.Button btnUpdateSetup;
        private System.Windows.Forms.Button btnDeleteSetup;
        private System.Windows.Forms.DataGridView dgvMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClearText;
        private System.Windows.Forms.ComboBox cboxUOMSetup;
    }
}
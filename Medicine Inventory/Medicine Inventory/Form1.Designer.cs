namespace Medicine_Inventory
{
    partial class Form1
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
            this.pnlSideMenuBar = new System.Windows.Forms.Panel();
            this.pnlTransactionSubMenu = new System.Windows.Forms.Panel();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHCDistribution = new System.Windows.Forms.Button();
            this.btnHCUtilization = new System.Windows.Forms.Button();
            this.btnPurchased = new System.Windows.Forms.Button();
            this.btnOthers = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.pnlReportSubMenu = new System.Windows.Forms.Panel();
            this.btnHOInventory = new System.Windows.Forms.Button();
            this.btnHCInventory = new System.Windows.Forms.Button();
            this.btnAccountReport = new System.Windows.Forms.Button();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlSideMenuBar.SuspendLayout();
            this.pnlTransactionSubMenu.SuspendLayout();
            this.pnlReportSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenuBar
            // 
            this.pnlSideMenuBar.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlSideMenuBar.Controls.Add(this.pnlReportSubMenu);
            this.pnlSideMenuBar.Controls.Add(this.btnReports);
            this.pnlSideMenuBar.Controls.Add(this.pnlTransactionSubMenu);
            this.pnlSideMenuBar.Controls.Add(this.btnTransaction);
            this.pnlSideMenuBar.Controls.Add(this.panel1);
            this.pnlSideMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenuBar.Name = "pnlSideMenuBar";
            this.pnlSideMenuBar.Size = new System.Drawing.Size(284, 761);
            this.pnlSideMenuBar.TabIndex = 0;
            // 
            // pnlTransactionSubMenu
            // 
            this.pnlTransactionSubMenu.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlTransactionSubMenu.Controls.Add(this.btnOthers);
            this.pnlTransactionSubMenu.Controls.Add(this.btnPurchased);
            this.pnlTransactionSubMenu.Controls.Add(this.btnHCUtilization);
            this.pnlTransactionSubMenu.Controls.Add(this.btnHCDistribution);
            this.pnlTransactionSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTransactionSubMenu.Location = new System.Drawing.Point(0, 215);
            this.pnlTransactionSubMenu.Name = "pnlTransactionSubMenu";
            this.pnlTransactionSubMenu.Size = new System.Drawing.Size(284, 201);
            this.pnlTransactionSubMenu.TabIndex = 2;
            // 
            // btnTransaction
            // 
            this.btnTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.Snow;
            this.btnTransaction.Location = new System.Drawing.Point(0, 169);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTransaction.Size = new System.Drawing.Size(284, 46);
            this.btnTransaction.TabIndex = 1;
            this.btnTransaction.Text = "Transactions";
            this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 169);
            this.panel1.TabIndex = 0;
            // 
            // btnHCDistribution
            // 
            this.btnHCDistribution.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHCDistribution.FlatAppearance.BorderSize = 0;
            this.btnHCDistribution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHCDistribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHCDistribution.ForeColor = System.Drawing.Color.Snow;
            this.btnHCDistribution.Location = new System.Drawing.Point(0, 0);
            this.btnHCDistribution.Name = "btnHCDistribution";
            this.btnHCDistribution.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHCDistribution.Size = new System.Drawing.Size(284, 46);
            this.btnHCDistribution.TabIndex = 3;
            this.btnHCDistribution.Text = "Health Center Distribution";
            this.btnHCDistribution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHCDistribution.UseVisualStyleBackColor = true;
            this.btnHCDistribution.Click += new System.EventHandler(this.btnHCDistribution_Click);
            // 
            // btnHCUtilization
            // 
            this.btnHCUtilization.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHCUtilization.FlatAppearance.BorderSize = 0;
            this.btnHCUtilization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHCUtilization.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHCUtilization.ForeColor = System.Drawing.Color.Snow;
            this.btnHCUtilization.Location = new System.Drawing.Point(0, 46);
            this.btnHCUtilization.Name = "btnHCUtilization";
            this.btnHCUtilization.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHCUtilization.Size = new System.Drawing.Size(284, 46);
            this.btnHCUtilization.TabIndex = 4;
            this.btnHCUtilization.Text = "Health Center Utilization";
            this.btnHCUtilization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHCUtilization.UseVisualStyleBackColor = true;
            this.btnHCUtilization.Click += new System.EventHandler(this.btnHCUtilization_Click);
            // 
            // btnPurchased
            // 
            this.btnPurchased.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchased.FlatAppearance.BorderSize = 0;
            this.btnPurchased.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchased.ForeColor = System.Drawing.Color.Snow;
            this.btnPurchased.Location = new System.Drawing.Point(0, 92);
            this.btnPurchased.Name = "btnPurchased";
            this.btnPurchased.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPurchased.Size = new System.Drawing.Size(284, 46);
            this.btnPurchased.TabIndex = 5;
            this.btnPurchased.Text = "Purchase Order";
            this.btnPurchased.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchased.UseVisualStyleBackColor = true;
            this.btnPurchased.Click += new System.EventHandler(this.btnPurchased_Click);
            // 
            // btnOthers
            // 
            this.btnOthers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOthers.FlatAppearance.BorderSize = 0;
            this.btnOthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOthers.ForeColor = System.Drawing.Color.Snow;
            this.btnOthers.Location = new System.Drawing.Point(0, 138);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnOthers.Size = new System.Drawing.Size(284, 46);
            this.btnOthers.TabIndex = 6;
            this.btnOthers.Text = "Others";
            this.btnOthers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOthers.UseVisualStyleBackColor = true;
            this.btnOthers.Click += new System.EventHandler(this.btnOthers_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.Snow;
            this.btnReports.Location = new System.Drawing.Point(0, 416);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(284, 46);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // pnlReportSubMenu
            // 
            this.pnlReportSubMenu.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlReportSubMenu.Controls.Add(this.btnHOInventory);
            this.pnlReportSubMenu.Controls.Add(this.btnHCInventory);
            this.pnlReportSubMenu.Controls.Add(this.btnAccountReport);
            this.pnlReportSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportSubMenu.Location = new System.Drawing.Point(0, 462);
            this.pnlReportSubMenu.Name = "pnlReportSubMenu";
            this.pnlReportSubMenu.Size = new System.Drawing.Size(284, 201);
            this.pnlReportSubMenu.TabIndex = 4;
            // 
            // btnHOInventory
            // 
            this.btnHOInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHOInventory.FlatAppearance.BorderSize = 0;
            this.btnHOInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHOInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHOInventory.ForeColor = System.Drawing.Color.Snow;
            this.btnHOInventory.Location = new System.Drawing.Point(0, 92);
            this.btnHOInventory.Name = "btnHOInventory";
            this.btnHOInventory.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHOInventory.Size = new System.Drawing.Size(284, 46);
            this.btnHOInventory.TabIndex = 5;
            this.btnHOInventory.Text = "Health Office Inventory";
            this.btnHOInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHOInventory.UseVisualStyleBackColor = true;
            this.btnHOInventory.Click += new System.EventHandler(this.btnHOInventory_Click);
            // 
            // btnHCInventory
            // 
            this.btnHCInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHCInventory.FlatAppearance.BorderSize = 0;
            this.btnHCInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHCInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHCInventory.ForeColor = System.Drawing.Color.Snow;
            this.btnHCInventory.Location = new System.Drawing.Point(0, 46);
            this.btnHCInventory.Name = "btnHCInventory";
            this.btnHCInventory.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHCInventory.Size = new System.Drawing.Size(284, 46);
            this.btnHCInventory.TabIndex = 4;
            this.btnHCInventory.Text = "Health Center Inventory";
            this.btnHCInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHCInventory.UseVisualStyleBackColor = true;
            this.btnHCInventory.Click += new System.EventHandler(this.btnHCInventory_Click);
            // 
            // btnAccountReport
            // 
            this.btnAccountReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccountReport.FlatAppearance.BorderSize = 0;
            this.btnAccountReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountReport.ForeColor = System.Drawing.Color.Snow;
            this.btnAccountReport.Location = new System.Drawing.Point(0, 0);
            this.btnAccountReport.Name = "btnAccountReport";
            this.btnAccountReport.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAccountReport.Size = new System.Drawing.Size(284, 46);
            this.btnAccountReport.TabIndex = 3;
            this.btnAccountReport.Text = "Monthly Accounting Report";
            this.btnAccountReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountReport.UseVisualStyleBackColor = true;
            this.btnAccountReport.Click += new System.EventHandler(this.btnAccountReport_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(284, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(900, 761);
            this.pnlChildForm.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlSideMenuBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlSideMenuBar.ResumeLayout(false);
            this.pnlTransactionSubMenu.ResumeLayout(false);
            this.pnlReportSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenuBar;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTransactionSubMenu;
        private System.Windows.Forms.Button btnOthers;
        private System.Windows.Forms.Button btnPurchased;
        private System.Windows.Forms.Button btnHCUtilization;
        private System.Windows.Forms.Button btnHCDistribution;
        private System.Windows.Forms.Panel pnlReportSubMenu;
        private System.Windows.Forms.Button btnHOInventory;
        private System.Windows.Forms.Button btnHCInventory;
        private System.Windows.Forms.Button btnAccountReport;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel pnlChildForm;
    }
}


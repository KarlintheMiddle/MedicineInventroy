using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;

namespace Medicine_Inventory
{
    public partial class formHCDistribution : Form
    {
        #region SQL Variable Declarations
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;

        #endregion
        DataTable dt = new DataTable();

        public formHCDistribution()
        {
            InitializeComponent();
           
        }

        private void formHCDistribution_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\MedicineInventory.mdf;Integrated Security=True");

            populateComboBox();
            

            //create a datatable

            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Health Center", typeof(string));
            dt.Columns.Add("Medicine", typeof(string));
            dt.Columns.Add("Distributed", typeof(float));
            dt.Columns.Add("Price", typeof(float));
            dt.Columns.Add("Expiry Date", typeof(string));

            dataGridView1.DataSource = dt;
            dt.AcceptChanges();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].FillWeight = 40;
            dataGridView1.Columns[1].FillWeight = 50;
            dataGridView1.Columns[2].FillWeight = 100;
            dataGridView1.Columns[3].FillWeight = 30;
            dataGridView1.Columns[4].FillWeight = 30;
            dataGridView1.Columns[5].FillWeight = 40;
        }

        #region Methods and Classes
        
        //Populate the combobox with Medicines
        private void populateComboBox()
        {
            cn.Open();
            string insertQuery = "Select Medicine from Medicine";
            cmd = new SqlCommand(insertQuery, cn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBoxMedicineDist.Items.Add(reader[0].ToString());

            }
            cn.Close();
        }

        //Populate the combobox with Prices
        private void populateNumPrice()
        {
            cn.Open();

            string priceSelect = "Select Price from Medicine WHERE Medicine = @medicine";
            cmd = new SqlCommand(priceSelect, cn);
            cmd.Parameters.Add("@medicine", SqlDbType.NVarChar).Value = comboBoxMedicineDist.Text;

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                numPrice.Items.Add(reader[0].ToString());

            }
            cn.Close();
        }

        //Auto focus when selecting Numbers
        private void numSelector(NumericUpDown num)
        {
            num.Select(0, num.Text.Length);
        }

        //Generate Datatable for DataGridView
        private void addDataTable()
        {

            DataRow _Transaction = dt.NewRow();
            _Transaction["Date"] = dtpDateDist.Text;
            _Transaction["Health Center"] = comboBoxHealthCenterDist.Text;
            _Transaction["Medicine"] = comboBoxMedicineDist.Text;
            _Transaction["Distributed"] = numDist.Value;
            _Transaction["Price"] = numPrice.Text;
            _Transaction["Expiry Date"] = dtpExpiryDate.Text;

            dt.Rows.Add(_Transaction);

        }

        //Submits the input data on the SQL Database
        private void submitToDatabase(string tableName, DataTable dataTable)
        {
            cn.Open();
            try
            {

                SqlBulkCopy bulkCopy = new SqlBulkCopy(cn);
                bulkCopy.DestinationTableName = tableName;
                bulkCopy.WriteToServer(dataTable);

                MessageBox.Show("Added to database");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        //Array List Class for all the Medicine and their UOM
        public class BarangayInventory
        {
            public string Medicine { get; set; }
            public string UOM { get; set; }
        }

        //Open Select Folder Dialog box
        private void SelectFilePath()
        {
            string selectedPath;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Custom Description";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedPath = dialog.SelectedPath;
                generateReport(selectedPath);



            }

        }

        //Add all the Distributed per Medicine, Barangay and Date
        private decimal GetSumDistributed(string medicineName)
        {
            try
            {


                string insertQuery = "SELECT sum(Distribute) FROM DistributionTransaction WHERE Medicine = @medicine AND Date = @date AND [Health Center] = @hc";

                using (cmd = new SqlCommand(insertQuery, cn))
                {

                    cmd.Parameters.Add("@medicine", SqlDbType.NVarChar).Value = medicineName;
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = dtpDateDist.Text;
                    cmd.Parameters.Add("hc", SqlDbType.NVarChar).Value = comboBoxHealthCenterDist.Text;

                    object result = cmd.ExecuteScalar();
                    if (!(result is DBNull))
                    {
                        return Convert.ToDecimal(result);

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

            return 0;
        }
        #endregion

        
        #region Controls Functions
        private void numPrice_Enter(object sender, EventArgs e)
        {
            numPrice.Items.Clear();
            populateNumPrice();
        }



        private void numDist_Enter(Object sender, EventArgs eventArgs)
        {
            numSelector(numDist);
        }

        
       

        private void btnAddToList_Click(object sender, EventArgs e)
        {
           if (comboBoxHealthCenterDist.Text == "")
            {
                MessageBox.Show("Health Center Missing!");
                comboBoxMedicineDist.Focus();
            }
           else if (comboBoxMedicineDist.Text == "")
            {
                MessageBox.Show("Medicine Missing!");
                comboBoxMedicineDist.Focus();
            }
           else if (numPrice.Text == "")
            {
                MessageBox.Show("Please put Valid Price!");
                comboBoxMedicineDist.Focus();
            }
           else
           {
                addDataTable();
                comboBoxMedicineDist.Text = "";
                numDist.Value = 0;
                numPrice.Text = "";
                dtpExpiryDate.Text = "";

                comboBoxMedicineDist.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string dbName = "DistributionTransaction";
            submitToDatabase(dbName, dt);
            cn.Close();
        }

        private void btnShowTrans_Click(object sender, EventArgs e)
        {
            DistModal distModal = new DistModal();

            distModal.getHealthCenter = comboBoxHealthCenterDist.Text;
            distModal.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            cn.Open();
            SelectFilePath();
            cn.Close();
        }



        #endregion




        #region PDFSharp
        private void generateReport(string filePath)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            try
            {


                //New Document
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Medicine Report";


                //New page
                PdfPage page = document.AddPage();
                page.Width = XUnit.FromInch(13);
                page.Height = XUnit.FromInch(8.5);
                

                //Provide methods for drawing in pages
                XGraphics gfx = XGraphics.FromPdfPage(page);

                //Font
                XFont titleFont = new XFont("Arial", 13, XFontStyle.Bold);
                XFont headerFont = new XFont("Arial", 11, XFontStyle.Bold);
               



                //Generate Report Title
                gfx.DrawString("Medicine Distribution Report", titleFont, XBrushes.Black, new XPoint(20, 30));
                gfx.DrawString(comboBoxHealthCenterDist.Text, titleFont, XBrushes.Black, new XPoint(20, 45));
                gfx.DrawString(dtpDateDist.Value.ToString("MMM-dd-yyyy"), titleFont, XBrushes.Black, new XPoint(800, 45));
                gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black)), new XPoint(20, 48), new XPoint(916, 48));



                //Generate Table Header
                gfx.DrawString("Medicine", headerFont, XBrushes.Black, new XPoint(20, 65));
                gfx.DrawString("UOM", headerFont, XBrushes.Black, new XPoint(305, 65));
                gfx.DrawString("Beg Bal", headerFont, XBrushes.Black, new XPoint(355, 65));
                gfx.DrawString("Received", headerFont, XBrushes.Black, new XPoint(425, 65));
                gfx.DrawString("Exp Date", headerFont, XBrushes.Black, new XPoint(495, 65));
                gfx.DrawString("On Hand", headerFont, XBrushes.Black, new XPoint(565, 65));
                gfx.DrawString("Utilized", headerFont, XBrushes.Black, new XPoint(635, 65));
                gfx.DrawString("End Bal", headerFont, XBrushes.Black, new XPoint(705, 65));
                gfx.DrawString("Remarks", headerFont, XBrushes.Black, new XPoint(775, 65));
                gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black)), new XPoint(20, 70), new XPoint(916, 70));






                //Fill Data
                BarangayInventory[] barangayInventories = null;
                
                string insertQuery = "Select Medicine, UOM from Medicine";
                using (SqlCommand cmd = new SqlCommand(insertQuery, cn))
                {
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        var List = new List<BarangayInventory>();
                        while (reader.Read())
                        {
                            List.Add(new BarangayInventory { Medicine = reader.GetString(0), UOM = reader.GetString(1) });
                            barangayInventories = List.ToArray();
                        }
                        
                    }
                    
                }

                //Per row
                int currentPosition_Value = 83;
                int currentPosition_line = 85;
                int additionPerLine = 15;
                

                for (int i = 0; i <= 30; i++)
                {
                    gfx.DrawString(barangayInventories[i].Medicine, new XFont("Arial", 9, XFontStyle.Regular), XBrushes.Black, new XPoint(20, currentPosition_Value));
                    gfx.DrawString(barangayInventories[i].UOM, new XFont("Arial", 9, XFontStyle.Regular), XBrushes.Black, new XPoint(305, currentPosition_Value));
                    gfx.DrawString("0", new XFont("Arial", 9, XFontStyle.Regular), XBrushes.Black, new XPoint(355, currentPosition_Value));
                    gfx.DrawString(GetSumDistributed(barangayInventories[i].Medicine).ToString(), new XFont("Arial", 9, XFontStyle.Regular), XBrushes.Black, new XPoint(425, currentPosition_Value));

                    gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black)), new XPoint(20, currentPosition_line), new XPoint(916, currentPosition_line));

                    currentPosition_line += additionPerLine;
                    currentPosition_Value += additionPerLine;
                }


                //Signature
                gfx.DrawString("Distributed By:", headerFont, XBrushes.Black, new XPoint(150, 590));
                gfx.DrawString("Received By:", headerFont, XBrushes.Black, new XPoint(450, 590));
                gfx.DrawString("Noted By:", headerFont, XBrushes.Black, new XPoint(750, 590));
                gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black)), new XPoint(50, 575), new XPoint(300, 575));
                gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black)), new XPoint(350, 575), new XPoint(600, 575));
                gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black)), new XPoint(650, 575), new XPoint(900, 575));

               
                //Vertical Line
                gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black)), new XPoint(300, 70), new XPoint(300, currentPosition_line - additionPerLine));//Medicine
                gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black)), new XPoint(350, 70), new XPoint(350, currentPosition_line - additionPerLine));//UOM
                gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black)), new XPoint(420, 70), new XPoint(420, currentPosition_line - additionPerLine));//Beg Bal
                gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black)), new XPoint(490, 70), new XPoint(490, currentPosition_line - additionPerLine));//Received
                gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black)), new XPoint(560, 70), new XPoint(560, currentPosition_line - additionPerLine));//Ex Date
                gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black)), new XPoint(630, 70), new XPoint(630, currentPosition_line - additionPerLine));//On Hand
                gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black)), new XPoint(700, 70), new XPoint(700, currentPosition_line - additionPerLine));//Utilized
                gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black)), new XPoint(770, 70), new XPoint(770, currentPosition_line - additionPerLine));//End Bal
                //gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black)), new XPoint(900, 85), new XPoint(900, 550));//Remarks

                document.Save(filePath + "\\MedicineReport-" + dtpDateDist.Value.ToString("MMM-yyyy") + "-" + comboBoxHealthCenterDist.Text + ".pdf");
                string directory = Path.GetDirectoryName(filePath + "\\MedicineReport-" + dtpDateDist.Value.ToString("MMM-yyyy") + "-" + comboBoxHealthCenterDist.Text + ".pdf");
                if (MessageBox.Show("The file saved at -> " + filePath, "Open Directory?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(directory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }




        #endregion

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Medicine_Inventory
{
    public partial class formSetup : Form
    {
        #region SQL Variable Declarations
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        #endregion

        public formSetup()
        {
            InitializeComponent();
        }

        private void formSetup_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\'D:\\Users\\PC 4\\Documents\\MEDICINE INVENTORY\\Project\\Medicine Inventory\\Medicine Inventory\\MedicineInventory.mdf\';Integrated Security=True");
            cn.Open();
            getMedicineRecord();
            txtboxMedicineSetup.Focus();

        }

        #region Database Functions
        private void getMedicineRecord()
        {
            cmd = new SqlCommand("select * from Medicine ORDER BY MedicineID DESC", cn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvMedicine.DataSource = dt;
        }

        private void saveMedicineRecord()
        {
            string insertQuery = "insert into Medicine ([Medicine],[Price],[UOM],[Balance],[Supplier],[ItemCode]) values (@medicine,@price,@uom,@balance,@supplier,@itemcode)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(insertQuery, cn))
                {   
                    //Create and set parameters value
                    cmd.Parameters.Add("@medicine", SqlDbType.NVarChar).Value = txtboxMedicineSetup.Text;
                    cmd.Parameters.Add("@price", SqlDbType.Money).Value = numUDPriceSetup.Value;
                    cmd.Parameters.Add("@uom", SqlDbType.NChar).Value = cboxUOMSetup.Text;
                    cmd.Parameters.Add("@balance", SqlDbType.Float).Value = numUDIntBalSetup.Value;
                    cmd.Parameters.Add("@supplier", SqlDbType.NVarChar).Value = txtboxSupplierSetup.Text;
                    cmd.Parameters.Add("@itemcode", SqlDbType.NVarChar).Value = txtboxItemCodeSetup.Text;

                    int rowsAdded = cmd.ExecuteNonQuery();
                    if (rowsAdded > 0)
                    {
                        MessageBox.Show("Row Inserted!");
                    }
                    else
                    {
                        MessageBox.Show("No Row Inserted!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void updateMedicineRecord()
        {
            string insertQuery = "Update Medicine set Medicine = @medicine, Price = @price, UOM = @uom, Balance = @balance, Supplier = @supplier, ItemCode = @itemcode where MedicineID = @id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(insertQuery, cn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtboxMedicineID.Text;
                    cmd.Parameters.Add("@medicine", SqlDbType.NVarChar).Value = txtboxMedicineSetup.Text;
                    cmd.Parameters.Add("@price", SqlDbType.Money).Value = numUDPriceSetup.Value;
                    cmd.Parameters.Add("@uom", SqlDbType.NChar).Value = cboxUOMSetup.Text;
                    cmd.Parameters.Add("@balance", SqlDbType.Float).Value = numUDIntBalSetup.Value;
                    cmd.Parameters.Add("@supplier", SqlDbType.NVarChar).Value = txtboxSupplierSetup.Text;
                    cmd.Parameters.Add("@itemcode", SqlDbType.NVarChar).Value = txtboxItemCodeSetup.Text;

                    int rowsAdded = cmd.ExecuteNonQuery();
                    if (rowsAdded > 0)
                    {
                        MessageBox.Show("Row Updated!");
                    }
                    else
                    {
                        MessageBox.Show("No Row Updated!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
        private void deleteMedicineRecord()
        {
            string insertQuery = "DELETE from Medicine where MedicineID = @id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(insertQuery, cn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtboxMedicineID.Text;

                    int rowsAdded = cmd.ExecuteNonQuery();
                    if (rowsAdded > 0)
                    {
                        MessageBox.Show("Row Deleted!");
                    }
                    else
                    {
                        MessageBox.Show("No row to Delete!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        #endregion


        #region Control Functions
        private void btnSubmitSetup_Click(object sender, EventArgs e)
        {
            if (validateInput() == true)
            {
                //Saves and Reload the Database
                saveMedicineRecord();
                getMedicineRecord();

                //Reset the textboxes
                txtboxMedicineID.Text = "";
                txtboxMedicineSetup.Text = "";
                numUDPriceSetup.Text = "0";
                cboxUOMSetup.Text = "";
                numUDIntBalSetup.Text = "0";
                txtboxSupplierSetup.Text = "";
                txtboxItemCodeSetup.Text = "";

                txtboxMedicineSetup.Focus();
            }
            
            
        }

        private void btnUpdateSetup_Click(object sender, EventArgs e)
        {
            if (validateInput() == true)
            {


                updateMedicineRecord();
                getMedicineRecord();

                //Reset the textboxes
                txtboxMedicineID.Text = "";
                txtboxMedicineSetup.Text = "";
                numUDPriceSetup.Text = "0";
                cboxUOMSetup.Text = "";
                numUDIntBalSetup.Text = "0";
                txtboxSupplierSetup.Text = "";
                txtboxItemCodeSetup.Text = "";

                txtboxMedicineSetup.Focus();
            }
        }

        private void btnDeleteSetup_Click(object sender, EventArgs e)
        {
            deleteMedicineRecord();
            getMedicineRecord();

            //Reset the textboxes
            txtboxMedicineID.Text = "";
            txtboxMedicineSetup.Text = "";
            numUDPriceSetup.Text = "0";
            cboxUOMSetup.Text = "";
            numUDIntBalSetup.Text = "0";
            txtboxSupplierSetup.Text = "";
            txtboxItemCodeSetup.Text = "";

            txtboxMedicineSetup.Focus();
        }

        private void numUDPriceSetup_Enter(object sender, EventArgs eventArgs)
        {
            numUDPriceSetup.Select(0, numUDPriceSetup.Text.Length);
        }

        private void numUDIntBalSetup_Enter(object sender, EventArgs eventArgs)
        {
            numUDIntBalSetup.Select(0, numUDIntBalSetup.Text.Length);
        }

        private void dgvMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMedicine.Rows[e.RowIndex];

                txtboxMedicineID.Text = row.Cells[0].Value.ToString();
                txtboxMedicineSetup.Text = row.Cells[1].Value.ToString();
                numUDPriceSetup.Text = row.Cells[2].Value.ToString();
                cboxUOMSetup.Text = row.Cells[3].Value.ToString();
                numUDIntBalSetup.Text = row.Cells[4].Value.ToString();
                txtboxSupplierSetup.Text = row.Cells[5].Value.ToString();
                txtboxItemCodeSetup.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtboxMedicineID.Text = "";
            txtboxMedicineSetup.Text = "";
            numUDPriceSetup.Text = "0";
            cboxUOMSetup.Text = "";
            numUDIntBalSetup.Text = "0";
            txtboxSupplierSetup.Text = "";
            txtboxItemCodeSetup.Text = "";
        }



        #endregion


        private bool validateInput()
        {
            if (txtboxMedicineSetup.Text == "")
            {
                MessageBox.Show("Fill up the Medicine Field");
                return false;
            }
            else if (numUDPriceSetup.Value == 0 || numUDPriceSetup.Text == "")
            {
                MessageBox.Show("Fill up the Price Field");
                return false;
            }
            else if (cboxUOMSetup.Text == "")
            {
                MessageBox.Show("Fill up the Unit of Measure Field");
                return false;
            }
            else 
                return true;


            
        }
        
    }
}

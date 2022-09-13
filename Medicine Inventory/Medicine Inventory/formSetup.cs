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
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;

        public formSetup()
        {
            InitializeComponent();
        }

        private void formSetup_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\'D:\\Users\\PC 4\\Documents\\MEDICINE INVENTORY\\Project\\Medicine Inventory\\Medicine Inventory\\MedicineInventory.mdf\';Integrated Security=True");
            cn.Open();
            getMedicineRecord();

        }

        private void getMedicineRecord()
        {
            cmd = new SqlCommand("select * from Medicine", cn);
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
                    cmd.Parameters.Add("@uom", SqlDbType.NChar).Value = txtboxUOMSetup.Text;
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

        private void btnSubmitSetup_Click(object sender, EventArgs e)
        {
            saveMedicineRecord();
            getMedicineRecord();
        }

        private void numUDPriceSetup_Enter(object sender, EventArgs eventArgs)
        {
            numUDPriceSetup.Select(0, numUDPriceSetup.Text.Length);
        }

        private void numUDIntBalSetup_Enter(object sender, EventArgs eventArgs)
        {
            numUDIntBalSetup.Select(0, numUDIntBalSetup.Text.Length);
        }

    }
}

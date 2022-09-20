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
    public partial class DistModal : Form
    {
        #region SQL Variable Declarations
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;

        #endregion

        public DistModal()
        {
            InitializeComponent();
            

        }

        public string getHealthCenter
        {
            get { return cboxDistModalHCSelect.Text; }
            set { cboxDistModalHCSelect.Text = value; }
        }

        private void DistModal_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\MedicineInventory.mdf;Integrated Security=True");


            populateDataGrid();
        }

        private void populateDataGrid()
        {
            string insertQuery = "SELECT * FROM DistributionTransaction WHERE [Health Center] = @hc";
            try
            {
                using (SqlCommand cmd = new SqlCommand(insertQuery, cn))
                {
                    
                    cn.Open();
                    adapter = new SqlDataAdapter(cmd);
                    adapter.SelectCommand.Parameters.AddWithValue("@hc", cboxDistModalHCSelect.Text);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDistTrans.DataSource = dt;
                  
                    


                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populateDataGrid();
        }

        private void dgvDistTrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDistTrans.Columns[e.ColumnIndex].Name == "deleteCol")
            {
                string date, hc, medicine, exDate;
                string price, distributed;

                date = dgvDistTrans.Rows[e.RowIndex].Cells["dateCol"].Value.ToString();
                hc = dgvDistTrans.Rows[e.RowIndex].Cells["healthcenterCol"].Value.ToString();
                medicine = dgvDistTrans.Rows[e.RowIndex].Cells["medicineCol"].Value.ToString();
                distributed = dgvDistTrans.Rows[e.RowIndex].Cells["distributedCol"].Value.ToString();
                price = dgvDistTrans.Rows[e.RowIndex].Cells["priceCol"].Value.ToString();
                exDate = dgvDistTrans.Rows[e.RowIndex].Cells["expirydateCol"].Value.ToString();

                cn.Open();
                string insertQuery = "DELETE from DistributionTransaction where Date = @date AND [Health Center] = @hc AND Medicine = @medicine AND Price = @price AND [Expiry Date] = @exdate AND [Distribute] = @distributed";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(insertQuery, cn))
                    {
                        cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
                        cmd.Parameters.Add("@hc", SqlDbType.Variant).Value = hc;
                        cmd.Parameters.Add("@medicine", SqlDbType.NVarChar).Value = medicine;
                        cmd.Parameters.Add("@distributed", SqlDbType.Float).Value = distributed;
                        cmd.Parameters.Add("@price", SqlDbType.NVarChar).Value = price;
                        cmd.Parameters.Add("@exdate", SqlDbType.Date).Value = exDate;

                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                        {
                            MessageBox.Show("Deleted: " + date + " | " + hc + " | " + medicine + " | " + distributed + " | " + price + " | " + exDate);
                            cn.Close();
                            populateDataGrid();
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

                cn.Close();
            }
        }
    }
}

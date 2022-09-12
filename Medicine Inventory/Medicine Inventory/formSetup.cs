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

        
    }
}

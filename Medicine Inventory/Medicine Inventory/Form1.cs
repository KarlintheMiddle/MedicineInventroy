using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicine_Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            pnlReportSubMenu.Visible = false;
            pnlTransactionSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlTransactionSubMenu.Visible == true)
            {
                pnlTransactionSubMenu.Visible = false;
            }
            if (pnlReportSubMenu.Visible == true)
            {
                pnlReportSubMenu.Visible=false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;    
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        #region Transaction SubMenu
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlTransactionSubMenu);
        }

        private void btnHCDistribution_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //Code Here
            openChildForm(new formHCDistribution());
        }

        private void btnHCUtilization_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //Code Here
            openChildForm(new formHCUtilization());
        }

        private void btnPurchased_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //Code Here
            openChildForm(new formPurchaseOrder());

        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //Code Here
            openChildForm(new formOthers());

        }

        #endregion



        #region Report SubMenu
        private void btnReports_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlReportSubMenu);
        }

        private void btnAccountReport_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //Code Here
        }

        private void btnHCInventory_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //Code Here
        }

        private void btnHOInventory_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //Code Here
        }
        #endregion

       

        #region Setup
        private void btnSetupMenu_Click(object sender, EventArgs e)
        {
            openChildForm(new formSetup());
        }
        #endregion
    }
}

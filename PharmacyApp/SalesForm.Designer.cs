using System;
using System.Data;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class SalesForm : Form
    { 
        private DataAccessLayer dataAccess = new DataAccessLayer();

        private void LoadAllSales()
        {
            try
            {
                DataTable sales= dataAccess.ExecuteReader("GetAllSales");
                ((DataGridView)GetControlByName("dgvSales")).DataSource = sales;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Control GetControlByName(string name)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Name == name)
                {
                    return control;
                }
            }
            return null;
        }

        private DataGridView dgvSales;
        private PharmacyDBDataSet pharmacyDBDataSet;
        private BindingSource salesBindingSource;
        private System.ComponentModel.IContainer components;
        private PharmacyDBDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private DataGridViewTextBoxColumn saleIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn medicineIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantitySoldDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
    }
}



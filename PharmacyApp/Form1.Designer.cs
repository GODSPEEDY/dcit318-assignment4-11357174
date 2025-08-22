using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class Form1 : Form
    {
        private DataAccessLayer dataAccess = new DataAccessLayer();

       
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

       
        private void ClearMedicineInputFields()
        {
            ((TextBox)GetControlByName("txtMedicineName")).Text = "";
            ((TextBox)GetControlByName("txtCategory")).Text = "";
            ((TextBox)GetControlByName("txtPrice")).Text = "";
            ((TextBox)GetControlByName("txtQuantity")).Text = "";
        }

        
        private void LoadAllMedicines()
        {
            try
            {
                DataTable medicines = dataAccess.ExecuteReader("GetAllMedicines");
                ((DataGridView)GetControlByName("dgvMedicines")).DataSource = medicines;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicines: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                string name = ((TextBox)GetControlByName("txtMedicineName")).Text;
                string category = ((TextBox)GetControlByName("txtCategory")).Text;
                decimal price = decimal.Parse(((TextBox)GetControlByName("txtPrice")).Text);
                int quantity = int.Parse(((TextBox)GetControlByName("txtQuantity")).Text);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Category", category),
                    new SqlParameter("@Price", price),
                    new SqlParameter("@Quantity", quantity)
                };

                dataAccess.ExecuteNonQuery("AddMedicine", parameters);
                MessageBox.Show("Medicine added successfully!");
                ClearMedicineInputFields();
                LoadAllMedicines();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid data for Price and Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding medicine: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (((DataGridView)GetControlByName("dgvMedicines")).SelectedRows.Count > 0)
                {
                    int medicineId = Convert.ToInt32(((DataGridView)GetControlByName("dgvMedicines")).SelectedRows[0].Cells["MedicineID"].Value);
                    int quantity = int.Parse(((TextBox)GetControlByName("txtQuantity")).Text);

                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@MedicineID", medicineId),
                        new SqlParameter("@Quantity", quantity)
                    };

                    dataAccess.ExecuteNonQuery("UpdateStock", parameters);
                    MessageBox.Show("Stock updated successfully!");
                    ClearMedicineInputFields();
                    LoadAllMedicines();
                }
                else
                {
                    MessageBox.Show("Please select a medicine from the list to update stock.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecordSale_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (((DataGridView)GetControlByName("dgvMedicines")).SelectedRows.Count > 0)
                {
                    int medicineId = Convert.ToInt32(((DataGridView)GetControlByName("dgvMedicines")).SelectedRows[0].Cells["MedicineID"].Value);
                    int quantitySold = int.Parse(((TextBox)GetControlByName("txtQuantity")).Text);

                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@MedicineID", medicineId),
                        new SqlParameter("@QuantitySold", quantitySold)
                    };

                    dataAccess.ExecuteNonQuery("RecordSale", parameters);
                    MessageBox.Show("Sale recorded successfully!");
                    ClearMedicineInputFields();
                    LoadAllMedicines();
                }
                else
                {
                    MessageBox.Show("Please select a medicine from the list to record a sale.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid quantity sold.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recording sale: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = ((TextBox)GetControlByName("txtSearch")).Text;
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@SearchTerm", searchTerm)
                };

                DataTable searchResults = dataAccess.ExecuteReader("SearchMedicine", parameters);
                ((DataGridView)GetControlByName("dgvMedicines")).DataSource = searchResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching medicines: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadAllMedicines();
        }

        private void btnViewAllSales_Click(object sender, EventArgs e)
        {
            try
            {
                SalesForm salesForm = new SalesForm();
                salesForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening sales form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Label lblMedicineName;
        private TextBox txtMedicineName;
        private Label lblCategory;
        private TextBox txtCategory;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnAddMedicine;
        private Button btnUpdateStock;
        private Button btnRecordSale;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnViewAll;
        private Button btnViewAllSales;
        private DataGridView dgvMedicines;
    }
}


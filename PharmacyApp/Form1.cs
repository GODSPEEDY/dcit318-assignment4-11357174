using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnRecordSale = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnViewAllSales = new System.Windows.Forms.Button();
            this.dgvMedicines = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.Location = new System.Drawing.Point(20, 20);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(105, 16);
            this.lblMedicineName.TabIndex = 0;
            this.lblMedicineName.Text = "Medicine Name:";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(150, 20);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(200, 22);
            this.txtMedicineName.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 50);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 16);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(150, 50);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(200, 22);
            this.txtCategory.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 80);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(150, 80);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(20, 110);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 16);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(150, 110);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 22);
            this.txtQuantity.TabIndex = 7;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.Location = new System.Drawing.Point(20, 150);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(75, 23);
            this.btnAddMedicine.TabIndex = 8;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(120, 150);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStock.TabIndex = 9;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // btnRecordSale
            // 
            this.btnRecordSale.Location = new System.Drawing.Point(220, 150);
            this.btnRecordSale.Name = "btnRecordSale";
            this.btnRecordSale.Size = new System.Drawing.Size(75, 23);
            this.btnRecordSale.TabIndex = 10;
            this.btnRecordSale.Text = "Record Sale";
            this.btnRecordSale.Click += new System.EventHandler(this.btnRecordSale_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 200);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(160, 16);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search (Name/Category):";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(180, 200);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 22);
            this.txtSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(360, 200);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(450, 200);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(118, 23);
            this.btnViewAll.TabIndex = 14;
            this.btnViewAll.Text = "View All Medicines";
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnViewAllSales
            // 
            this.btnViewAllSales.Location = new System.Drawing.Point(600, 200);
            this.btnViewAllSales.Name = "btnViewAllSales";
            this.btnViewAllSales.Size = new System.Drawing.Size(148, 23);
            this.btnViewAllSales.TabIndex = 15;
            this.btnViewAllSales.Text = "View All Sales";
            this.btnViewAllSales.Click += new System.EventHandler(this.btnViewAllSales_Click);
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicines.ColumnHeadersHeight = 29;
            this.dgvMedicines.Location = new System.Drawing.Point(20, 250);
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.RowHeadersWidth = 51;
            this.dgvMedicines.Size = new System.Drawing.Size(834, 300);
            this.dgvMedicines.TabIndex = 16;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(866, 553);
            this.Controls.Add(this.lblMedicineName);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.btnRecordSale);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnViewAllSales);
            this.Controls.Add(this.dgvMedicines);
            this.Name = "Form1";
            this.Text = "Pharmacy Inventory Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}



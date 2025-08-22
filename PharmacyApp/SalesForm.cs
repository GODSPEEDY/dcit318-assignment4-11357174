using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.pharmacyDBDataSet = new PharmacyApp.PharmacyDBDataSet();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new PharmacyApp.PharmacyDBDataSetTableAdapters.SalesTableAdapter();
            this.saleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitySoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
           
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AllowUserToOrderColumns = true;
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSales.AutoGenerateColumns = false;
            this.dgvSales.ColumnHeadersHeight = 29;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIDDataGridViewTextBoxColumn,
            this.medicineIDDataGridViewTextBoxColumn,
            this.quantitySoldDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn});
            this.dgvSales.DataSource = this.salesBindingSource;
            this.dgvSales.Location = new System.Drawing.Point(10, 40);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.Size = new System.Drawing.Size(560, 227);
            this.dgvSales.TabIndex = 0;
            this.dgvSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSales_CellContentClick);
           
            this.pharmacyDBDataSet.DataSetName = "PharmacyDBDataSet";
            this.pharmacyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
           
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.pharmacyDBDataSet;
            
            this.salesTableAdapter.ClearBeforeFill = true;
            
            this.saleIDDataGridViewTextBoxColumn.DataPropertyName = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.HeaderText = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleIDDataGridViewTextBoxColumn.Name = "saleIDDataGridViewTextBoxColumn";
            this.saleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleIDDataGridViewTextBoxColumn.Width = 125;
           
            this.medicineIDDataGridViewTextBoxColumn.DataPropertyName = "MedicineID";
            this.medicineIDDataGridViewTextBoxColumn.HeaderText = "MedicineID";
            this.medicineIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicineIDDataGridViewTextBoxColumn.Name = "medicineIDDataGridViewTextBoxColumn";
            this.medicineIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.medicineIDDataGridViewTextBoxColumn.Width = 125;
            
            this.quantitySoldDataGridViewTextBoxColumn.DataPropertyName = "QuantitySold";
            this.quantitySoldDataGridViewTextBoxColumn.HeaderText = "QuantitySold";
            this.quantitySoldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantitySoldDataGridViewTextBoxColumn.Name = "quantitySoldDataGridViewTextBoxColumn";
            this.quantitySoldDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantitySoldDataGridViewTextBoxColumn.Width = 125;
           
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            this.saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleDateDataGridViewTextBoxColumn.Width = 125;
           
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.dgvSales);
            this.Name = "SalesForm";
            this.Text = "All Sales Records";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalesForm_Load(object sender, System.EventArgs e)
        {
            
            this.salesTableAdapter.Fill(this.pharmacyDBDataSet.Sales);

        }
    }
}



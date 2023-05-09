using CodeFirstHomework1.Entities;
using CodeFirstHomework1.Repositories;

namespace CodeFirstHomework1
{
    public partial class AddForm : Form
    {
        Form externalForm;

        public AddForm()
        {
            InitializeComponent();
        }

        public AddForm(string buttonText, Form1 form)
        {
            InitializeComponent();
            btnAdd.Text = buttonText;
            this.externalForm = form;

            txtAddress.Text = form.selectedSupplier.Address;
            txtCompanyName.Text = form.selectedSupplier.CompanyName;
            txtContactName.Text = form.selectedSupplier.ContactName;
            txtContactTitle.Text = form.selectedSupplier.ContactTitle;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.ContactTitle = txtContactTitle.Text;
            supplier.ContactName = txtContactName.Text;
            supplier.Address = txtAddress.Text;
            supplier.CompanyName = txtCompanyName.Text;

            SupplierService repository = new SupplierService();

            if (externalForm != null)
            {
                var repoSupplier = repository.FindById(supplier.Id);
                repoSupplier = supplier;
            }
            else
            {
                repository.Create(supplier);
            }
            repository.SaveChanges();
            MessageBox.Show("Success");
        }
    }
}

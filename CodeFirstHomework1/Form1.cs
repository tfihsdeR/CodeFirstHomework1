using CodeFirstHomework1.Entities;
using CodeFirstHomework1.Repositories;
using System.ComponentModel;

namespace CodeFirstHomework1
{
    public partial class Form1 : Form
    {
        public Supplier selectedSupplier;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SupplierService repo = new SupplierService();
            dgw.DataSource = repo.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string id = txtSearch.Text.Trim();
            if (id != null && id !="")
            {
                SupplierService repo = new SupplierService();
                var item = repo.FindById(Convert.ToInt32(id));
                if(item != null)
                {
                    dgw.DataSource = null;
                    dgw.Rows.Add(item);
                }
                else
                    dgw.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgw.DataBindings.Clear();
            SupplierService repo = new SupplierService();
            dgw.DataSource = repo.ToList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Supplier supplier = dgw.CurrentRow.DataBoundItem as Supplier;
            selectedSupplier = supplier;
            AddForm addForm = new AddForm("Update", this);
            addForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgw.CurrentRow != null)
            {
                Supplier supplier = dgw.CurrentRow.DataBoundItem as Supplier;
                SupplierService repo = new SupplierService();
                repo.Delete(supplier.Id);
                repo.SaveChanges();
                //if (dgw.DataSource is IBindingList list && list.AllowRemove)
                //{
                //    int rowIndex = dgw.CurrentRow.Index;
                //    list.RemoveAt(rowIndex);
                //}
                //dgw.Update();
                //dgw.Refresh();
                dgw.DataBindings.Clear();
                dgw.DataSource = repo.ToList();
            }
        }
    }
}
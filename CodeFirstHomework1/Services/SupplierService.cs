using CodeFirstHomework1.Data;
using CodeFirstHomework1.Entities;
using CodeFirstHomework1.Services;

namespace CodeFirstHomework1.Repositories
{
    public class SupplierService : EFRepositoryBase<AppDbContext>, IServices<Supplier>
    {
        public void Create(Supplier entity)
        {
            context.Suppliers.Add(entity);
        }

        public void Delete(int id)
        {
            var item = context.Suppliers.FirstOrDefault(e => e.Id == id);
            context.Remove(item);
        }

        public Supplier FindById(int id)
        {
            return context.Suppliers.FirstOrDefault(e => e.Id == id);
        }

        public List<Supplier> ToList()
        {
            return context.Suppliers.ToList();
        }

        public void Update(int id, Supplier entity)
        {
            var supplier = context.Suppliers.FirstOrDefault(s => s.Id == id);
            supplier = entity;
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace CodeFirstHomework1.Data
{
    public abstract class EFRepositoryBase <TContext> where TContext : DbContext, new()
    {
        protected TContext context = new TContext();

        public virtual int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}

namespace CodeFirstHomework1.Services
{
    public interface IServices<T> where T : class, new()
    {
        void Create(T entity);
        void Update(int id, T entity);
        void Delete(int id);
        T FindById(int id);
        List<T> ToList();
    }
}

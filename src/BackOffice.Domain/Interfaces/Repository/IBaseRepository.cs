namespace BackOffice.Domain.Interfaces.Repository; 
public interface IBaseRepository<T> where T : class
{
    Task Create(T model);

    Task Update(T model);

    Task Delete(T model);

//    Task<bool> Delete(int id);

 //   Task<T> GetOne(int id);

    Task<IEnumerable<T>> GetAll();

    Task<bool> SaveChanges();
}

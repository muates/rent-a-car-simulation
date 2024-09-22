namespace RentACar.ConsoleUI.Repository;

public interface IRepository<T>
{
    void Add(T data);
    void Update(T data);
    void Delete(T data);
    T GetById(int id);
    IEnumerable<T> GetAll();
}

namespace MVC_Core_WebApp1.Models
{
    public interface IRepo<T>
    {
        bool AddData(T obj);
        bool UpdateData(int id, T obj);
        bool DeleteData(int id);
        List<T> ShowAlldata();
        T ShowDetailsById(int id);
        T ShowDetailsByName(string name);
    }
}

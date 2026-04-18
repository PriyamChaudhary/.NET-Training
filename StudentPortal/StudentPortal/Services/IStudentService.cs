using StudentPortal.Models;

namespace StudentPortal.Services
{
    public interface IStudentService
    {
        Task<List<Student>> SearchAsync(string p = null);
        Task<Student?> GetByIdAsync(int id);
        Task AddAsync(Student student);
        Task UpdateAsync(Student student);
        Task DeleteAsync(int id);

    }
}

using Microsoft.EntityFrameworkCore;
using StudentPortal.Models;
using StudentPortal.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentPortalDbContext _db;
        public StudentRepository(StudentPortalDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Student student)
        {
            await _db.Students.AddAsync(student);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var student = await _db.Students.FindAsync(id);
            if (student != null)
            {
                _db.Students.Remove(student);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<bool> EmailExistsAsync(string email, int? ignoreStudentId = null)
        {
            return await _db.Students.AnyAsync(s=>s.Email==email && (!ignoreStudentId.HasValue || s.StudentId != ignoreStudentId.Value));
        }

        public async Task<List<Student>> GetAllAsync(string p = null)
        {
            var query = _db.Students.AsQueryable();

            if (!string.IsNullOrEmpty(p))
            {
                query = query.Where(s => s.FullName.Contains(p));
            }
            return await query.ToListAsync();
        }

        public async Task<Student?> GetByIdAsync(int id)
        {
            return await _db.Students.FindAsync(id);

        }

        public async Task UpdateAsync(Student student)
        {
            _db.Students.Update(student);
            await _db.SaveChangesAsync();

        }
    }
}
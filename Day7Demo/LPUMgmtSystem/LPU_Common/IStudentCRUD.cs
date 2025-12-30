using LPU_Entity;
namespace LPU_Common

{
    public interface IStudentCRUD
    {
        public Student SearchStudentByID(int rollNo);
        public List<Student> SearchStudentByName(string name);
        public bool EnrollStudent(Student sObj);
        public bool DropStudentDetails(int id);

    }
}

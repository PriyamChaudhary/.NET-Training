using LPU_Entity;
using LPU_Common;
using System.Net.Sockets;
using LPU_Exceptions;

namespace LPU_DAL
{
    /// <summary>
    /// Student DAO(Data  class is used for CRUD operations
    /// </summary>
    public class StudentDAO : IStudentCRUD
    {
        static List<Student> studentList = null;
        public StudentDAO()
        {
            //collection init
            studentList = new List<Student>()
            {
            new Student() { StudentId=101,Name="Alok",Course=CourseType.CSE,Address="Chandigarh"}
            };

    }
        public Student SearchStudentByID(int rollNo)
        {
            Student myStud = null;
            if (rollNo != 0)
            {
                myStud = studentList.Find(s => s.StudentId == rollNo);

            }
            else
            {
                 throw new NotImplementedException();
            }
            return myStud;
        }
        public List<Student> SearchStudentByName(string name)
        {
            List<Student> data = studentList.FindAll(p => p.Name == name);
            return data;
        }

        public bool EnrollStudent(Student sObj)
        {
            bool flag = false;
            if (sObj != null) {
                studentList.Add(sObj);
                flag = true;
            }
            return flag;
        }
        public bool DropStudentDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}

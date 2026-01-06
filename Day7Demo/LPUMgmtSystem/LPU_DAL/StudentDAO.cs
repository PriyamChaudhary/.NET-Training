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
            new Student() { StudentId=101,Name="Alok",Course=CourseType.CSE,Address="Chandigarh"},
            new Student() { StudentId=102,Name="Riya",Course=CourseType.Mechanical,Address="Chennai"},
            new Student() { StudentId=103,Name="Aman",Course=CourseType.Electrical,Address="Delhi"},
            new Student() { StudentId=104,Name="Aliya",Course=CourseType.CSE,Address="Mumbai"},
            new Student() { StudentId=105,Name="Raj",Course=CourseType.CSE,Address="Pune"},
            new Student() { StudentId=106,Name="Rajat",Course=CourseType.CSE,Address="Amritsar"},
            new Student() { StudentId=107,Name="Alisha",Course=CourseType.CSE,Address="Jalandhar"},
            new Student() { StudentId=108,Name="Siya",Course=CourseType.CSE,Address="Jaipur"},
            new Student() { StudentId=109,Name="Diya",Course=CourseType.CSE,Address="Kolkata"},
            new Student() { StudentId=110,Name="Tiya",Course=CourseType.CSE,Address="Meerut"}

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

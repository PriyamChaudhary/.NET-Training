
namespace MVC_Core_WebApp1.Models
{
    public class StudentRepo : IRepo<Student>
    {
        public static List<Student> studList = null;
        public StudentRepo()
        {
            if(studList == null)
            {
                studList = new List<Student>()
                {
                    new Student(){RollNo=101, Name="Alok", Age=22, Address="Pune"},
                    new Student(){RollNo=102, Name="Riya", Age=23, Address="Mumbai"}
                };
            }
        }
        public bool AddData(Student obj)
        {
            bool flag=false; ;
            if (obj != null) 
            {
                studList.Add(obj);
                flag = true;
            
            }
            else
            {
                throw new NullReferenceException("Object not initialized");
            }
            return flag;
        }

        public bool DeleteData(int id)
        {
            bool flag = false;
            Student sObj = studList.Find(s => s.RollNo == id);
            if (sObj != null)
            { 
                studList.Remove(sObj);
                flag = true;
            }
            return flag;
        }

        public List<Student> ShowAlldata()
        {
            return studList;
        }

        public Student ShowDetailsById(int id)
        {
            Student sObj = studList.Find(s => s.RollNo == id);
            return sObj; 
        }

        public Student ShowDetailsByName(string name)
        {
            Student sObj = studList.Find(s => s.Name == name);
            return sObj;
        }

        public bool UpdateData(int id, Student obj)
        {
            throw new NotImplementedException();
        }
    }
}

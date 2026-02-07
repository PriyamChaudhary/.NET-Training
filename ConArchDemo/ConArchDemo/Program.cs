using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConArchDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentDAL dal = new StudentDAL();
            //List<Student> students = dal.ShowAllStudents();
            List<Student> students = dal.SearchByName("Alok");

            foreach (Student item in students)
            {
                Console.WriteLine($"{item.RollNo}, {item.Name}, {item.Address}, {item.PhoneNo}");
            }
        }
    }
}

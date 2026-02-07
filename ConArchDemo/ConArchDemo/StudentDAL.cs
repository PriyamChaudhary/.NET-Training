using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//For ADO.net
using System.Data.SqlClient;
using System.Data;

namespace ConArchDemo
{
    /// <summary>
    /// Demo code for connected architecture in StudentDAL class
    /// </summary>
    public class StudentDAL
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;

        public StudentDAL()
        {
            con=new SqlConnection();
            con.ConnectionString = "Server=.\\Sqlexpress;Integrated Security=SSPI;Database=LPU_DB; TrustServerCertificate=true";
        }
        public List<Student> ShowAllStudents()
        {
            List<Student> studList = new List<Student>();
            //Code for connected Arch below
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "Select * from StudentInfo";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                //Holding Data via Reader
                sdr = cmd.ExecuteReader();
                
                DataTable myDt = new DataTable();
                myDt.Load(sdr);

                //Convert Table into List
                foreach (DataRow drow in myDt.Rows)
                {
                    Student sObj = new Student()
                    {
                        RollNo = Convert.ToInt32(drow[0].ToString()),
                        Name = drow[1].ToString(),
                        Address = drow[3].ToString(),
                        PhoneNo = drow[5].ToString()
                    };
                    if (sObj != null)
                    {
                        studList.Add(sObj);
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                con.Close();

            }
            return studList;
        }
        public List<Student> SearchByName(string name)
        {
            List<Student> studList = new List<Student>();
            SqlParameter param= new SqlParameter("@Name",name);
            try
            {
                con.Open();
                cmd = new SqlCommand();
                //cmd.CommandText = "Select * from StudentInfo where Name='"+name+"'";
                cmd.CommandText = "Select * from StudentInfo where Name=@Name";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                //Adding parameter to command obj
                cmd.Parameters.Add(param);

                //Holding Data via Reader
                sdr = cmd.ExecuteReader();

                DataTable myDt = new DataTable();
                myDt.Load(sdr);

                //Convert Table into List
                foreach (DataRow drow in myDt.Rows)
                {
                    Student sObj = new Student()
                    {
                        RollNo = Convert.ToInt32(drow[0].ToString()),
                        Name = drow[1].ToString(),
                        Address = drow[3].ToString(),
                        PhoneNo = drow[5].ToString()
                    };
                    if (sObj != null)
                    {
                        studList.Add(sObj);
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                con.Close();

            }
            return studList;


        }

        public Student SearchByRollNo(int id)
        {
            Student stud = null;
            
            return stud ;
        }

        public bool AddStudent(Student sObj)
        {
            bool flag = false;

            con.Open();
            SqlParameter[] studentParam = new SqlParameter[5];
            for(int i=0;i<studentParam.Length;i++)
            {
                studentParam[i]=new SqlParameter();
            }
            studentParam[0].ParameterName = "@RollNo";
            studentParam[0].Value = sObj.RollNo;

            studentParam[1].ParameterName = "@Name";
            studentParam[1].Value = sObj.Name;

            studentParam[2].ParameterName = "@Age";
            studentParam[2].Value = sObj.Age;

            studentParam[3].ParameterName = "@Addr";
            studentParam[3].Value = sObj.Address;

            studentParam[4].ParameterName = "@Phone";
            studentParam[4].Value = sObj.PhoneNo;

            cmd=new SqlCommand();
            cmd.CommandText = "Insert into SutdentInfo(RollNo,Name,Age,LocalAddr,PerAddr,PhoneNo) values(@RollNo,@Name,@Age,@Addr,@Addr,@Phone)";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

        

            cmd.Parameters.AddRange(studentParam);
            int rowCount=cmd.ExecuteNonQuery();
            if (rowCount > 0) 
            {
                flag=true;
            }
            return flag;


        }

    }
}

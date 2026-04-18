using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Threading;


namespace MyDemoWebService
{
    /// <summary>
    /// Summary description for LPUService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LPUService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int AddMe(int num1, int num2)
        {
            return num1 + num2;
        }

        [WebMethod]
        public Product[] ShowAllProducts()
        {
            SqlConnection conn=new SqlConnection();
            conn.ConnectionString = "Server=.\\sqlexpress;Database=LPU_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            conn.Open();

            //command
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from Products";
            cmd.CommandType=CommandType.Text;
            cmd.Connection = conn;

            //DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            Product[] prodList = null;
            DataTable dt = new DataTable();
            dt.Load(reader);
            if (dt.Rows.Count>0)
            {
                prodList = new Product[dt.Rows.Count];
            }
            int count = 0;
            foreach (DataRow item in dt.Rows)
            {
                Product pObj=new Product();
                pObj.ProdId=(int)item[0];
                pObj.Name = item[1].ToString();
                pObj.Category = item[2].ToString();
                pObj.Price = Convert.ToInt32(item[3]);
                pObj.Details = item[4].ToString();

                prodList[count] = pObj;
                count++;
            }
            conn.Close();
            return prodList;

        }
    }
}

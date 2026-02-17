using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WinDisconArchDemo
{

    public class ProductUtility : IProductRepo
    {
        IDbConnection conn;
        SqlDataAdapter adap1;
        DataSet ds;

        public ProductUtility()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Server=.\\sqlexpress;Integrated Security=true;Database=Lpu_Db;TrustServerCertificate=true";

        }
        public bool AddData(Product obj)
        {
            throw new NotImplementedException();
        }

        public bool DeleteData(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetTop3BudgetProduct()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetTop3CostlyProduct()
        {
            throw new NotImplementedException();
        }

        public Product SearchById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> ShowAll()
        {
            List<Product> prodList = null;
            adap1 = new SqlDataAdapter("Select * from Products",(SqlConnection)conn); //decorator pattern type casting using Wrapper classes
            adap1.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            ds = new DataSet();
            adap1.Fill(ds, "Prod");
            if (ds.Tables[0].Rows.Count > 0) 
            {
                prodList = new List<Product>();
                foreach(DataRow drow in ds.Tables["Prod"].Rows)
                {
                    Product p1 = new Product()
                    {
                        ProdId = Int32.Parse(drow[0].ToString()),
                        ProdName = drow[1].ToString(),
                        CatName = drow[2].ToString(),
                        Price=Single.Parse(drow[3].ToString()),
                        Desc = drow[4].ToString()
                    };
                    prodList.Add(p1);
                }
                
            
            }
            return prodList;
        } 


        public List<Product> ShowALlProductByCategory(int catId)
        {
            throw new NotImplementedException();
        }

        public List<Product> SortProductByPriceAsc()
        {
            throw new NotImplementedException();
        }

        public List<Product> SortProductByPriceDesc()
        {
            throw new NotImplementedException();
        }

        public bool UpdateData(int id, Product obj)
        {
            throw new NotImplementedException();
        }
        public DataTable GetAllData()
        {
            adap1 = new SqlDataAdapter("Select * from Products", (SqlConnection)conn); //decorator pattern type casting using Wrapper classes
            adap1.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            ds = new DataSet();
            adap1.Fill(ds, "Prod");
            return ds.Tables[0];
        }
    }
}

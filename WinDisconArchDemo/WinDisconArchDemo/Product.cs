using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDisconArchDemo
{
    /// <summary>
    /// Entity Class Product
    /// </summary>
    public class Product
    {
        #region Fields
        int prodId;
        //string prodName;
        //int price;
        //string desc;
        #endregion

        #region CLR properties
        public int ProdId
        {
            get { return prodId; }
            set 
            {
                if(value<=0 || value >= 999)
                {
                    throw new MyCustomException("Product Id is not valid...");
                }
                else
                {
                    prodId = value;
                }
            }

        }

        public string ProdName { get; set; }
        public string CatName { get; set; }
        public float Price { get; set; }
        public string Desc { get; set; }
        #endregion
    }
}

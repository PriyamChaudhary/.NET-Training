using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPU_Common
{
    /// <summary>
    /// Custom Generic Class created for Demo 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericClass<T>
    {

        /// <summary>
        /// Custom Generic Method
        /// </summary>
        /// <param name="obj1"></param>
        /// <param name="obj2"></param>
        public void SwapMe(ref T obj1, ref T obj2)
        {
            T temp;
            temp = obj1;
            obj1 = obj2;
            obj2 = temp;



        
        }
    }
}

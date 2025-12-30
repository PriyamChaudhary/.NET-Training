namespace LPU_Exceptions
{
    /// <summary>
    /// Custom Exception Class Created For LPU Project
    /// By Priyam on  Date 29/12/2025 at 11:34 AM
    /// </summary>
    public class LpuException : Exception
    {
        
        public LpuException():base()
        {
           

        }
        public LpuException(string errorMsg) : base(errorMsg)
        {

        }
    }
}

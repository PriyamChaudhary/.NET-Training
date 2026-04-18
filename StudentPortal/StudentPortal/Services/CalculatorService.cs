namespace StudentPortal.Services
{
    public class CalculatorService: ICalculatorService
    {
        public int Add(int num1, int num2)
        {
            return num1+num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1*num2;
        }
    }
}

using System;

namespace InterfaceDemo;

public class MathClass:IAll
{
    public int AddMe(int num1, int num2)
    {
        return num1 + num2;
    }

    public int SubMe(int num1, int num2)
    {
        return num1 - num2;
    }

    public int ProdMe(int num1, int num2)
    {
        return num1 * num2;
    }
    public int DivMe(int num1, int num2)
        {
            return num1 / num2;
        }

}

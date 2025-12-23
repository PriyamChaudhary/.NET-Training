using System;

namespace InterfaceDemo;

    interface IAdd
    {
        int AddMe(int num1,int num2);
    }
    interface ISub
    {
        int SubMe(int num1,int num2);
    }
    interface IProd
    {
        int ProdMe(int num1,int num2);
    }
    interface IDiv
    {
        int DivMe(int num1,int num2);
    }
    interface IAddSub: IAdd, ISub{}
    interface IAddProdDiv: IAdd, IProd, IDiv{}
    interface IAll: IAddSub, IAddProdDiv, ISub{}




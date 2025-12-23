using System.Threading.Channels;
using InterfaceDemo;

// IAdd m1 = new MathClass();
// IAddSub m2 = new MathClass();
// IAll m3 = new MathClass();

//Approach 1
Products pObj =new Products();
pObj.ProdID=12;
pObj.Name="Bottle";
pObj.Price=850;


//Approach 2
//Object Initializer
Products pObj1 = new Products(){ProdID=102, Name="Pen",Price=25};

//Approach 3
//Collection Initializer
List<Products> prodList=new List<Products>()
{
    new Products(){ProdID=101,Name="Marker",Price=25},
    new Products(){ProdID=102,Name="Perfume",Price=250},
    new Products(){ProdID=102,Name="Toy car",Price=500},
    new Products(){ProdID=103,Name="Ipad",Price=36000},
    new Products(){ProdID=104,Name="Headphones",Price=4000},
    new Products(){ProdID=105,Name="Serum",Price=2000},
};

foreach(var item in prodList)
{
    System.Console.WriteLine($"{item.ProdID}\t{item.Name}\t{item.Price}");
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace PharmacyMedicine;

public class Program
{
    public static void Main(string[] args)
    {
        Medicine mObj=new Medicine();
        MedicineUtility medUtilObj=new MedicineUtility();

        try
        {
            string input = Console.ReadLine();
            string[] str=input.Split(" ");
            mObj.Id=str[0];
            mObj.Name=str[1];
            mObj.Price=int.Parse(str[2]);
            mObj.ExpiryYear=int.Parse(str[3]);
            
            medUtilObj.AddMedicine(mObj);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        while (true)
        {
            int choice=int.Parse(Console.ReadLine());
            try
            {
                switch (choice)
                {
                    case 1:
                        foreach(var item in medUtilObj.GetAllMedicines())
                            {
                                Console.WriteLine($"Details: {item.Id} {item.Name} {item.Price} {item.ExpiryYear}");
                            }
                        break;

                    case 2:
                        string id=Console.ReadLine();
                        int newPrice=int.Parse(Console.ReadLine());
                        medUtilObj.UpdateMedicinePrice(id, newPrice);
                        Console.WriteLine("Price Updated Successfully");
                        break;
                    
                    case 3:
                        string[] newInput = Console.ReadLine().Split(' ');

                            Medicine newMed = new Medicine
                            {
                                Id = newInput[0],
                                Name = newInput[1],
                                Price = int.Parse(newInput[2]),
                                ExpiryYear = int.Parse(newInput[3])
                            };

                        medUtilObj.AddMedicine(newMed);
                        Console.WriteLine("Added successfully");
                        break;

                    case 4:
                    return;

                    default:
                    Console.WriteLine("Invalid Choice");
                    break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
using System;

namespace Assignment3App;

public class Laptop : Computer
{
    public int DisplaySize { get; set; }
    public int BatteryVolt { get; set; }
    public int BatteryVoltPrice { get;}=20;
    public int DisplayPrice { get;}=250;

    public double LaptopPriceCalculation()
    { 
        switch (Processor)
        {
            case "i3":
            ProcessorCost=2500;
            break;

            case "i5":
            ProcessorCost=5000;
            break;

            case "i7":
            ProcessorCost=6500;
            break;
        }
        
    
        double laptopPrice = ProcessorCost + (RamSize * RamPrice) + (HardDiskSize * HardDiskPrice) + (GraphicCard * GraphicCardPrice) + (DisplaySize* DisplayPrice) + (BatteryVolt * BatteryVoltPrice);
            
        return laptopPrice;
    }
}

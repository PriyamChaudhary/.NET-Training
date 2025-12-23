using System;

namespace Assignment3App;

public class Desktop : Computer
{
    public int MonitorSize { get; set; }
    public int PowerSupplyVolt { get; set; }
    public int MonitorPrice { get;}=250;
    public int PowerSupplyVoltPrice { get;}=20;//never declare variables as public and write it as properties and no need to assign the values separately

    // public Desktop()
    // {
        // we never write logic inside the constructor. that's why we have written switch inside the fucntion only
    // }

    public double DesktopPriceCalculation()
    {
        switch (Processor)
        {
            case "i3":
            ProcessorCost=1500;
            break;

            case "i5":
            ProcessorCost=3000;
            break;

            case "i7":
            ProcessorCost=4500;
            break;
        }
        
        double desktopPrice = ProcessorCost + (RamSize * RamPrice) + (HardDiskSize * HardDiskPrice) + (GraphicCard * GraphicCardPrice) + (MonitorSize * MonitorPrice) + (PowerSupplyVolt * PowerSupplyVoltPrice);
        return desktopPrice;
    }
}

using System;

namespace MediSure_Clinic;

public class PatientBill
{
    public required string BillId { get; set; }
    public string PatientName { get; set; }
    public bool HasInsurance { get; set; }
    public decimal ConsultationFee { get; set; }
    public decimal LabCharges { get; set; }
    public decimal MedicineCharges { get; set; }
    public decimal GrossAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal FinalPayable { get; set; }

    static PatientBill LastBill;
    static bool HasLastBill;

    //choices that user will have to perform
    public static void CreateNewBill()
    {
        Console.WriteLine("Enter Bill Id: ");
        string billId = Console.ReadLine();
        if(billId == null)
        {
            throw new ArgumentNullException("BillId cannot be null");
        }
        Console.WriteLine("Enter Patient Name: ");
        string patientName = Console.ReadLine();

        Console.Write("Is the patient insured? (Y/N): ");
        bool hasInsurance = (Console.ReadLine() ?? "").Trim().StartsWith("Y", StringComparison.OrdinalIgnoreCase);

        Console.WriteLine("Enter Consultation Fee: ");
        decimal consultationFee = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter Lab Charges: ");
        decimal labCharges = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter Medicine Charges: ");
        decimal medicineCharges = decimal.Parse(Console.ReadLine());
        
        if(consultationFee <= 0)
        {
            Console.WriteLine("ConsultationFee must be greater than 0");
        }

        if(labCharges<0 && medicineCharges<0){
            Console.WriteLine("Labcharges and Medicine Charges must be greater than or equal to 0");
        }

        var bill = new PatientBill
        {
            BillId = billId,
            PatientName = patientName,
            HasInsurance = hasInsurance,
            ConsultationFee = consultationFee,
            LabCharges = labCharges,
            MedicineCharges = medicineCharges,
        };

        bill.GrossAmount = bill.ConsultationFee + bill.LabCharges + bill.MedicineCharges;
        bill.DiscountAmount = bill.HasInsurance ? bill.GrossAmount * 0.10m : 0m;
        bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;

        LastBill = bill;
        HasLastBill = true;

        Console.WriteLine("Bill created successfully.");
        Console.WriteLine($"Gross Amount: {bill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {bill.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {bill.FinalPayable:F2}");
        Console.WriteLine("------------------------------------------------------------");

    }
    public static void ViewLastBill()
    {
        if (!HasLastBill || LastBill == null)
            {
                Console.WriteLine("No bill available. Please create a new bill first.");
                return;
            }

        var billObj = LastBill;
        Console.WriteLine("------------------ Last Bill ---------------------");
        Console.WriteLine($"BillId: {billObj.BillId}");
        Console.WriteLine($"Patient: {billObj.PatientName}");
        Console.WriteLine($"Insured: {(billObj.HasInsurance ? "Yes" : "No")}");
        Console.WriteLine($"Consultation Fee: {billObj.ConsultationFee:F2}");
        Console.WriteLine($"Lab Charges: {billObj.LabCharges:F2}");
        Console.WriteLine($"Medicine Charges: {billObj.MedicineCharges:F2}");
        Console.WriteLine($"Gross Amount: {billObj.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {billObj.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {billObj.FinalPayable:F2}");
        Console.WriteLine("--------------------------------------------------------");
        
    }
    public static void ClearLastBill()
    {
        LastBill = null;
        HasLastBill = false;
        Console.WriteLine("Last bill cleared.");
        
    }
   
}







































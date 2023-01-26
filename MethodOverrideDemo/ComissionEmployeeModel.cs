// See https://aka.ms/new-console-template for more information

public class ComissionEmployeeModel : EmployeeModel
{
    public decimal CommissionAmount { get; set; }
    public override decimal GetPaycheckAmount(int hoursWorked)
    {
        decimal initialPay = base.GetPaycheckAmount(hoursWorked);
        return initialPay+CommissionAmount;
    }
}
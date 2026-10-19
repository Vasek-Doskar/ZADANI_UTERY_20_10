public interface ISavingsCalculatorService
{
    double CalculateGrossInterest(double principal, double interestRate, double years);
    double CalculateNetInterest(double grossInterest, double taxRate);
    double CalculateTotalAmount(double principal, double netInterest);
}
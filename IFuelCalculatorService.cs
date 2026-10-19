public interface IFuelCalculatorService
{
    double CalculateRange(double tankCapacity, double consumptionPer100Km);
    double CalculateFuelNeeded(double distance, double consumptionPer100Km);
    double CalculateTripCost(double fuelNeeded, double pricePerLiter);
}

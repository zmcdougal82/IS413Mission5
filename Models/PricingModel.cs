namespace ConsoleApp3.Models;

public class PricingModel
{
    public int Hours { get; set; }
    public decimal HourlyRate { get; set; } = 25.0m; // Default tutoring rate
    public decimal Total => Hours * HourlyRate;
}

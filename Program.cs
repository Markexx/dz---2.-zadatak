using dz_2._zadatak;
public class Program
{
    public static void Main(string[] args)
    {
        ICoffee espresso = new Espresso();
        Console.WriteLine($"{espresso.GetDescription()} ${espresso.GetCost():0.00}");

        ICoffee espressoWithMilk = new Milk(espresso);
        Console.WriteLine($"{espressoWithMilk.GetDescription()} ${espressoWithMilk.GetCost():0.00}");

        ICoffee espressoWithMilkAndSugar = new Sugar(espressoWithMilk);
        Console.WriteLine($"{espressoWithMilkAndSugar.GetDescription()} ${espressoWithMilkAndSugar.GetCost():0.00}");
    }
}
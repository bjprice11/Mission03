namespace Mission03;

public class FoodItem
{
    public string foodName = "";
    public string foodCategory = "";
    public int foodQuantity = 0;
    public DateOnly foodDate = new DateOnly();
    public FoodItem FoodName()
    {
        Console.WriteLine("Enter Food Name");
        foodName = Console.ReadLine();
        Console.WriteLine("Enter Category");
        foodCategory = Console.ReadLine();
        Console.WriteLine("Quantity");
        foodQuantity = int.Parse(Console.ReadLine());
        if (foodQuantity < 0)
        {
            Console.WriteLine("Food Quantity cannot be negative, setting to 0.");
            foodQuantity = 0;
        }
        Console.WriteLine("Enter Expiration Date");
        foodDate = DateOnly.Parse(Console.ReadLine());
        return this;
    }
}
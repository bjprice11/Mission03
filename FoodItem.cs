namespace Mission03;

public class FoodItem
{
    //Sets variables to use later
    public string foodName = "";
    public string foodCategory = "";
    public int foodQuantity = 0;
    public DateOnly foodDate = new DateOnly();
    
    //Constructor to get input
    public FoodItem()
    {
        Console.WriteLine("Enter Food Name");
        this.foodName = Console.ReadLine();
        Console.WriteLine("Enter Category");
        this.foodCategory = Console.ReadLine();
        Console.WriteLine("Quantity");
        this.foodQuantity = int.Parse(Console.ReadLine());
        //Error handling for negative numbers
        if (this.foodQuantity < 0)
        {
            Console.WriteLine("Food Quantity cannot be negative, setting to 0.");
            this.foodQuantity = 0;
        }
        Console.WriteLine("Enter Expiration Date");
        this.foodDate = DateOnly.Parse(Console.ReadLine());
    }
}
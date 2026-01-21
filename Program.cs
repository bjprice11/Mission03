//Brandon Price
using Mission03;


Console.WriteLine("Welcome to the Food Bank Inventory System");


List<FoodItem> foodList = new List<FoodItem>();

do {
    string input = "";
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Add Food Item");
    Console.WriteLine("2. Delete Food Item");
    Console.WriteLine("3. Print List of Current Food Items");
    Console.WriteLine("4. Exit");
    input = Console.ReadLine();
    
    if (input == "1")
    {
        FoodItem ft = new FoodItem();
        ft.FoodName();
        Console.WriteLine(ft.foodName + " added to inventory");
        foodList.Add(ft);
    }

    if (input == "2")
    {
        for (int i = 0; i < foodList.Count; i++)
        {
            Console.WriteLine((i+1) + ". " + foodList[i].foodName);
        }
        int toDelete = 0;
        Console.Write("Which food would you like to delete?");
        toDelete = int.Parse(Console.ReadLine());
        if (toDelete > 0 && toDelete <= foodList.Count)
        {
            Console.WriteLine(foodList[toDelete - 1].foodName + " successfully deleted!");
            foodList.RemoveAt(toDelete - 1);
        }
        else 
        {
            Console.WriteLine("Invalid selection.");
        }
    }
    if (input == "3")
    {
        Console.WriteLine("Name\tCategory\tQuantity\tExpiration Date");
        for (int i = 0; i < foodList.Count; i++)
        {
            Console.WriteLine(foodList[i].foodName + "\t" + foodList[i].foodCategory + "\t"+"\t" + foodList[i].foodQuantity + "\t" + foodList[i].foodDate);
        }
    }

    if (input == "4")
    {
        Console.WriteLine("Thank you for using our system!");
        break;
    }
}while(true) ;





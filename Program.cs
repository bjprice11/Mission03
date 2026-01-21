//Brandon Price
using Mission03;

//Starts the system
Console.WriteLine("Welcome to the Food Bank Inventory System");

//Creates a list to store the food items
List<FoodItem> foodList = new List<FoodItem>();

//This will continue until the user exits
do {
    //Prints menu about what the user can do and get input
    int input = 0;
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Add Food Item");
    Console.WriteLine("2. Delete Food Item");
    Console.WriteLine("3. Print List of Current Food Items");
    Console.WriteLine("4. Exit");
    input = int.Parse(Console.ReadLine());
    
    //Adding a food item
    if (input == 1)
    {
        //Creates a new food item through the FoodItem Constructor
        FoodItem ft = new FoodItem();
        Console.WriteLine(ft.foodName + " added to inventory");
        //Adds that food to the food list
        foodList.Add(ft);
    }

    //Deletes a food item
    if (input == 2)
    {
        //Builds list of foodItems
        for (int i = 0; i < foodList.Count; i++)
        {
            Console.WriteLine((i+1) + ". " + foodList[i].foodName);
        }
        
        //Allows user to pick a food they want to delete
        int toDelete = 0;
        Console.Write("Which food would you like to delete?");
        toDelete = int.Parse(Console.ReadLine());
        
        //Takes input, uses that in the list, -1 because the index starts at 0
        if (toDelete > 0 && toDelete <= foodList.Count)
        {
            Console.WriteLine(foodList[toDelete - 1].foodName + " successfully deleted!");
            foodList.RemoveAt(toDelete - 1);
        }
        //Error handling
        else 
        {
            Console.WriteLine("Invalid selection.");
        }
    }
    
    //Lists out the Items and their Characteristics
    if (input == 3)
    {
        Console.WriteLine("Name\tCategory\tQuantity\tExpiration Date");
        for (int i = 0; i < foodList.Count; i++)
        {
            Console.WriteLine(foodList[i].foodName + "\t" + foodList[i].foodCategory + "\t"+"\t" + foodList[i].foodQuantity + "\t" + foodList[i].foodDate);
        }
    }

    //Exits loop
    if (input == 4)
    {
        Console.WriteLine("Thank you for using our system!");
        break;
    }

    //Error handling
    else
    {
        Console.WriteLine("Invalid selection.");
    }
}while(true) ;





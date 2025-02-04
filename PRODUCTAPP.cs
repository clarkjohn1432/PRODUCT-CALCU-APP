using System;
class MainProduct {
    
    public static void Main(String[] args) {
        String choice = "";
        bool addMore = true;
        string addChoice = "";

        Product apple = new Product(10);
        Product banana = new Product(15);
        Product watermelon = new Product(20);

        Console.WriteLine("-*WELCOME TO GROCECY CALCULATION APPLICATION*-");
        Console.WriteLine("-----\t\t\t\t-----");
        Console.WriteLine("ITEMS\t\t\t\tPRICES");
        Console.WriteLine("Banana\t\t\t\t15");
        Console.WriteLine("Apple\t\t\t\t10");
        Console.WriteLine("WaterMelon\t\t\t20");
        do
        {
            Console.WriteLine("\n[1] Add a Product");
            Console.WriteLine("[2] Exit");
            Console.Write("Enter a number: ");
            choice = Convert.ToString(Console.ReadLine());
            switch (choice) 
            {
                case "1":
                    int input = 0, quantity = 0;
                    double total;
                    Console.Write("\nAVAILABLE PRODUCTS \n");
                    Console.WriteLine("[1] Banana ");
                    Console.WriteLine("[2] Apple");
                    Console.WriteLine("[3] WaterMelon");
                    Console.WriteLine("You may now choose a Products: \n");
                    input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1: 
                            Console.Write("Quantity: ");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = (double)banana.getPrice() * quantity;
                            break;

                        case 2: 
                            Console.Write("Quantity: ");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = (double)apple.getPrice() * quantity;
                            break;

                        case 3:
                            Console.Write("Quantity: ");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = (double)watermelon.getPrice() * quantity;
                            break;

                        default:
                            Console.WriteLine("Invalid choice! Please choose again.");
                            continue;
                    }

                        if (total <= 100)
                            Console.WriteLine("Total Price: " + total);
                        else if (total > 100)
                        {
                            total = total * 0.10;
                            Console.WriteLine("Total Price: " + total);
                        }
                        else if (total > 200)
                        {
                            total = total * 0.15;
                            Console.WriteLine("Total Price: " + total);
                        }
                        else if (total > 500)
                        {
                            total = total * 0.20;
                            Console.WriteLine("Total Price: " + total);
                        }


                        break;
                case "2":
                    Console.WriteLine("Thankyou! Please, Visit me sometimes.");

                    break;
                default:
                    Console.WriteLine("Error! Please Try again");

                    break;
            }
        } while (choice != "2");
    }
}
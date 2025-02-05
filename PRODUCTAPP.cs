using System;

class MainProduct
{
    public static void Main(String[] args)
    {
        string choice = "";
        double total = 0;
        Product apple = new Product("Apple", 10);
        Product banana = new Product("Banana", 15);
        Product watermelon = new Product("WaterMelon", 20);

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
                    do
                    {
                    int input = 0, quantity = 0;
                    double partialTotal = 0; 
                    Console.Write("\nAVAILABLE PRODUCTS \n");
                    Console.WriteLine("[1] Banana ");
                    Console.WriteLine("[2] Apple");
                    Console.WriteLine("[3] WaterMelon");
                    Console.WriteLine("You may now choose a Product: \n");
                    input = Convert.ToInt32(Console.ReadLine());

                        switch (input)
                        {
                            case 1:
                                Console.Write("Product: " + banana.getProductName() + "\nQuantity: ");
                                quantity = Convert.ToInt32(Console.ReadLine());
                                partialTotal = banana.getPrice() * quantity;
                                break;

                            case 2:
                                Console.Write("Product: " + apple.getProductName() + "\nQuantity: ");
                                quantity = Convert.ToInt32(Console.ReadLine());
                                partialTotal = apple.getPrice() * quantity;
                                break;

                            case 3:
                                Console.Write("Product: " + watermelon.getProductName() + "\nQuantity: ");
                                quantity = Convert.ToInt32(Console.ReadLine());
                                partialTotal = watermelon.getPrice() * quantity;
                                break;

                            default:
                                Console.WriteLine("Invalid choice! Please choose again.");
                                continue;
                        }

                        if (partialTotal <= 100) //di ni ma discountan
                        {
                            Console.WriteLine("Partial Price of the Product: $" + partialTotal);
                        }
                        else if (partialTotal > 100 && partialTotal <= 200)
                        {
                            partialTotal = partialTotal * 0.90; // 10% discount ani
                            Console.WriteLine("Partial Price of the Product: $" + partialTotal);
                        }
                        else if (partialTotal > 200 && partialTotal <= 500)
                        {
                            partialTotal = partialTotal * 0.85; // 15% discount ani
                            Console.WriteLine("Partial Price of the Product: $" + partialTotal);
                        }
                        else if (partialTotal > 500)
                        {
                            partialTotal = partialTotal * 0.80; // 20% discount ani
                            Console.WriteLine("Partial Price of the Product: $" + partialTotal);
                        }

                        // if mo add pa syag product i display sa niya diri
                        total += partialTotal;
                        //gi gamitan ra nakog number kay di ko kabaw mo convert into string mo error waahhh T.T 
                        Console.WriteLine("Would you like to add another Product? [1] For Yes and [2] for No: ");
                        int scan = Convert.ToInt32(Console.ReadLine());
                        if (scan == 2)
                        {
                            Console.WriteLine("The Total Price of all Products is: $" + total); //if 2 which No kay mo balik sya sa menu nga question²
                            break;
                        }
                        else if (scan == 1)
                        {
                            continue; //if 1 which is Yes mo continue ra syag loop(add products)
                        }
                    } while (true);
                    
                    break;

                case "2":
                    Console.WriteLine("Thank you! Please, visit me sometimes.");
                    break;

                default:
                    Console.WriteLine("Error! Please Try again");
                    break;
            }

        } while (choice != "2");
    }
}

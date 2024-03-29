//Name: Rupesh Shrestha(C0908441)
//Date: 2024 - 03 - 17

//Main class or entry point
using AssignmentThree;
using System.Net;

class Program
{
    public static void Main(string[] args)
    {
        List<House> houses = new List<House>();
        List<Condo> apartments = new List<Condo>();
        int choice = Menu();
        while(choice == 1 || choice == 2 || choice == 3)
        {
            if (choice == 1)
            {
                House house = GetHouseObject();
                houses.Add(house);
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("A house is added to the list!!");
                Console.WriteLine($"House Info: \n\n{house.ToString()}");
                Console.WriteLine("----------------------------------\n");
                choice = Menu();
                continue;
            }
            else if (choice == 2)
            {
                Condo appartment = GetApartmentObject();
                apartments.Add(appartment);
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("An apartment is added to the list!!");
                Console.WriteLine($"House Info: \n\n{appartment.ToString()}");
                Console.WriteLine("----------------------------------\n");
                choice = Menu();
                continue;
            }
            else
            {
                Console.WriteLine("Thank You!!");
                break;
            }

        }

        
    }

    public static House GetHouseObject()
    {
        //Initialize variables to store residence components
        double price = 0;
        double squareFeet = 0;
        int yearBuilt = 2000;
        bool isValid = false;

        String garage, type, condition;
        Console.WriteLine("Enter the house information: ");
        Console.WriteLine("-------------");
        //Create a valid Address object 
        Address address = GetValidAddress();

        // Prompt the user for residence information until a valid residence is entered
        do
        {
            Console.Write("Enter price: ");
            isValid = double.TryParse(Console.ReadLine(), out price);
            if (!isValid || price < 0)
                Console.WriteLine("Please enter a valid price.");
        } while (!isValid || price < 0);

        do
        {
            Console.Write("Enter square feet: ");
            isValid = double.TryParse(Console.ReadLine(), out squareFeet);
            if (!isValid || squareFeet < 0)
                Console.WriteLine("Please enter a valid square feet value!");
        } while (!isValid || squareFeet < 0);

        do
        {
            Console.Write("Enter year built: ");
            isValid = int.TryParse(Console.ReadLine(), out yearBuilt);
            if (!isValid || yearBuilt < 1900 || yearBuilt > DateTime.Now.Year)
                Console.WriteLine($"Please enter a valid year!");
        } while (!isValid || yearBuilt <= 1900 || yearBuilt > DateTime.Now.Year);
        do
        {
            Console.WriteLine("Does it have garage ? yes or no?: ");
            garage = Console.ReadLine().ToLower();
            if (garage != "yes" && garage != "no")
                Console.WriteLine("Invalid input!! Enter 'yes' or 'no'.");
        } while (garage != "yes" && garage != "no");

        do
        {
            Console.WriteLine("Is this a detached house? type \"detached\" or \"attached\": ");

            type = Console.ReadLine().ToLower();
            if (type != "detached" && type != "attached")
                Console.WriteLine("Invalid input!! Enter \"detached\" or \"attached\".");
        } while (type != "detached" && type != "attached");

        do
        {
            Console.WriteLine("Is the houe for sale or for rent? type \"for sale\" or \"for rent\"?: ");
            condition = Console.ReadLine().ToLower();
            if (condition != "for sale" && condition != "for rent")
                Console.WriteLine("Invalid input!! Enter 'for sale' or 'for rent'.");
        } while (condition != "for sale" && condition != "for rent");

        return new House(price, squareFeet, yearBuilt, address, garage, type, condition);
    }

    public static Condo GetApartmentObject()
    {
        //Initialize variables to store residence components
        double price = 0;
        double squareFeet = 0;
        int yearBuilt = 2000;
        bool isValid = false;

        int unit, floor;
        String parking;
        Console.WriteLine("Enter an apartment information: ");
        Console.WriteLine("-------------");
        //Create a valid Address object 
        Address address = GetValidAddress();

        // Prompt the user for residence information until a valid residence is entered
        do
        {
            Console.Write("Enter price: ");
            isValid = double.TryParse(Console.ReadLine(), out price);
            if (!isValid || price < 0)
                Console.WriteLine("Please enter a valid price.");
        } while (!isValid || price < 0);

        do
        {
            Console.Write("Enter square feet: ");
            isValid = double.TryParse(Console.ReadLine(), out squareFeet);
            if (!isValid || squareFeet < 0)
                Console.WriteLine("Please enter a valid square feet value!");
        } while (!isValid || squareFeet < 0);

        do
        {
            Console.Write("Enter year built: ");
            isValid = int.TryParse(Console.ReadLine(), out yearBuilt);
            if (!isValid || yearBuilt < 1900 || yearBuilt > DateTime.Now.Year)
                Console.WriteLine($"Please enter a valid year!");
        } while (!isValid || yearBuilt <= 1900 || yearBuilt > DateTime.Now.Year);
        do
        {
            Console.WriteLine("Enter the apartment Unit number: ");
            isValid = int.TryParse(Console.ReadLine(), out unit);
            if (!isValid || unit < 0 || unit > 300)
                Console.WriteLine("Invalid number! Enter a valid number between 1 and 300");
        } while (!isValid || unit < 0 || unit > 300);

        do
        {
            Console.WriteLine("Enter the apartment floor number: ");
            isValid = int.TryParse(Console.ReadLine(), out floor);
            if (!isValid || floor < 0 || floor > 100)
                Console.WriteLine("Invalid number! Enter a valid number between 1 and 100");
        } while (!isValid || floor < 0 || floor > 100);

        do
        {
            Console.WriteLine("Is there parking available? : type \"yes\" or \"no\"");
            parking = Console.ReadLine().ToLower();
            if (parking != "yes" && parking != "no")
                Console.WriteLine("Invalid value! Enter \"yes\" or \"no\"");
        } while (parking != "yes" && parking != "no");


        return new Condo(price, squareFeet, yearBuilt, address, unit, floor, parking);
    }

    public static int Menu()
    {
        int choice = 0;
        do
        {
            Console.WriteLine("Enter 1: to add a House");
            Console.WriteLine("Enter 2: to add an apartment");
            Console.WriteLine("Enter 3: to quit");
            Console.WriteLine("Enter Your Choice: ");
            int.TryParse(Console.ReadLine(), out choice);
            if(!choice.Equals(1) && !choice.Equals(2) && !choice.Equals(3))
            {
                Console.WriteLine("Invalid choice!");
            }
        } while (!choice.Equals(1) && !choice.Equals(2) && !choice.Equals(3));


        return choice;
    }

    // Method to prompt user for address information until a valid address is entered
    public static Address GetValidAddress()
    {
        string street = "";
        string city = "";
        string region = "";
        string postalCode = "";

        while (string.IsNullOrWhiteSpace(street) || street.Length < 3)
        {
            Console.WriteLine("Enter valid Street Name: ");
            street = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(city) || city.Length < 3)
        {
            Console.WriteLine("Enter valid Municipality Name: ");
            city = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(region) || region.Length < 3)
        {
            Console.WriteLine("Enter valid Region Name: ");
            region = Console.ReadLine();
        }

        while (postalCode.Length != 6)
        {
            Console.WriteLine("Enter 6 character Postal Code: ");
            postalCode = Console.ReadLine();
        }
        return new Address(street, city, region, postalCode);
    }
}
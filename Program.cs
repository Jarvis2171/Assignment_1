using System;

class VirtualPet
{
    private string petType;
    private string petName;
    private int hunger;
    private int happiness;
    private int health;

    public VirtualPet(string type, string name)
    {
        petType = type;
        petName = name;
        hunger = 5;
        happiness = 5;
        health = 5;
    }

    public void Feed()
    {
        Console.WriteLine($"Feeding {petName}...");
        hunger -= 2;
        health += 1;

        DisplayStats();
    }

    public void Play()
    {
        Console.WriteLine($"Playing with {petName}...");
        happiness += 3;
        hunger += 1;

        DisplayStats();
    }

    public void Rest()
    {
        Console.WriteLine($"Letting {petName} rest...");
        health += 2;
        happiness -= 1;

        DisplayStats();
    }

    public void PassTime()
    {
        Console.WriteLine($"Time is passing for {petName}...");
        hunger += 1;
        happiness -= 1;

        DisplayStats();
    }

    private void DisplayStats()
    {
        Console.WriteLine($"Current Stats for {petName} ({petType}):");
        Console.WriteLine($"Hunger: {hunger}/10");
        Console.WriteLine($"Happiness: {happiness}/10");
        Console.WriteLine($"Health: {health}/10");

        CheckStatus();
    }

    private void CheckStatus()
    {
        if (hunger <= 2)
            Console.WriteLine($"{petName} is very hungry! Feed it soon.");
        else if (happiness <= 2)
            Console.WriteLine($"{petName} is unhappy. Play with it to boost its mood.");
        else if (health <= 2)
            Console.WriteLine($"{petName}'s health is low. Let it rest to recover.");

        if (hunger >= 8)
            Console.WriteLine($"{petName} is too full. Be mindful of its diet.");
        else if (happiness >= 8)
            Console.WriteLine($"{petName} is extremely happy!");

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Virtual Pet Simulator!");

        Console.Write("Enter the type of pet : ");
        string petType = Console.ReadLine();

        Console.Write("Enter the name of your pet: ");
        string petName = Console.ReadLine();

        VirtualPet myPet = new VirtualPet(petType, petName);

        Console.WriteLine($"Welcome, {petName} the {petType}!");

        while (true)
        {
            Console.WriteLine("Choose an action for your pet:");
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Play");
            Console.WriteLine("3. Rest");
            Console.WriteLine("4. Pass Time");
            Console.WriteLine("5. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    myPet.Feed();
                    break;

                case 2:
                    myPet.Play();
                    break;

                case 3:
                    myPet.Rest();
                    break;

                case 4:
                    myPet.PassTime();
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}

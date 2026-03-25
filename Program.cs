using CatRobTreasures_Assignment2_24005602;

class Program
{
    static void Main(string[] args)
    {
        Player cat = new Player("P012", "Connie", 1);
        Item treasure = new Item("I100", "Salmon Genie", 500);
        Guard security = new Guard("Corgi", 10);

        Console.WriteLine(" ^'_'^Game Start: Cat Rob Treasures ^'_'^ ");
        security.Patrol();
        cat.Move("Right");

        Console.WriteLine("\nFinding Treasure...");
        treasure.GetItem();
        cat.PickItem("Salmon Genie");

        Console.WriteLine("\nSecurity Check...");
        security.DetectPlayer(true);
        Console.WriteLine($"Current Guard Alert: {security.AlertLevel}%");
    }
}
//Jag vill skaffa dagar.

System.Console.WriteLine("Hello, welcome to this forest of adventures.. says the Gnome");
System.Console.WriteLine("The crazy Gnome of the Red Forest");

Console.WriteLine("Press ENTER to continue..");
Console.ReadLine();

System.Console.WriteLine("Gnome: Do you want to be a Bowman or a Swordsman?");



string answer = "";

     

while (answer != "bowman" || answer != "swordsman")
{
    answer = Console.ReadLine().ToLower();

    if (answer == "bowman")
    {
        System.Console.WriteLine("Gnome: So you are a master at archery?");
        System.Console.WriteLine("Gnome: Take these items! Press ENTER to recieve.");
        Console.ReadLine();

        string[] bowmanItems =
        [
            "Epirus(Bow)",
            "Arrow Quiver",
            "Light Armour",
            "Medium Apple-Sack"
        ];

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"{i + 1}. {bowmanItems[i]}");
        }
        break;
    }
    else if (answer == "swordsman")
    {
        System.Console.WriteLine("Gnome: You do look like a renowned knight..");
        System.Console.WriteLine("Gnome: Take these items! Press ENTER to recieve.");
        Console.ReadLine();

        string[] swordsmanItems =
        [
            "Excalibur(Sword)",
            "Heavy Armour",
            "Large Apple-Sack"
        ];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{i + 1}. {swordsmanItems[i]}");
        }
        break;
    }
    else
    {
        Console.WriteLine("You need to choose between a Bowman and a Swordsman!");
    }
}
Console.ReadLine();
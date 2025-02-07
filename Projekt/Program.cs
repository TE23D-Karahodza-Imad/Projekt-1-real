//Jag vill skaffa dagar.

System.Console.WriteLine("Hello, welcome to this forest of adventures.. says the Gnome");
System.Console.WriteLine("The crazy Gnome of the Red Forest");

Console.WriteLine("Press ENTER to continue..");
Console.ReadLine();

System.Console.WriteLine("Gnome: Do you want to be a Bowman or a Swordsman?");

 
static string answer = "";
static void Main()
    {
        ChooseClass();
    }
    
static void ChooseClass()

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

System.Console.WriteLine("Gnome: Great choice, tho you will have to use your class to your advantage..");
System.Console.WriteLine("Gnome: Against the Knight army!");
System.Console.WriteLine("Gnome: We have been ambushing them in small groups since we were born..");
Console.WriteLine("Press ENTER to continue..");
Console.ReadLine();


System.Console.WriteLine("Gnome: Would you like to help us?..");
System.Console.WriteLine("Yes (Story continues) --- No (Story ends)");

while (answer != "yes" || answer != "no")
{
    answer = Console.ReadLine().ToLower();

    if( answer == "yes")
    {
        System.Console.WriteLine("Follow me.. to our crowded inn.");
        break;
    }

    else if( answer == "no")
    {
        System.Console.WriteLine("Gnome: I wish you luck.. goodbye..");
        Console.WriteLine("Press ENTER to continue..");
        Console.ReadLine();
        System.Console.WriteLine("You wander off, never to be seen again..");
        Environment.Exit(0);

    }
    
    else
    {
        System.Console.WriteLine("You need to answer with a yes or no!");
    }

}
Console.WriteLine("Press ENTER to continue..");
Console.ReadLine();

System.Console.WriteLine("As you enter the inn, you are greeted by many.. even given a dirty look, for being different.");
System.Console.WriteLine("Innkeeper: Take this beer potion and drink!");
Console.WriteLine("Press ENTER to continue..");
Console.ReadLine();

System.Console.WriteLine("Some time passes and there are loud screams outside the Inn..");
System.Console.WriteLine("You hear someone scream.. AAAA THEY ARE HERE!");
Console.WriteLine("Press ENTER to continue..");
Console.ReadLine();

System.Console.WriteLine("Gnome: The knights.. they are raiding us!");
System.Console.WriteLine("Gnome: EVERYONE RUN!");
Console.WriteLine("Press ENTER to continue..");
Console.ReadLine();

System.Console.WriteLine("You choose not to and use your class to your advantage..");
Console.WriteLine("Press ENTER to continue..");
Console.ReadLine();

while (answer != "bowman" || answer != "swordsman")
{
    answer = Console.ReadLine().ToLower();

    if (answer == "bowman")
    {
        System.Console.WriteLine("They burst trough the doors.. but you are behind the counter.. shooting at any knight you see.");
        System.Console.WriteLine("You shoot and shoot but the arrows in your quiver run out..");
        Console.WriteLine("Press ENTER to continue..");
        Console.ReadLine();


    }
    
}

Console.ReadLine();

// Jag vill göra nu att de attackerar the "INN" och att det finns en fight.
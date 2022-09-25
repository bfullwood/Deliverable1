// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many people are we making PB&J sandwiches for?");
int num = int.Parse(Console.ReadLine());



while (true)
{
    int totalSlicesPerloaf = 28;
    int totalTableSpoonsPerPB = 32;
    int totalTeaspoonPerJelly = 48;



    double totalSlicesNeeded = (num * 2);
    double totalTablespoonsofPB = (num * 2);
    double totalTeaspoonsOfJelly = (num * 4);



    Console.WriteLine("You Need");
    Console.WriteLine("");



    Console.WriteLine(totalSlicesNeeded + " slices of bread.");
    Console.WriteLine(totalTablespoonsofPB + " tablespoons of peanut butter ");
    Console.WriteLine(totalTeaspoonsOfJelly + " teaspoons of jelly ");



    Console.WriteLine("Which is");
    Console.WriteLine("");



    double totalLoavesNeeded = Math.Ceiling(totalSlicesNeeded / totalSlicesPerloaf);
    double totalJarsOfPB = Math.Ceiling(totalTablespoonsofPB / totalTableSpoonsPerPB);
    double totalJarsOfJelly = Math.Ceiling(totalTeaspoonsOfJelly / totalTeaspoonPerJelly);



    Console.WriteLine(totalLoavesNeeded + " loaves of bread ");
    Console.WriteLine(totalJarsOfPB + " jars of peanut butter ");
    Console.WriteLine(totalJarsOfJelly + " jars of jelly ");



    Console.WriteLine("Would you like to start the program over? (Y/N)");
    var restart = Console.ReadLine();



    if (restart.Equals("N", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
}
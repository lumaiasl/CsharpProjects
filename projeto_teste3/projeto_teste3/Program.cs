using System.Globalization;
using System.Numerics;

//string[] fraudulentOrderIDs = new string[3];

//fraudulentOrderIDs[0] = "A123";
//fraudulentOrderIDs[1] = "B456";
//fraudulentOrderIDs[2] = "C789";

string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassing First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.\n\n");

string[] names = ["Bob", "Connie", "Fred", "Sally\n\n"];
foreach (string name in names)
{
    Console.WriteLine(name);
}

int total = 0;
int bin = 0;

int[] numbers = [100, 200, 250, 375, 500];
foreach (int number in numbers)
{
    total += number;
    bin++;
    Console.WriteLine($"Bin {bin} = {number} items (Running total: {total})");
}
Console.WriteLine($"We have {total} items in inventory.\n\n");

string[] inventoryIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

Console.WriteLine($"All inventory IDs: ");
foreach (string ID in inventoryIDs)
{
    Console.WriteLine(ID);
}
foreach (string ID in inventoryIDs)
{
    if (ID.StartsWith("B"))
    {
        Console.WriteLine("ID starts with B: " + ID);
    }
}

foreach (string ID in inventoryIDs)
{
    if (ID.Length > 4)
    {
        Console.WriteLine("ID length greater than 4: " + ID);
    }
}
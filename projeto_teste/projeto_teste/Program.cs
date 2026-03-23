
Random dice1 = new Random();

int roll1 = dice1.Next(1, 7);
int roll2 = dice1.Next(1, 7);
int roll3 = dice1.Next(1, 7);

int total1 = roll1 + roll2 + roll3;

Console.WriteLine($"You rolled: {roll1}, {roll2}, {roll3}. Total = {total1}\n");

if ((roll1 == roll2) && (roll3 == roll1))
{
    if (roll1 == 6)
    {
        Console.WriteLine("WOW!!! YOU GOT A TRIPLE OF 6'S!");
        total1 += 6;
        Console.WriteLine($"Your new total is: {total1}\n");
    }
    else
    {
        Console.WriteLine("You got triples!!! +6 to your total");
        total1 += 6;
        Console.WriteLine($"Your new total is: {total1}\n");
    }
}

else if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1))
{
    Console.WriteLine("You got doubles!!! +2 to your total");
    total1 += 2;
    Console.WriteLine($"Your new total is: {total1}\n");
}

Random dice2 = new Random();

int roll4 = dice2.Next(1, 7);
int roll5 = dice2.Next(1, 7);
int roll6 = dice2.Next(1, 7);

int total2 = roll4 + roll5 + roll6;

Console.WriteLine($"\nI rolled: {roll4}, {roll5}, {roll6}. Total = {total2}\n");

if ((roll4 == roll5) && (roll4 == roll6))
{
    if (roll4 == 6)
    {
        Console.WriteLine("WOW!!! I GOT A TRIPLE OF 6'S!");
        total2 += 6;
        Console.WriteLine($"My new total is: {total2}\n");
    }
    else
    {
        Console.WriteLine("I got triples!!! +6 to my total");
        total2 += 6;
        Console.WriteLine($"My new total is: {total2}\n");
    }
}

else if ((roll4 == roll5) || (roll5 == roll6) || (roll6 == roll4))
{
    Console.WriteLine("I got doubles!!! +2 to my total");
    total2 += 2;
    Console.WriteLine($"My new total is: {total2}\n");
}

if (total1 > total2)
{
    Console.WriteLine("You win!");
}

if (total1 == total2)
{
    Console.WriteLine("It's a tie!");
}

if (total1 < total2)
{
    Console.WriteLine("I win!");
}
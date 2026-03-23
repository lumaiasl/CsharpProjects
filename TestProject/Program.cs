using System.Globalization;
using System.Numerics;

/* O código seguinte trata-se de um pequeno jogo de dados com um sistema de pontuação baseado
em sorte e combinações diferentes entre 3 dados*/

Random dice = new Random();

int yourNumber1 = dice.Next(1, 7);
int yourNumber2 = dice.Next(1, 7);
int yourNumber3 = dice.Next(1, 7);

int yourTotal = yourNumber1 + yourNumber2 + yourNumber3;

int myNumber1 = dice.Next(1, 7);
int myNumber2 = dice.Next(1, 7);
int myNumber3 = dice.Next(1, 7);

int myTotal = myNumber1 + myNumber2 + myNumber3;

List<int> yourNumbers = new List<int> {yourNumber1, yourNumber2, yourNumber3};
List<int> myNumbers = new List<int> {myNumber1, myNumber2, myNumber3};

yourNumbers.Sort();
myNumbers.Sort();

bool isMySequence = myNumbers.SequenceEqual(Enumerable.Range(myNumbers.Min(), myNumbers.Count()));
bool isYourSequence = yourNumbers.SequenceEqual(Enumerable.Range(yourNumbers.Min(), yourNumbers.Count()));

Console.WriteLine($"\nYou rolled {yourNumber1}, {yourNumber2} and {yourNumber3} || Your total is {yourTotal}\n");

if (isYourSequence == true)
{
    Console.WriteLine($"You rolled a sequence, now you can roll another dice");
    int yourBonusDice = dice.Next(1, 7);
    Console.WriteLine($"You rolled a {yourBonusDice}");
    yourTotal += yourBonusDice;
    Console.WriteLine($"Your new total is: {yourTotal}");
}

if (yourNumber1 == yourNumber2 && yourNumber1 == yourNumber3)
{
    yourTotal += 4;
    Console.WriteLine("You rolled triples, Cool!!! +4 to your score");
    Console.WriteLine($"Your new score is: {yourTotal}");
}

else if (yourNumber1 == yourNumber2 || yourNumber1 == yourNumber3 || yourNumber2 == yourNumber3)
{
    yourTotal += 2;
    Console.WriteLine("Wow, you rolled doubles! +2 to your score");
    Console.WriteLine($"Your new score is: {yourTotal}");
}

Console.WriteLine($"\nI rolled {myNumber1}, {myNumber2} and {myNumber3} || My total is {myTotal}\n");

if (isMySequence == true)
{
    Console.WriteLine("I rolled a sequence, now I can roll another dice");
    int myBonusDice = dice.Next(1, 7);
    Console.WriteLine($"Your rolled a {myBonusDice}");
    myTotal += myBonusDice;
    Console.WriteLine($"My new total is: {myTotal}");
}

if (myNumber1 == myNumber2 && myNumber2 == myNumber3)
{
    myTotal += 4;
    Console.WriteLine("I rolled triples, Cool!!! +4 to my score");
    Console.WriteLine($"My new score is: {myTotal}");
}

else if (myNumber1 == myNumber2 || myNumber1 == myNumber3 || myNumber2 == myNumber3)
{
        myTotal += 2;
    Console.WriteLine("Wow, I rolled doubles! +2 to my score");
    Console.WriteLine($"My new score is: {myTotal}");
}

if (yourTotal > myTotal)
{
    Console.WriteLine("\n\nYou won\n");
}

if (yourTotal < myTotal)
{
    Console.WriteLine("\n\nI won\n");
}

if (yourTotal == myTotal)
{
    Console.WriteLine("\n\nThat's a tie\n");
}
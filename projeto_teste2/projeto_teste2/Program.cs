Random random = new Random();

int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if ((daysUntilExpiration <= 10) && (daysUntilExpiration > 5))
{
    Console.WriteLine($"Your subscription will expire soon in {daysUntilExpiration}. Renew now!");
}

else if ((daysUntilExpiration <= 5) && (daysUntilExpiration > 1))
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage += 10;
    Console.WriteLine($"Renew now and save {discountPercentage}%");
}

else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage += 20;
    Console.WriteLine($"Renew now and save {discountPercentage}%");
}

else if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else
{
    Console.WriteLine($"Your subscription is active. It will expire in {daysUntilExpiration} days.");
}

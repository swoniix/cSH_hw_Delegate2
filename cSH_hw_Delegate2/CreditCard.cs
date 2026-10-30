namespace cSH_hw_Delegate2;

public class CreditCard
{
    public string CardNumber;
    public string OwnerName;
    private string Pin;
    public string ExpirationDate;
    private double CreditLimit;
    public double Money;

    public CreditCard(string cardNumber, string ownerName, string pin, string expirationDate, double creditLimit, double money)
    {
        CardNumber = cardNumber;
        OwnerName = ownerName;
        Pin = pin;
        ExpirationDate = expirationDate;
        CreditLimit = creditLimit;
        Money = money;
    }

    public void AddMoney(double amount)
    {
        Money += amount;
        Console.WriteLine($"Money added: {amount}");
    }
    public void SpendMoney(double amount)
    {
        if (amount <= Money)
        {
            Money -= amount;
            Console.WriteLine("Spent: " + amount);
            Console.WriteLine("Balance left: " + Money);
        }
        else if (Money + CreditLimit >= amount)
        {
            double creditMoney = amount - Money;
            Money = 0;

            Console.WriteLine("Credit funds are now being used.");
            Console.WriteLine("Credit used: " + creditMoney);

            if (creditMoney == CreditLimit)
            {
                Console.WriteLine("Credit limit reached.");
            }
        }
        else
        {
            Console.WriteLine("Not enough money.");
        }
    }
    public void ChangePin(string oldPin, string newPin)
    {
        if (Pin == oldPin)
        {
            Pin = newPin;
            Console.WriteLine("PIN changed.");
        }
        else
        {
            Console.WriteLine("Incorrect old PIN.");
        }
    }

    public void CheckMoneyAmount(double amount)
    {
        if (Money >= amount)
        {
            Console.WriteLine("The specified amount has been reached: " + amount);
        }
    }
    public void ShowInfo()
    {
        Console.WriteLine("Card number: " + CardNumber);
        Console.WriteLine("Owner: " + OwnerName);
        Console.WriteLine("Expiration date: " + ExpirationDate);
        Console.WriteLine("Credit limit: " + CreditLimit);
        Console.WriteLine("Money in account: " + Money);
    }
}
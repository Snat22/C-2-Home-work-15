namespace Task3;

public class BankAccount
{
    public int AccountNumber { get; set; }

    public string Owner { get; set; }

    decimal _balance;

public BankAccount(decimal balance)
{
    _balance = balance;
}
    public void TopUp(decimal amount)
    {
        _balance+= amount;
        System.Console.WriteLine("Balance popolnen");
    }

    public void WithDraw(decimal amount)
    {
        if (amount > 0 && amount <= _balance)
        {
            _balance -= amount;
            Console.WriteLine("Withdrawal successful. Remaining balance: " + _balance);
        }
        else
        {
             Console.WriteLine("Withdrawal failed. Invalid amount or insufficient funds.");
        }
        }

        public decimal PrintStatement()
{
    System.Console.WriteLine($"Account Number: {AccountNumber}");
    // Печать выписки
    Console.WriteLine("Выписка со счета:");
    Console.WriteLine(Owner);
    Console.WriteLine("Текущий баланс: " + _balance +"$");

    return _balance;
    }
    }


namespace DefaultNamespace;

public class Program
{
    static void Main()
    {
        try
        {
            Account heikkisAccount = new("Heikki's account", 100);

            try
            {
                heikkisAccount.Withdrawal(50);
                Console.WriteLine("\nThe balance of Heikki's account is now: " + heikkisAccount.Balance);
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(exception.Message);
                Console.ResetColor();
            }
        }
        catch (Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(exception.Message);
            Console.ResetColor();
        }

        try
        {
            Account heikkisSwissAccount = new("Heikki's account in Switzerland", 100000);

            try
            {
                heikkisSwissAccount.Deposit(10000);
                Console.WriteLine("\nThe balance of Heikki's other account is now: " + heikkisSwissAccount.Balance);
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(exception.Message);
                Console.ResetColor();
            }
        }
        catch (Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(exception.Message);
            Console.ResetColor();
        }
    }
}

class Account
{
    private string _nameAccount;
    private double _balance;

    public Account(string name, double balance)
    {
        if (balance < 0)
            throw new ArgumentException("\nInitial balance cannot be negative.", nameof(balance));

        _nameAccount = name;
        _balance = balance;
    }

    public double Balance => _balance;

    public void Deposit(double addMoney)
    {
        if (addMoney > 0 && addMoney <= 10000)
            _balance += addMoney;
        else
            throw new ArgumentException("\nERROR: Daily deposit limit up to 10,000.", nameof(addMoney));
    }

    public void Withdrawal(double withdrawalMoney)
    {
        if (withdrawalMoney <= _balance)
            _balance -= withdrawalMoney;
        else
            throw new InvalidOperationException("\nERROR: You cannot withdraw more money than you have in your account.");
    }
}
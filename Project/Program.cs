namespace WithdrawalException;

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
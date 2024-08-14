namespace BankAccountClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account  = new BankAccount(Guid.NewGuid(), "Jack", "Mangosa", 100);
          
             account.FirstName = "Nicolas";
             account.LastName = "Kazadi";
             Console.WriteLine(account.FirstName);
             Console.WriteLine(account.LastName);

             account.Deposit(100);
             Console.WriteLine(account.Balance);
             account.Withdraw(50);
             
            account.Deposit(-50);  
            account.Withdraw(200);  
            account.Deposit(50);  
            account.Withdraw(30);

        }
    }
}

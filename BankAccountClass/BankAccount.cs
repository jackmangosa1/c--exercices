namespace BankAccountClass
{
    public class BankAccount
    {
        public Guid UserId { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Balance { get; private set; } = 0;

        public BankAccount(Guid userId, string firstName, string lastName, int balance)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }

        public void Deposit(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Successfully deposited {amount}. New balance is {Balance}.");
        }

        public void Withdraw(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Successfully withdrew {amount}. New balance is {Balance}.");
        }






    }
}


namespace P04_polimorphism.models
{
    public class AccountAccount
    {
        public class BankAccount
        {
            public string AccountHolder { get; }
            public decimal Balance { get; private set; }

            public BankAccount() { }
            //conduckter ไม่สามารถสืบถ่อดได้
            public BankAccount(string accountHolder, decimal balance = 0)
            {
                AccountHolder = accountHolder;
                Balance = balance;
            }

            public string Deposit(decimal amount)
            {
                Balance += amount;
                return $"Deposited ${amount}. New balance: ${Balance}";
            }

            public string Withdraw(decimal amount)
            {
                if (amount > Balance)
                {
                    return "Insufficient funds";
                }

                Balance -= amount;
                return $"Withdrew ${amount}. New balance: ${Balance}";
            }

            //virtual อนุญาติให้นำไปดเขี่ยน โค้ดใหม่ได้
            public virtual string GetBalance()
            {
                return $"Current balance for {AccountHolder}: ${Balance}";
            }


        }
       

    }
}

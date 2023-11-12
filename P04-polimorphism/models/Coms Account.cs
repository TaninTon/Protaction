

using static P04_polimorphism.models.AccountAccount;

namespace P04_polimorphism.models
{
    public class ComsAccount : BankAccount
    {
        public decimal Interest { get; set; }
        public void DisplayAccount(char select)
        {
            if(select == 'A') {
                Console.WriteLine(base.GetBalance());

            }else
            {
                Console.WriteLine(GetBalance());
            }
        }
            //override method สามารถใช้คำสั่งเดี่ยวกันได้
            public override string GetBalance()
        {
            return $"This account from ComsAccount is {AccountHolder}\n" +
                $" has money {Balance} Baht\n Interest = {Interest}";
        }

        public void CalInterest(double rate = 0.0)
        {
            Interest = Balance * (decimal)rate;
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.ComponentModel.Design;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace student
{
    internal class NewAccount : BackAccount
    {
        public NewAccount()
        {
            Id = 1;
            Name = "test";

            // private Password สืบถ่อดไม่ได้
            Rate = 100;

            //protected สืบถ่อดได้ แต่เรียกใช่ทางอ้อม
            Money = 100;

           
            }

          public void WithDraw(int money)
          {
            if (Money > 0 && money <= Money) ;
            {
                Money -= money;
                Console.WriteLine(Money);
            }
             else
            {
                Console.WriteLine("Connot Withdraw");
            }
          }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    internal class BackAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private string Password { get; set; }
        protected double Money { get; set; }
        internal double Rate { get; set; }

        public void SetPassword(string Password)
        {
            this.Password = Password;

            if(this.Password == "1234")
            {
                Console.WriteLine(Money);
            }
            else
            {
                Console.WriteLine(Money);
            }
        }

    }
}

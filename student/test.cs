using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//การเรียกใช่ internal ในโปรเจคเดียวกันสามารถทำได้
namespace student
{
    public class test
    {
        public test()
        {
            var temp = new BackAccount();
            temp.Rate = 100;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juliusz_Final
{
    public class MyMethods
    {
        public static int AgeCustomer(DateTime birthDate)
        {
            int age = 0;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age = DateTime.Now.Year - birthDate.Year - 1;
            }
            else
            {
                age = DateTime.Now.Year - birthDate.Year;
            }
            return age;
        }
    }
}

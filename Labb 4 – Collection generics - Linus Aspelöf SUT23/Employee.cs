using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4___Collection_generics___Linus_Aspelöf_SUT23
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Employee other = (Employee)obj;
            return ID == other.ID && Name == other.Name &&
                   Gender == other.Gender && Salary == other.Salary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID, Name, Gender, Salary);
        }
    }
}

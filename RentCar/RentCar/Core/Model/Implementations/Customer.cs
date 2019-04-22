using RentCar.Core.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Model.Implementations
{
    public class Customer : ModelBase, ICustomer
    {
        public Customer(string firstName) : base(firstName) { }

        public string lastName { get; set; }

        public string phoneNumber { get; set; }

        public string eMail { get; set; }

        public int age { get; set; }

        public bool genderIsMale { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Model.Interfaces
{
    public interface ICustomer : IModelBase
    {        
        string lastName { get; set; }

        string phoneNumber { get; set; }

        string eMail { get; set; }

        int age { get; set; }

        bool genderIsMale { get; set; }
    }
}

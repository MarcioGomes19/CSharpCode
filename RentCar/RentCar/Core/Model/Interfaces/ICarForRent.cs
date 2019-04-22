using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Model.Interfaces
{
    public interface ICarForRent : IModelBase
    {        
        ICar car { get; set; }

        int number { get; set; }

        bool isAutomatic { get; set; }

        decimal Price { get; set; }
    }
}

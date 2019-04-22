using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Model.Interfaces
{
    public interface IModelBase
    {
        string Id { get; set; }

        string name { get; set; }
    }
}

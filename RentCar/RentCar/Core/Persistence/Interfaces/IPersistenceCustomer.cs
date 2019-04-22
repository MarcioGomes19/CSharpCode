using RentCar.Core.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Persistence.Interfaces
{
    public interface IPersistenceCustomer
    {
        ICustomer GetById(string id);

        List<ICustomer> GetByName(string partialName);

        List<ICustomer> GetAll();

        void Delete(ICustomer customer);

        void Insert(ICustomer customer);

        void Update(ICustomer customer);
    }
}

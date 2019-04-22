using RentCar.Core.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Persistence.Interfaces
{
    public interface IPersistenceCarForRent
    {
        ICarForRent GetById(string id);

        List<ICarForRent> GetByName(string partialName);

        List<ICarForRent> GetAll();

        void Delete(ICarForRent carForRent);

        void Insert(ICarForRent carForRent);

        void Update(ICarForRent carForRent);
    }
}

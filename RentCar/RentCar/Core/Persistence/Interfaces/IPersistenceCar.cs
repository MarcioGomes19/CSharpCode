using RentCar.Core.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Persistence.Interfaces
{
    public interface IPersistenceCar
    {
        ICar GetById(string id);

        List<ICar> GetByName(string partialName);

        List<ICar> GetAll();

        void Delete(ICar car);

        void Insert(ICar car);

        void Update(ICar car);
    }
}

using RentCar.Core.Model;
using RentCar.Core.Model.Implementations;
using RentCar.Core.Model.Interfaces;
using RentCar.Core.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Persistence.Implementations
{
    public class PersistenceCarForRent : PersistenceBase<ICarForRent>, IPersistenceCarForRent
    {
        private static IPersistenceCarForRent instance;
        public static IPersistenceCarForRent getInstance()
        {
            if (instance == null)
            {
                instance = new PersistenceCarForRent();                
            }

            return instance;
        }

        public void Delete(ICarForRent car)
        {
            base.DeleteBase(car);
        }

        public void Insert(ICarForRent car)
        {
            base.InsertBase(car);
        }

        public void Update(ICarForRent car)
        {
            base.UpdateBase(car);
        }

        public List<ICarForRent> GetAll()
        {
            return base.GetAllBase();
        }

        protected override void ValidedateInsert(ICarForRent carForRent)
        {
            base.ValidedateBase(carForRent);            
        }

        public ICarForRent GetById(string id)
        {
            return base.GetByIdBase(id);
        }

        public List<ICarForRent> GetByName(string partialName)
        {
            return base.GetByNameBase(partialName);
        }        
    }
}

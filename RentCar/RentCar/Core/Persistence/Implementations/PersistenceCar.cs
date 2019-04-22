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
    public class PersistenceCar : PersistenceBase<ICar>, IPersistenceCar
    {
        private static IPersistenceCar instance;
        public static IPersistenceCar getInstance()
        {
            if (instance == null)
            {
                instance = new PersistenceCar();

                // create mock objects
                instance.Insert(new Car("Mercedes S500"));
                instance.Insert(new Car("BMW x4"));
                instance.Insert(new Car("Rang Rover Evouge"));
                instance.Insert(new Car("Porche Boxter"));
                instance.Insert(new Car("Lamborghini Hurcan"));
                instance.Insert(new Car("Bentley CT"));
            }

            return instance;
        }

        public void Delete(ICar car)
        {
            base.DeleteBase(car);
        }

        public void Insert(ICar car)
        {
            base.InsertBase(car);
        }

        public void Update(ICar car)
        {
            base.UpdateBase(car);
        }

        public List<ICar> GetAll()
        {
            return base.GetAllBase();
        }

        protected override void ValidedateInsert(ICar car)
        {
            base.ValidedateBase(car);
            if (base.GetAllBase().Find(x => Functions.StringCompare(x.name, car.name)) != null) {
                throw new MyException("car already exists with this name");
            }
        }

        public ICar GetById(string id)
        {
            return base.GetByIdBase(id);
        }

        public List<ICar> GetByName(string partialName)
        {
            return base.GetByNameBase(partialName);
        }        
    }
}

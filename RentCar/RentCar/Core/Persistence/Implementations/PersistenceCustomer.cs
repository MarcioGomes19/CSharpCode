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
    public class PersistenceCustomer : PersistenceBase<ICustomer>, IPersistenceCustomer
    {
        private static IPersistenceCustomer instance;
        public static IPersistenceCustomer getInstance()
        {
            if (instance == null)
            {
                instance = new PersistenceCustomer();                
            }

            return instance;
        }

        public void Delete(ICustomer customer)
        {
            base.DeleteBase(customer);
        }

        public void Insert(ICustomer customer)
        {
            base.InsertBase(customer);
        }

        public void Update(ICustomer customer)
        {
            base.UpdateBase(customer);
        }

        public List<ICustomer> GetAll()
        {
            return base.GetAllBase();
        }

        protected override void ValidedateInsert(ICustomer customer)
        {
            base.ValidedateBase(customer);            
        }

        public ICustomer GetById(string id)
        {
            return base.GetByIdBase(id);
        }

        public List<ICustomer> GetByName(string partialName)
        {
            return base.GetByNameBase(partialName);
        }        
    }
}

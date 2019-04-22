using RentCar.Core.Model;
using RentCar.Core.Model.Implementations;
using RentCar.Core.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Persistence.Implementations
{
    public abstract class PersistenceBase<T> where T : IModelBase
    {
        private List<T> persitencesList;
        
        public PersistenceBase()
        {
            this.persitencesList = new List<T>();
        }

        protected T GetByIdBase(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) return default(T);

            return this.persitencesList.Find(x => Functions.StringCompare(x.Id, id));
        }

        protected List<T> GetByNameBase(string partialName)
        {
            if (string.IsNullOrWhiteSpace(partialName)) return this.persitencesList;

            return this.persitencesList.FindAll(x => Functions.StringStart(x.name, partialName));
        }

        protected List<T> GetAllBase()
        {
            return this.persitencesList;
        }

        protected void DeleteBase(T model)
        {
            if (model == null) return;

            this.DeleteBase(model.Id);
        }

        protected void DeleteBase(string id)
        {
            T modelPersistence = this.GetByIdBase(id);
            if (modelPersistence == null) return;
            this.persitencesList.Remove(modelPersistence);
        }

        protected void InsertBase(T model)
        {
            this.ValidedateInsert(model);
            this.persitencesList.Add(model);
        }

        protected void UpdateBase(T model)
        {
            this.ValidedateUpdate(model);

            T modelPersistence = this.GetByIdBase(model.Id);
            if (modelPersistence == null) return;

            this.persitencesList.Remove(modelPersistence);

            try
            {
                InsertBase(model);
            }
            catch
            {
                this.persitencesList.Add(modelPersistence);
                throw;
            }            
        }

        protected abstract void ValidedateInsert(T model);

        protected virtual void ValidedateUpdate(T model)
        {
            ValidedateBase(model);
        }

        protected virtual void ValidedateDelete(T model)
        {
            ValidedateBase(model);
        }

        protected virtual void ValidedateBase(T model)
        {
            if (model == null) throw new MyException("empty");

            if (string.IsNullOrWhiteSpace(model.Id)) throw new MyException("id need");

            if (string.IsNullOrWhiteSpace(model.name)) throw new MyException("name need");
        }
    }
}

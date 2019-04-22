using RentCar.Core.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Model.Implementations
{
    public class ModelBase : IModelBase
    {
        public ModelBase()
        {
            this.GenerateID();
        }

        public ModelBase(string name) : this()
        {
            this.name = name;
        }

        public ModelBase(string id, string name)
        {
            this.Id = id;
            this.name = name;
        }

        public string Id { get; set; }

        public string name { get; set; }

        public virtual void GenerateID()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}

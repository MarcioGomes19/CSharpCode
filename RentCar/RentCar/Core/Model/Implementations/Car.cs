using RentCar.Core.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Model.Implementations
{
    public class Car : ModelBase, ICar
    {
        public Car() : base() { }

        public Car(string name) : base(name) { }

        public Car(string id, string name) : base(id, name) { }                    
    }
}

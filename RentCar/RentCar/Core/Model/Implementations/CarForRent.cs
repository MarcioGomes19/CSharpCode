using RentCar.Core.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Model.Implementations
{
    public class CarForRent : ModelBase, ICarForRent
    {
        public CarForRent() : base() {}

        public CarForRent(ICar car) : base()
        {
            this.car = car;
        }

        private ICar _car;
        public ICar car
        {
            get { return _car; }
            set
            {
                _car = value;
                if (value != null)
                    base.name = _car.name;
            }
        }

        public int number { get; set; }

        public bool isAutomatic { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            if (car != null) return _car.name;
            return string.Empty;
        }
    }
}

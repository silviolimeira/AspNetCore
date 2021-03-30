using System;
using System.Collections.Generic;
using System.Text;

namespace Enterprise1.Entities
{
    class OutSourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourceEmployee() : base() { }

        public OutSourceEmployee(string name, int hours, double valuePerHour, double additionalcharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalcharge;
        }


        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }

    }
}

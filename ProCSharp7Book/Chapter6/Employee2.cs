using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter6
{
    partial class Employee
    {
        //Contain a BenefitPackage object.
        protected BenefitPackage emptBenefits = new BenefitPackage();

        //Expose certain benefit behaviors of object.
        public double GetBenefitCost()
        {
            return emptBenefits.ComputePayDeduction();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Atividade_INHERITANCE_AND_POLYMORPHISM
{
    class EmployeOutsourced : Employe
    {
        public double Additional { get; set; }

        public EmployeOutsourced(string name, int hours, double valueperhour, double additional)
            : base(name, hours, valueperhour)
        {
            Additional = additional;
        }

        public override double Payment()
        {
            return base.Payment() + Additional + (Hours * ValuePerHour * 0.16);
        }
    }

}

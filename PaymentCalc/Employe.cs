using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Atividade_INHERITANCE_AND_POLYMORPHISM
{
    class Employe
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employe(string name, int hours, double valueperhour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valueperhour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}

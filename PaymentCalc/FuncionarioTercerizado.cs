using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Atividade_INHERITANCE_AND_POLYMORPHISM
{
    class FuncionarioTerceirizado : Funcionario
    {
        public double Adicional { get; set; }

        public FuncionarioTerceirizado(string nome, int horas, double valorporhora, double adicional)
            : base(nome, horas, valorporhora)
        {
            Adicional = adicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + Adicional + (Horas * ValorPorHora * 0.16);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFuncarios.Model
{
    public class FuncionarioComissionado : Funcionario
    {
        public decimal TotalVendas { get; set; }
        public decimal PercentualComissao { get; set; }

        //construtor
        public FuncionarioComissionado(
            int matricula, string nome, decimal salarioBase,
            decimal totalVendas, decimal percentualComissao
            )
            : base (matricula, nome, salarioBase)
        {
            TotalVendas = totalVendas;
            PercentualComissao = percentualComissao;
        }

        public override decimal CalcularSalario()
        {
            return SalarioBase + (TotalVendas * PercentualComissao / 100m);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFuncarios.Model
{
    // : (dois pontos) é o extends do Java
    public class FuncionarioCLT : Funcionario
    {
        //construtor:
        public FuncionarioCLT(int matricula, string nome, decimal salarioBase)
            : base(matricula, nome, salarioBase)
        {

        }

        public override decimal CalcularSalario()
        {
            return SalarioBase;
        }

    }
}

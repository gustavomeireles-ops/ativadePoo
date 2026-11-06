using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividadePoo
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        
        public string? Cargo { get; set; }

        public decimal Salario { get; private set; } = 5000m; // Por conta do set estar privado não é possível atribuir um valor para ele por fora da classe, porém é possível ler ele
        
        //* Metodos

        public void AumentarSalario(decimal percentualAumento)
        {
           Salario += Salario * (percentualAumento / 100);
        }

        public void ConsultarSalario()
        {
            Console.WriteLine($"O salário do funcionário {Nome} que é do cargo {Cargo} é: {Salario:C}");
        }
    }
}
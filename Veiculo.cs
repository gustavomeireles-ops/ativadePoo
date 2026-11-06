using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividadePoo
{
    public class Veiculo 
    {
        public int Velocidade { get; private set; }

        public void alterarVelocidade(int velocidade)
        {
            if (velocidade > 0 && velocidade <= 200)
            {
                Velocidade = velocidade;
                Console.WriteLine($"Velocidade alterada para {Velocidade} km/h");
            }
        }
    }
}
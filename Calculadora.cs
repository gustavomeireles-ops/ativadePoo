using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividadePoo
{
    public class Calculadora
    {
        public decimal Somar(decimal a, decimal b)
        {
            decimal resultado = a + b;
            Console.WriteLine($"A soma de {a} e {b} é: {resultado}");
            return resultado;
        }

        public decimal Subtrair(decimal a, decimal b)
        {
            decimal resultado = a - b;
            Console.WriteLine($"A subtração de {a} e {b} é: {resultado}");
            return resultado;
        }

        public decimal Multiplicar(decimal a, decimal b)
        {
            decimal resultado = a * b;
            Console.WriteLine($"A multiplicação de {a} e {b} é: {resultado}");
            return resultado;
        }

        public static decimal Dividir(decimal a, decimal b)
        {
            if (b == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
                return 0;
            }
            else
            {
                decimal resultado = a / b;
                Console.WriteLine($"A divisão de {a} e {b} é: {resultado}");
                return resultado;
            }
            
        }

    }
}
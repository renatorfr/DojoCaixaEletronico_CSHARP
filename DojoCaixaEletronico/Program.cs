using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DojoCaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                CaixaEletronico caixaEletronico = new CaixaEletronico();
                Console.WriteLine("Quando você gostaria de sacar?");
                int valorSacar = Int32.Parse(Console.ReadLine());
                Dictionary<int, int> notas = caixaEletronico.saque(valorSacar);
                foreach (KeyValuePair<int, int> linha in notas)
                {
                    Console.WriteLine(linha.Key + " : " + linha.Value);
                }

                Console.WriteLine();
            }
        }
    }
}

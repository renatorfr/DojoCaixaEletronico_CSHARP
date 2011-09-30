using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DojoCaixaEletronico
{
    public class CaixaEletronico
    {
        Dictionary<int, int> NOTAS_DISPONIVEIS = new Dictionary<int, int> { { 10, 10 }, { 20, 20 }, { 50, 50 }, { 100, 100 } };
        Dictionary<int, int> resultado = new Dictionary<int, int>();

        public Dictionary<int, int> saque(int valor)
        {
            while (valor > 0)
            {
                if (valor >= 100)
                {
                    AdicionarNotaNaSaida(100);
                    valor -= 100;
                }
                else if (valor >= 50)
                {
                    AdicionarNotaNaSaida(50);
                    valor -= 50;
                }
                else if (valor >= 20)
                {
                    AdicionarNotaNaSaida(20);
                    valor -= 20;
                }
                else if (valor >= 10)
                {
                    AdicionarNotaNaSaida(10);
                    valor -= 10;
                }
            }

            return resultado;
        }

        private void AdicionarNotaNaSaida(int valorDaNota)
        {
            if (resultado.ContainsKey(valorDaNota))
            {
                resultado[valorDaNota]++;
            }
            else
            {
                resultado.Add(NOTAS_DISPONIVEIS[valorDaNota], 1);
            }
        }
    }
}

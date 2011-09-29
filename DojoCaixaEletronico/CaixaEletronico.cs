using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DojoCaixaEletronico
{
    public class CaixaEletronico
    {
        int[] NOTAS_DISPONIVEIS = { 10, 20, 50, 100 };

        public Dictionary<int, int> saque(int valor)
        {
            Dictionary<int, int> resultado = new Dictionary<int, int>();

            if (valor == 10)
            {
                resultado.Add(NOTAS_DISPONIVEIS[1], 1);
            }

            return resultado;
        }
    }
}

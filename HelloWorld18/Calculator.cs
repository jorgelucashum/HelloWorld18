using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld18
{
    class Calculator
    {
        // AVISO!! 'ref' e 'out' são consideradas 'code smells' (design ruim) e devem ser evitadas.
        // elas só existe porque é necessário para integrar com a linguagem 'C++'

        // Modificadores de parâmetros
        public static void Triple(ref int x) // 'ref' serve para fazer referencia à variável original da função 'main' mesmo sem retorno, a variável passada como parâmetro deve ter sido iniciada.
        {
            x = x * 3;
        }

        public static void Triple2(int origin, out int result) // 'out' serve para fazer referencia à variável original só que sem necessidade da variável passada como parâmetro ter sido iniciada.
        {
            result = origin * 3;
        }
    }
}

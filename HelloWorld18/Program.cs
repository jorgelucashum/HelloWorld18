using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld18
{
    class Program
    {
        // AVISO!! 'ref' e 'out' são consideradas 'code smells' (design ruim) e devem ser evitadas.
        // elas só existe porque é necessário para integrar com a linguagem 'C++'
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a); // Modificador de parâmetro 'ref' sendo usado.
            Console.WriteLine(a);

            a = 5;
            int triple;
            Calculator.Triple2(a, out triple); // Modificador de parâmetro 'out' sendo usado.
            Console.WriteLine(triple);
        }
    }
}

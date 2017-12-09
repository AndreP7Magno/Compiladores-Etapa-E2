using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiladores_Etapa_E2
{
    class Program
    {
        static void Main(string[] args)
        {
            AntlrInputStream inputStream = new AntlrInputStream(Console.In);

            GramaticaLexer lexer = new GramaticaLexer(inputStream);


            CommonTokenStream bts = new CommonTokenStream(lexer);
            bts.Fill();
            IToken tk = lexer.NextToken();

            GramaticaParser p = new GramaticaParser(bts);
            p.program();
            Console.ReadKey();
        }
    }
}

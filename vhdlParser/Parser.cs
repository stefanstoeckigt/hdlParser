using Antlr4.Runtime;
using System;
using vhdl;

// How-To: https://tomassetti.me/getting-started-with-antlr-in-csharp/
namespace VHDL.Parser
{
    public class Parser
    {
        public Parser (string data)
        {
            try
            {

                AntlrInputStream inputStream = new AntlrInputStream(data);
                var lexer = new vhdlLexer(inputStream);
                var commonTokenStream = new CommonTokenStream(lexer);
                var parser = new vhdlParser(commonTokenStream);

                var architectureParser = new parser.ArchitectureParser(parser.architecture_body());


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }


    }
}

using Antlr4.Runtime;
using System;
using vhdl;

// How-To: https://tomassetti.me/getting-started-with-antlr-in-csharp/
namespace VHDL.Parser
{
    public class Parser
    {
        /// <summary>
        /// Parser error logger.
        /// </summary>
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public Parser (string data)
        {
            try
            {

                AntlrInputStream inputStream = new AntlrInputStream(data);
                var lexer = new vhdlLexer(inputStream);
                var commonTokenStream = new CommonTokenStream(lexer);
                var parser = new vhdlParser(commonTokenStream);

                var designFileParser = new visitors.VisitDesign_file(parser.design_file());
     

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }


    }
}

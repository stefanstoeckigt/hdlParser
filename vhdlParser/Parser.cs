using Antlr4.Runtime;
using NLog;
using System;
using System.IO;
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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="designFile"></param>
        public Parser (String data, out visitors.VisitDesign_file designFile)
        {
            try
            {
                AntlrInputStream inputStream = new AntlrInputStream(data);
                var lexer = new vhdlLexer(inputStream);
                var commonTokenStream = new CommonTokenStream(lexer);
                var parser = new vhdlParser(commonTokenStream);

                designFile = new visitors.VisitDesign_file(parser.design_file());

            }
            catch (Exception ex)
            {
                designFile = null;
                logger.Log(LogLevel.Error, ex, "VHDL Parsing: {0}", data);
            }
        }


    }
}

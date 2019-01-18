using System;
using System.Collections.Generic;
using System.Text;
using vhdl;

namespace VHDL.Parser.visitors
{
    class VisitArchitecture
    {
        /// <summary>
        /// Parser error logger.
        /// </summary>
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// architecture_body
        /// : ARCHITECTURE identifier OF identifier IS
        /// architecture_declarative_part
        /// BEGIN
        /// architecture_statement_part
        /// END ( ARCHITECTURE )? ( identifier )? SEMI
        /// ;
        /// </summary>
        /// <param name="ctx"></param>
        public VisitArchitecture(vhdlParser.Architecture_bodyContext ctx)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using vhdl;

namespace VHDL.Parser.parser
{
    class ArchitectureParser
    {
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
        public ArchitectureParser(vhdlParser.Architecture_bodyContext ctx)
        {
        }
    }
}

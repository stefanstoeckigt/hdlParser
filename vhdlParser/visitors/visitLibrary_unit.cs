using System;
using System.Collections.Generic;
using System.Text;
using vhdl;

namespace VHDL.Parser.visitors
{
    class VisitLibrary_unit
    {
        /// <summary>
        /// library_unit
        /// : secondary_unit | primary_unit
        /// ;
        /// </summary>
        /// <param name="ctx"></param>
        public VisitLibrary_unit(vhdlParser.Library_unitContext ctx)
        {
            if (ctx == null)
                return;
        }
    }
}

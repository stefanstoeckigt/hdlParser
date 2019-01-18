using System;
using System.Collections.Generic;
using System.Text;
using vhdl;

namespace VHDL.Parser.visitors
{
    class VisitContext_item
    {
        /// <summary>
        /// Parser error logger.
        /// </summary>
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public VisitContext_item(vhdlParser.Context_itemContext ctx)
        {
            if (ctx == null)
                return;

        }
    }
}

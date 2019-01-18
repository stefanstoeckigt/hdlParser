using System;
using System.Collections.Generic;
using System.Text;
using vhdl;

namespace VHDL.Parser.visitors
{
    public class VisitDesign_unit
    {
        /// <summary>
        /// Parser error logger.
        /// </summary>
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 
        /// </summary>
        public VisitContext_clause visitContext_clause { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public VisitLibrary_unit visitLibrary_unit { get; set; }

        /// <summary> 
        /// design_unit
        /// : context_clause library_unit
        /// ;
        /// </summary>
        /// <param name="ctx"></param>
        public VisitDesign_unit(vhdlParser.Design_unitContext ctx)
        {
            if (ctx == null)
                return;

            visitContext_clause = new VisitContext_clause(ctx.context_clause());
            visitLibrary_unit = new VisitLibrary_unit(ctx.library_unit());

        }
    }
}

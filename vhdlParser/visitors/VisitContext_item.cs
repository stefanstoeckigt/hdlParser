using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using vhdl;

namespace VHDL.Parser.visitors
{
    interface IVisitContext_item
    {

    }

    [JsonObject(MemberSerialization.OptIn)]
    public class VisitContext_item: IVisitContext_item
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

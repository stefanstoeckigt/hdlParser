using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using vhdl;

namespace VHDL.Parser.visitors
{
    [JsonObject(MemberSerialization.OptIn)]
    public class VisitContext_clause
    {
        /// <summary>
        /// Parser error logger.
        /// </summary>
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "Context Items")]
        public List<VisitContext_item> visitContext_items { get; set; }

        /// <summary>
        /// context_clause
        /// : ( context_item )*
        /// ;
        /// </summary>
        /// <param name="ctx"></param>
        public VisitContext_clause(vhdlParser.Context_clauseContext ctx)
        {
            visitContext_items = new List<VisitContext_item>();
            if (ctx == null)
                return;

            foreach (var item in ctx.context_item())
            {
                visitContext_items.Add(new VisitContext_item(item));
            }
        }
    }
}

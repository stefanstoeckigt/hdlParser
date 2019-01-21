using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using vhdl;

namespace VHDL.Parser.visitors
{
    interface IVisitIdentifier
    {
        string value { get; set; }
    }

    public class VisitIdentifier: IVisitIdentifier
    {
        /// <summary>
        /// Parser error logger.
        /// </summary>
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        [JsonProperty(PropertyName = "Value")]
        public string value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctx"></param>
        public VisitIdentifier(Object ctx)
        {
            this.Identifier((vhdlParser.IdentifierContext)ctx);
        }

        /// <summary>
        /// identifier :
        /// BASIC_IDENTIFIER
        /// | EXTENDED_IDENTIFIER
        /// ;
        /// </summary>
        /// <param name="ctx"></param>
        public void Identifier(vhdlParser.IdentifierContext ctx)
        {
            if (ctx != null)
                return;

            if (ctx.EXTENDED_IDENTIFIER() != null)
                this.value = ctx.EXTENDED_IDENTIFIER().GetText();
            if (ctx.BASIC_IDENTIFIER() != null)
                this.value = ctx.BASIC_IDENTIFIER().GetText();
                    
        }

    }
}

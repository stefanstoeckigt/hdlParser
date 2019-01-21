using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using vhdl;

namespace VHDL.Parser.visitors
{
    interface IVisitArchitecture
    {

    }

    public class VisitArchitecture: IVisitArchitecture
    {
        /// <summary>
        /// Parser error logger.
        /// </summary>
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "Identifier")]
        public VisitIdentifier identifier { get; set; }

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
            bool sameIdentifiers = ctx.identifier().All(item => item.GetText() == ctx.identifier().First().GetText());
            if (sameIdentifiers)
                identifier = new VisitIdentifier(ctx.identifier()[0]);

        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using vhdl;

namespace VHDL.Parser.visitors
{
    interface IVisitLibrary_unit
    {

    }

    [JsonObject(MemberSerialization.OptIn)]
    public class VisitLibrary_unit: IVisitLibrary_unit
    {
        /// <summary>
        /// Parser error logger.
        /// </summary>
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

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

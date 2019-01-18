﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using vhdl;

namespace VHDL.Parser.visitors
{
    public class VisitDesign_file
    {
        /// <summary>
        /// Parser error logger.
        /// </summary>
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "Design Units")]
        public List<VisitDesign_unit> visitDesign_units { get; set; }

        /// <summary>
        /// design_file
        /// : ( design_unit )* EOF
        /// ;
        /// </summary>
        /// <param name="ctx"></param>
        public VisitDesign_file(vhdlParser.Design_fileContext ctx)
        {
            visitDesign_units = new List<VisitDesign_unit>();
            if (ctx == null)
                return;

            foreach(var item in ctx.design_unit())
            {
                visitDesign_units.Add(new VisitDesign_unit(item));
            }

        }




    }
}

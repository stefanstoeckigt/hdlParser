﻿using System;
using System.Collections.Generic;
using System.Text;
using vhdl;

namespace VHDL.Parser.visitors
{
    class VisitDesign_file
    {

        /// <summary>
        /// 
        /// </summary>
        List<VisitDesign_unit> visitDesign_units { get; set; }

        /// <summary>
        /// design_file
        /// : ( design_unit )* EOF
        /// ;
        /// </summary>
        /// <param name="ctx"></param>
        public VisitDesign_file(vhdlParser.Design_fileContext ctx)
        {
            if (ctx == null)
                return;

            foreach(var item in ctx.design_unit())
            {
                visitDesign_units.Add(new VisitDesign_unit(item));
            }

        }




    }
}

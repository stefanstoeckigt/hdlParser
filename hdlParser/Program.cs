using System;
using System.IO;
using VHDL.Parser;

namespace HDL.Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@".\Examples\example01.vhd"))
            {
                VHDL.Parser.visitors.VisitDesign_file designFile;
                new VHDL.Parser.Parser(sr.ReadToEnd(), out designFile);
            }

        }
    }
}

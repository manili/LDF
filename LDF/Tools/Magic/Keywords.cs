using System.Collections.Generic;
using static LDF.Bases.ExternalPort;

namespace LDF.Tools.Magic
{
    public class Keywords
    {
        public static Dictionary<Classes, string> ClassesNames = new Dictionary<Classes, string>()
        {
            { Classes.input, "input" },
            { Classes.output, "output" },
            { Classes.inout, "inout" },
            { Classes.tristate, "tristate" },
            { Classes.bidirectional, "bidirectional" },
            { Classes.feedthrough, "feedthrough" }
        };

        public static Dictionary<Uses, string> UsesNames = new Dictionary<Uses, string>()
        {
            { Uses.signal, "signal" },
            { Uses.power, "power" },
            { Uses.ground, "ground" },
            { Uses.digital, "digital" },
            { Uses.clock, "clock" },
            { Uses.analog, "analog" }
        };

        public static Dictionary<Shapes, string> ShapesNames = new Dictionary<Shapes, string>()
        {
            { Shapes.ring, "ring" },
            { Shapes.abutment, "abutment" },
            { Shapes.feedthrough, "feedthrough" }
        };
    }
}

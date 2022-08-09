using LDF.Bases.MOSFET;

namespace Sky130
{
    public class NFET_01v8 : MOSFETBase
    {
        public NFET_01v8(string Name, bool AlignHorizontally, bool CreateRing, MOSFETFingerConfiguration[] MOSFETFingers)
                : base(Name, AlignHorizontally, CreateRing, Constraint.NFET_01v8, MOSFETFingers)
        {

        }
    }

    public class PFET_01v8 : MOSFETBase
    {
        public PFET_01v8(string Name, bool AlignHorizontally, bool CreateRing, MOSFETFingerConfiguration[] MOSFETFingers)
                : base(Name, AlignHorizontally, CreateRing, Constraint.PFET_01v8, MOSFETFingers)
        {

        }
    }

    public class NFET_01v8_LVT : MOSFETBase
    {
        public NFET_01v8_LVT(string Name, bool AlignHorizontally, bool CreateRing, MOSFETFingerConfiguration[] MOSFETFingers)
                : base(Name, AlignHorizontally, CreateRing, Constraint.NFET_01v8_LVT, MOSFETFingers)
        {

        }
    }

    public class PFET_01v8_LVT : MOSFETBase
    {
        public PFET_01v8_LVT(string Name, bool AlignHorizontally, bool CreateRing, MOSFETFingerConfiguration[] MOSFETFingers)
                : base(Name, AlignHorizontally, CreateRing, Constraint.PFET_01v8_LVT, MOSFETFingers)
        {

        }
    }

    public class PFET_01v8_HVT : MOSFETBase
    {
        public PFET_01v8_HVT(string Name, bool AlignHorizontally, bool CreateRing, MOSFETFingerConfiguration[] MOSFETFingers)
                : base(Name, AlignHorizontally, CreateRing, Constraint.PFET_01v8_HVT, MOSFETFingers)
        {

        }
    }

    public class NFET_G5v0D10v5 : MOSFETBase
    {
        public NFET_G5v0D10v5(string Name, bool AlignHorizontally, bool CreateRing, MOSFETFingerConfiguration[] MOSFETFingers)
                : base(Name, AlignHorizontally, CreateRing, Constraint.NFET_G5v0D10v5, MOSFETFingers)
        {

        }
    }

    public class PFET_G5v0D10v5 : MOSFETBase
    {
        public PFET_G5v0D10v5(string Name, bool AlignHorizontally, bool CreateRing, MOSFETFingerConfiguration[] MOSFETFingers)
                : base(Name, AlignHorizontally, CreateRing, Constraint.PFET_G5v0D10v5, MOSFETFingers)
        {

        }
    }
}

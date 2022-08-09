using LDF.Bases.MOSFET;
using static Sky130.Layers;

namespace Sky130
{
    public static class Constraint
    {
        public static MOSFETType NFET_01v8 = new MOSFETType()
        {
            Name = "NFET_01v8",

            Poly = GetLayerById(Id.polysilicon),
            Diffusion = GetLayerById(Id.ndiffusion),
            Transistor = GetLayerById(Id.ntransistor),
            Substrate = GetLayerById(Id.pwell),
            Tap = GetLayerById(Id.psubstratepdiff),
            PolyContact = GetLayerById(Id.pcontact),
            DiffusionContact = GetLayerById(Id.ndcontact),
            TapContact = GetLayerById(Id.psubstratepcontact),
            LocalInterconnectContact = GetLayerById(Id.viali),
            LocalInterconnect = GetLayerById(Id.locali),
            Metal1 = GetLayerById(Id.metal1)
        };

        public static MOSFETType PFET_01v8 = new MOSFETType()
        {
            Name = "PFET_01v8",

            Poly = GetLayerById(Id.polysilicon),
            Diffusion = GetLayerById(Id.pdiffusion),
            Transistor = GetLayerById(Id.ptransistor),
            Substrate = GetLayerById(Id.nwell),
            Tap = GetLayerById(Id.nsubstratendiff),
            PolyContact = GetLayerById(Id.pcontact),
            DiffusionContact = GetLayerById(Id.pdcontact),
            TapContact = GetLayerById(Id.nsubstratencontact),
            LocalInterconnectContact = GetLayerById(Id.viali),
            LocalInterconnect = GetLayerById(Id.locali),
            Metal1 = GetLayerById(Id.metal1)
        };

        public static MOSFETType NFET_01v8_LVT = new MOSFETType()
        {
            Name = "NFET_01v8_LVT",

            Poly = GetLayerById(Id.polysilicon),
            Diffusion = GetLayerById(Id.ndiffusion),
            Transistor = GetLayerById(Id.nfetlvt),
            Substrate = GetLayerById(Id.pwell),
            Tap = GetLayerById(Id.psubstratepdiff),
            PolyContact = GetLayerById(Id.pcontact),
            DiffusionContact = GetLayerById(Id.ndcontact),
            TapContact = GetLayerById(Id.psubstratepcontact),
            LocalInterconnectContact = GetLayerById(Id.viali),
            LocalInterconnect = GetLayerById(Id.locali),
            Metal1 = GetLayerById(Id.metal1)
        };

        public static MOSFETType PFET_01v8_LVT = new MOSFETType()
        {
            Name = "PFET_01v8_LVT",

            Poly = GetLayerById(Id.polysilicon),
            Diffusion = GetLayerById(Id.pdiffusion),
            Transistor = GetLayerById(Id.pfetlvt),
            Substrate = GetLayerById(Id.nwell),
            Tap = GetLayerById(Id.nsubstratendiff),
            PolyContact = GetLayerById(Id.pcontact),
            DiffusionContact = GetLayerById(Id.pdcontact),
            TapContact = GetLayerById(Id.nsubstratencontact),
            LocalInterconnectContact = GetLayerById(Id.viali),
            LocalInterconnect = GetLayerById(Id.locali),
            Metal1 = GetLayerById(Id.metal1)
        };

        public static MOSFETType PFET_01v8_HVT = new MOSFETType()
        {
            Name = "PFET_01v8_HVT",

            Poly = GetLayerById(Id.polysilicon),
            Diffusion = GetLayerById(Id.pdiffusion),
            Transistor = GetLayerById(Id.pfethvt),
            Substrate = GetLayerById(Id.nwell),
            Tap = GetLayerById(Id.nsubstratendiff),
            PolyContact = GetLayerById(Id.pcontact),
            DiffusionContact = GetLayerById(Id.pdcontact),
            TapContact = GetLayerById(Id.nsubstratencontact),
            LocalInterconnectContact = GetLayerById(Id.viali),
            LocalInterconnect = GetLayerById(Id.locali),
            Metal1 = GetLayerById(Id.metal1)
        };

        public static MOSFETType NFET_G5v0D10v5 = new MOSFETType()
        {
            Name = "NFET_G5v0D10v5",

            Poly = GetLayerById(Id.polysilicon),
            Diffusion = GetLayerById(Id.mvndiffusion),
            Transistor = GetLayerById(Id.mvntransistor),
            Substrate = GetLayerById(Id.pwell),
            Tap = GetLayerById(Id.mvpsubstratepdiff),
            PolyContact = GetLayerById(Id.pcontact),
            DiffusionContact = GetLayerById(Id.mvndcontact),
            TapContact = GetLayerById(Id.mvpsubstratepcontact),
            LocalInterconnectContact = GetLayerById(Id.viali),
            LocalInterconnect = GetLayerById(Id.locali),
            Metal1 = GetLayerById(Id.metal1)
        };

        public static MOSFETType PFET_G5v0D10v5 = new MOSFETType()
        {
            Name = "PFET_G5v0D10v5",

            Poly = GetLayerById(Id.polysilicon),
            Diffusion = GetLayerById(Id.mvpdiffusion),
            Transistor = GetLayerById(Id.mvptransistor),
            Substrate = GetLayerById(Id.nwell),
            Tap = GetLayerById(Id.mvnsubstratendiff),
            PolyContact = GetLayerById(Id.pcontact),
            DiffusionContact = GetLayerById(Id.mvpdcontact),
            TapContact = GetLayerById(Id.mvnsubstratencontact),
            LocalInterconnectContact = GetLayerById(Id.viali),
            LocalInterconnect = GetLayerById(Id.locali),
            Metal1 = GetLayerById(Id.metal1)
        };
    }
}

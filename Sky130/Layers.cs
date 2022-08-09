using System.Collections.Generic;
using LDF.Bases;

namespace Sky130
{
    public static class Layers
    {
        public enum Id
        {
            dnwell,
            isosubstrate,
            photodiode,
            nwell,
            pwell,
            rpwell,
            pbase,
            nbase,
            ntransistor,
            ptransistor,
            nntransistor,
            mvntransistor,
            mvptransistor,
            mvnntransistor,
            varactor,
            mvvaractor,
            pfetlvt,
            pfetmvt,
            pfethvt,
            nfetlvt,
            varactorhvt,
            ndiffusion,
            pdiffusion,
            mvndiffusion,
            mvpdiffusion,
            ndcontact,
            pdcontact,
            mvndcontact,
            mvpdcontact,
            psubstratepdiff,
            nsubstratendiff,
            mvpsubstratepdiff,
            mvnsubstratendiff,
            psubstratepcontact,
            nsubstratencontact,
            mvpsubstratepcontact,
            mvnsubstratencontact,
            polysilicon,
            pcontact,
            xpolycontact,
            npolyres,
            ppolyres,
            xpolyres,
            ndiffres,
            pdiffres,
            mvndiffres,
            mvpdiffres,
            rmp,
            pdiode,
            ndiode,
            nndiode,
            pdiodec,
            ndiodec,
            nndiodec,
            mvpdiode,
            mvndiode,
            mvpdiodec,
            mvndiodec,
            pdiodelvt,
            pdiodehvt,
            ndiodelvt,
            pdiodelvtc,
            pdiodehvtc,
            ndiodelvtc,
            locali,
            rlocali,
            viali,
            metal1,
            rmetal1,
            m2contact,
            padl,
            reram,
            metal2,
            rmetal2,
            m3contact,
            metal3,
            rmetal3,
            via3,
            mimcap,
            mimcapcontact,
            metal4,
            rmetal4,
            via4,
            mimcap2,
            mimcap2contact,
            metal5,
            rmetal5,
            mrdlcontact,
            metalrdl,
            pi2,
            ubm,
            res0p35,
            res0p69,
            res1p41,
            res2p85,
            res5p73
        }

        public static Layer GetLayerById(Id Id)
        {
            return
            Id == Id.dnwell ?
                new Layer
                {
                    Id = (uint)Id.dnwell,
                    Name = "dnwell",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.isosubstrate ?
                new Layer
                {
                    Id = (uint)Id.isosubstrate,
                    Name = "isosubstrate",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.photodiode ?
                new Layer
                {
                    Id = (uint)Id.photodiode,
                    Name = "photodiode",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.nwell ?
                new Layer
                {
                    Id = (uint)Id.nwell,
                    Name = "nwell",
                    MinLength = 0.840f,
                    MinWidth = 0.840f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {
                        { (uint)Id.pdiffusion, 0.180f },
                        { (uint)Id.mvpdiffusion, 0.180f },
                        { (uint)Id.nsubstratendiff, 0.180f },
                        { (uint)Id.mvnsubstratendiff, 0.330f },
                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.pwell ?
                new Layer
                {
                    Id = (uint)Id.pwell,
                    Name = "pwell",
                    MinLength = 0.840f,
                    MinWidth = 0.840f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {
                        { (uint)Id.ndiffusion, 0.180f },
                        { (uint)Id.mvndiffusion, 0.180f },
                        { (uint)Id.psubstratepdiff, 0.180f },
                        { (uint)Id.mvpsubstratepdiff, 0.330f },
                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.rpwell ?
                new Layer
                {
                    Id = (uint)Id.rpwell,
                    Name = "rpwell",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.pbase ?
                new Layer
                {
                    Id = (uint)Id.pbase,
                    Name = "pbase",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.nbase ?
                new Layer
                {
                    Id = (uint)Id.nbase,
                    Name = "nbase",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.ntransistor ?
                new Layer
                {
                    Id = (uint)Id.ntransistor,
                    Name = "ntransistor",
                    MinLength = 0.150f,
                    MinWidth = 0.420f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.ptransistor ?
                new Layer
                {
                    Id = (uint)Id.ptransistor,
                    Name = "ptransistor",
                    MinLength = 0.150f,
                    MinWidth = 0.420f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.nntransistor ?
                new Layer
                {
                    Id = (uint)Id.nntransistor,
                    Name = "nntransistor",
                    MinLength = 0.500f,
                    MinWidth = 0.420f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mvntransistor ?
                new Layer
                {
                    Id = (uint)Id.mvntransistor,
                    Name = "mvntransistor",
                    MinLength = 0.500f,
                    MinWidth = 0.420f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mvptransistor ?
                new Layer
                {
                    Id = (uint)Id.mvptransistor,
                    Name = "mvptransistor",
                    MinLength = 0.500f,
                    MinWidth = 0.420f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mvnntransistor ?
                new Layer
                {
                    Id = (uint)Id.mvnntransistor,
                    Name = "mvnntransistor",
                    MinLength = 0.900f,
                    MinWidth = 0.420f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.varactor ?
                new Layer
                {
                    Id = (uint)Id.varactor,
                    Name = "varactor",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mvvaractor ?
                new Layer
                {
                    Id = (uint)Id.mvvaractor,
                    Name = "mvvaractor",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.pfetlvt ?
                new Layer
                {
                    Id = (uint)Id.pfetlvt,
                    Name = "pfetlvt",
                    MinLength = 0.350f,
                    MinWidth = 0.420f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.pfetmvt ?
                new Layer
                {
                    Id = (uint)Id.pfetmvt,
                    Name = "pfetmvt",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.pfethvt ?
                new Layer
                {
                    Id = (uint)Id.pfethvt,
                    Name = "pfethvt",
                    MinLength = 0.150f,
                    MinWidth = 0.420f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.nfetlvt ?
                new Layer
                {
                    Id = (uint)Id.nfetlvt,
                    Name = "nfetlvt",
                    MinLength = 0.150f,
                    MinWidth = 0.420f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.varactorhvt ?
                new Layer
                {
                    Id = (uint)Id.varactorhvt,
                    Name = "varactorhvt",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.ndiffusion ?
                new Layer
                {
                    Id = (uint)Id.ndiffusion,
                    Name = "ndiffusion",
                    MinLength = 0.150f,
                    MinWidth = 0.150f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {
                        { (uint)Id.ntransistor, 0.250f },
                        { (uint)Id.nntransistor, 0.250f },
                        { (uint)Id.nfetlvt, 0.250f },
                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.pdiffusion, 0.270f },
                        { (uint)Id.ndiffusion, 0.270f },
                        { (uint)Id.psubstratepdiff, 0.270f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {
                        
                    },
                }
            : Id == Id.pdiffusion ?
                new Layer
                {
                    Id = (uint)Id.pdiffusion,
                    Name = "pdiffusion",
                    MinLength = 0.150f,
                    MinWidth = 0.150f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {
                        { (uint)Id.pfetlvt, 0.250f },
                        { (uint)Id.pfethvt, 0.250f },
                        { (uint)Id.ptransistor, 0.250f },
                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.nsubstratendiff, 0.270f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {
                        
                    },
                }
            : Id == Id.mvndiffusion ?
                new Layer
                {
                    Id = (uint)Id.mvndiffusion,
                    Name = "mvndiffusion",
                    MinLength = 0.150f,
                    MinWidth = 0.150f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {
                        { (uint)Id.mvntransistor, 0.250f },
                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.mvpsubstratepdiff, 0.370f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {
                        { (uint)Id.pwell, 0.330f },
                    },
                }
            : Id == Id.mvpdiffusion ?
                new Layer
                {
                    Id = (uint)Id.mvpdiffusion,
                    Name = "mvpdiffusion",
                    MinLength = 0.150f,
                    MinWidth = 0.150f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {
                        { (uint)Id.mvptransistor, 0.250f },
                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.mvnsubstratendiff, 0.370f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {
                        { (uint)Id.nwell, 0.330f },
                    },
                }
            : Id == Id.ndcontact ?
                new Layer
                {
                    Id = (uint)Id.ndcontact,
                    Name = "ndcontact",
                    MinLength = 0.170f,
                    MinWidth = 0.170f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.nfetlvt, 0.080f },
                        { (uint)Id.ntransistor, 0.080f },
                        { (uint)Id.ndcontact, 0.170f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {
                        { (uint)Id.ndiffusion, 0.060f },
                    },
                }
            : Id == Id.pdcontact ?
                new Layer
                {
                    Id = (uint)Id.pdcontact,
                    Name = "pdcontact",
                    MinLength = 0.170f,
                    MinWidth = 0.170f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.pfethvt, 0.080f },
                        { (uint)Id.pfetlvt, 0.060f },
                        { (uint)Id.ptransistor, 0.060f },
                        { (uint)Id.pdcontact, 0.170f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {
                        
                    },
                }
            : Id == Id.mvndcontact ?
                new Layer
                {
                    Id = (uint)Id.mvndcontact,
                    Name = "mvndcontact",
                    MinLength = 0.170f,
                    MinWidth = 0.170f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.ntransistor, 0.060f },
                        { (uint)Id.mvntransistor, 0.060f },
                        { (uint)Id.mvnntransistor, 0.060f },
                        { (uint)Id.mvndcontact, 0.170f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {
                        { (uint)Id.mvndiffusion, 0.060f },
                    },
                }
            : Id == Id.mvpdcontact ?
                new Layer
                {
                    Id = (uint)Id.mvpdcontact,
                    Name = "mvpdcontact",
                    MinLength = 0.170f,
                    MinWidth = 0.170f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.mvptransistor, 0.060f },
                        { (uint)Id.mvpdcontact, 0.170f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.psubstratepdiff ?
                new Layer
                {
                    Id = (uint)Id.psubstratepdiff,
                    Name = "psubstratepdiff",
                    MinLength = 0.150f,
                    MinWidth = 0.150f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.nsubstratendiff ?
                new Layer
                {
                    Id = (uint)Id.nsubstratendiff,
                    Name = "nsubstratendiff",
                    MinLength = 0.150f,
                    MinWidth = 0.150f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mvpsubstratepdiff ?
                new Layer
                {
                    Id = (uint)Id.mvpsubstratepdiff,
                    Name = "mvpsubstratepdiff",
                    MinLength = 0.150f,
                    MinWidth = 0.150f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.nsubstratendiff, 0.760f },
                        { (uint)Id.mvnsubstratendiff, 0.760f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mvnsubstratendiff ?
                new Layer
                {
                    Id = (uint)Id.mvnsubstratendiff,
                    Name = "mvnsubstratendiff",
                    MinLength = 0.150f,
                    MinWidth = 0.150f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.psubstratepdiff, 0.760f },
                        { (uint)Id.mvpsubstratepdiff, 0.760f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.psubstratepcontact ?
                new Layer
                {
                    Id = (uint)Id.psubstratepcontact,
                    Name = "psubstratepcontact",
                    MinLength = 0.170f,
                    MinWidth = 0.170f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.psubstratepcontact, 0.170f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.nsubstratencontact ?
                new Layer
                {
                    Id = (uint)Id.nsubstratencontact,
                    Name = "nsubstratencontact",
                    MinLength = 0.170f,
                    MinWidth = 0.170f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.nsubstratencontact, 0.170f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mvpsubstratepcontact ?
                new Layer
                {
                    Id = (uint)Id.mvpsubstratepcontact,
                    Name = "mvpsubstratepcontact",
                    MinLength = 0.170f,
                    MinWidth = 0.170f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.mvpsubstratepcontact, 0.170f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mvnsubstratencontact ?
                new Layer
                {
                    Id = (uint)Id.mvnsubstratencontact,
                    Name = "mvnsubstratencontact",
                    MinLength = 0.170f,
                    MinWidth = 0.170f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.mvnsubstratencontact, 0.170f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.polysilicon ?
                new Layer
                {
                    Id = (uint)Id.polysilicon,
                    Name = "polysilicon",
                    MinLength = 0.150f,
                    MinWidth = 0.150f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {
                        { (uint)Id.ptransistor, 0.130f },
                        { (uint)Id.pfetlvt, 0.130f },
                        { (uint)Id.pfethvt, 0.130f },
                        { (uint)Id.ntransistor, 0.130f },
                        { (uint)Id.nntransistor, 0.130f },
                        { (uint)Id.nfetlvt, 0.130f },
                        { (uint)Id.mvntransistor, 0.130f },
                        { (uint)Id.mvptransistor, 0.130f },
                        { (uint)Id.mvnntransistor, 0.130f },
                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.ndiffusion, 0.075f },
                        { (uint)Id.pdiffusion, 0.075f },
                        { (uint)Id.mvndiffusion, 0.075f },
                        { (uint)Id.mvpdiffusion, 0.075f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.pcontact ?
                new Layer
                {
                    Id = (uint)Id.pcontact,
                    Name = "pcontact",
                    MinLength = 0.170f,
                    MinWidth = 0.170f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.ndiffusion, 0.190f },
                        { (uint)Id.pdiffusion, 0.235f },
                        { (uint)Id.mvndiffusion, 0.190f },
                        { (uint)Id.mvpdiffusion, 0.235f },
                        { (uint)Id.pcontact, 0.170f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.xpolycontact ?
                new Layer
                {
                    Id = (uint)Id.xpolycontact,
                    Name = "xpolycontact",
                    MinLength = 0.170f,
                    MinWidth = 0.170f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.xpolycontact, 0.170f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.npolyres ?
                new Layer
                {
                    Id = (uint)Id.npolyres,
                    Name = "npolyres",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.ppolyres ?
                new Layer
                {
                    Id = (uint)Id.ppolyres,
                    Name = "ppolyres",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.xpolyres ?
                new Layer
                {
                    Id = (uint)Id.xpolyres,
                    Name = "xpolyres",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.ndiffres ?
                new Layer
                {
                    Id = (uint)Id.ndiffres,
                    Name = "ndiffres",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.pdiffres ?
                new Layer
                {
                    Id = (uint)Id.pdiffres,
                    Name = "pdiffres",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mvndiffres ?
                new Layer
                {
                    Id = (uint)Id.mvndiffres,
                    Name = "mvndiffres",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mvpdiffres ?
                new Layer
                {
                    Id = (uint)Id.mvpdiffres,
                    Name = "mvpdiffres",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.rmp ?
                new Layer
                {
                    Id = (uint)Id.rmp,
                    Name = "rmp",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.pdiode ?
                new Layer
                {
                    Id = (uint)Id.pdiode,
                    Name = "pdiode",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.ndiode ?
                new Layer
                {
                    Id = (uint)Id.ndiode,
                    Name = "ndiode",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.nndiode ?
                new Layer
                {
                    Id = (uint)Id.nndiode,
                    Name = "nndiode",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.pdiodec ?
                new Layer
                {
                    Id = (uint)Id.pdiodec,
                    Name = "pdiodec",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.ndiodec ?
                new Layer
                {
                    Id = (uint)Id.ndiodec,
                    Name = "ndiodec",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.nndiodec ?
                new Layer
                {
                    Id = (uint)Id.nndiodec,
                    Name = "nndiodec",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mvpdiode ?
                new Layer
                {
                    Id = (uint)Id.mvpdiode,
                    Name = "mvpdiode",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mvndiode ?
                new Layer
                {
                    Id = (uint)Id.mvndiode,
                    Name = "mvndiode",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mvpdiodec ?
                new Layer
                {
                    Id = (uint)Id.mvpdiodec,
                    Name = "mvpdiodec",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mvndiodec ?
                new Layer
                {
                    Id = (uint)Id.mvndiodec,
                    Name = "mvndiodec",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.pdiodelvt ?
                new Layer
                {
                    Id = (uint)Id.pdiodelvt,
                    Name = "pdiodelvt",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.pdiodehvt ?
                new Layer
                {
                    Id = (uint)Id.pdiodehvt,
                    Name = "pdiodehvt",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.ndiodelvt ?
                new Layer
                {
                    Id = (uint)Id.ndiodelvt,
                    Name = "ndiodelvt",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.pdiodelvtc ?
                new Layer
                {
                    Id = (uint)Id.pdiodelvtc,
                    Name = "pdiodelvtc",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.pdiodehvtc ?
                new Layer
                {
                    Id = (uint)Id.pdiodehvtc,
                    Name = "pdiodehvtc",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.ndiodelvtc ?
                new Layer
                {
                    Id = (uint)Id.ndiodelvtc,
                    Name = "ndiodelvtc",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.locali ?
                new Layer
                {
                    Id = (uint)Id.locali,
                    Name = "locali",
                    MinLength = 0.170f,
                    MinWidth = 0.170f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {
                        { (uint)Id.pcontact, 0.080f },
                        { (uint)Id.ndcontact, 0.080f },
                        { (uint)Id.pdcontact, 0.080f },
                        { (uint)Id.mvndcontact, 0.080f },
                        { (uint)Id.mvpdcontact, 0.080f },
                        { (uint)Id.nsubstratencontact, 0.080f },
                        { (uint)Id.psubstratepcontact, 0.080f },
                        { (uint)Id.mvnsubstratencontact, 0.080f },
                        { (uint)Id.mvpsubstratepcontact, 0.080f },
                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.locali, 0.170f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {
                        
                    },
                }
            : Id == Id.rlocali ?
                new Layer
                {
                    Id = (uint)Id.rlocali,
                    Name = "rlocali",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.viali ?
                new Layer
                {
                    Id = (uint)Id.viali,
                    Name = "viali",
                    MinLength = 0.170f,
                    MinWidth = 0.170f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.viali, 0.190f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.metal1 ?
                new Layer
                {
                    Id = (uint)Id.metal1,
                    Name = "metal1",
                    MinLength = 0.140f,
                    MinWidth = 0.140f,
                    MinArea = 0.083f,
                    MinExtension = new Dictionary<uint, float>
                    {
                        { (uint)Id.viali, 0.030f },
                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.metal1, 0.140f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.rmetal1 ?
                new Layer
                {
                    Id = (uint)Id.rmetal1,
                    Name = "rmetal1",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.m2contact ?
                new Layer
                {
                    Id = (uint)Id.m2contact,
                    Name = "m2contact",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.padl ?
                new Layer
                {
                    Id = (uint)Id.padl,
                    Name = "padl",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.reram ?
                new Layer
                {
                    Id = (uint)Id.reram,
                    Name = "reram",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.metal2 ?
                new Layer
                {
                    Id = (uint)Id.metal2,
                    Name = "metal2",
                    MinLength = 0.140f,
                    MinWidth = 0.140f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.metal1, 0.140f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.rmetal2 ?
                new Layer
                {
                    Id = (uint)Id.rmetal2,
                    Name = "rmetal2",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.m3contact ?
                new Layer
                {
                    Id = (uint)Id.m3contact,
                    Name = "m3contact",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.metal3 ?
                new Layer
                {
                    Id = (uint)Id.metal3,
                    Name = "metal3",
                    MinLength = 0.300f,
                    MinWidth = 0.300f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.metal3, 0.300f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.rmetal3 ?
                new Layer
                {
                    Id = (uint)Id.rmetal3,
                    Name = "rmetal3",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.via3 ?
                new Layer
                {
                    Id = (uint)Id.via3,
                    Name = "via3",
                    MinLength = 0.320f,
                    MinWidth = 0.320f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {
                        { (uint)Id.metal3, 0.060f },
                        { (uint)Id.metal4, 0.065f },
                    },
                }
            : Id == Id.mimcap ?
                new Layer
                {
                    Id = (uint)Id.mimcap,
                    Name = "mimcap",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mimcapcontact ?
                new Layer
                {
                    Id = (uint)Id.mimcapcontact,
                    Name = "mimcapcontact",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.metal4 ?
                new Layer
                {
                    Id = (uint)Id.metal4,
                    Name = "metal4",
                    MinLength = 0.300f,
                    MinWidth = 0.300f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {
                        { (uint)Id.metal4, 0.140f },
                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.rmetal4 ?
                new Layer
                {
                    Id = (uint)Id.rmetal4,
                    Name = "rmetal4",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.via4 ?
                new Layer
                {
                    Id = (uint)Id.via4,
                    Name = "via4",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mimcap2 ?
                new Layer
                {
                    Id = (uint)Id.mimcap2,
                    Name = "mimcap2",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mimcap2contact ?
                new Layer
                {
                    Id = (uint)Id.mimcap2contact,
                    Name = "mimcap2contact",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.metal5 ?
                new Layer
                {
                    Id = (uint)Id.metal5,
                    Name = "metal5",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.rmetal5 ?
                new Layer
                {
                    Id = (uint)Id.rmetal5,
                    Name = "rmetal5",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.mrdlcontact ?
                new Layer
                {
                    Id = (uint)Id.mrdlcontact,
                    Name = "mrdlcontact",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.metalrdl ?
                new Layer
                {
                    Id = (uint)Id.metalrdl,
                    Name = "metalrdl",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.pi2 ?
                new Layer
                {
                    Id = (uint)Id.pi2,
                    Name = "pi2",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.ubm ?
                new Layer
                {
                    Id = (uint)Id.ubm,
                    Name = "ubm",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.res0p35 ?
                new Layer
                {
                    Id = (uint)Id.res0p35,
                    Name = "res0p35",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.res0p69 ?
                new Layer
                {
                    Id = (uint)Id.res0p69,
                    Name = "res0p69",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.res1p41 ?
                new Layer
                {
                    Id = (uint)Id.res1p41,
                    Name = "res1p41",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.res2p85 ?
                new Layer
                {
                    Id = (uint)Id.res2p85,
                    Name = "res2p85",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            : Id == Id.res5p73 ?
                new Layer
                {
                    Id = (uint)Id.res5p73,
                    Name = "res5p73",
                    MinLength = 0.000f,
                    MinWidth = 0.000f,
                    MinArea = 0.000f,
                    MinExtension = new Dictionary<uint, float>
                    {

                    },
                    MinSpacing = new Dictionary<uint, float>
                    {

                    },
                    MinEnclosure = new Dictionary<uint, float>
                    {

                    },
                }
            :
                new Layer();
        }
    }
}

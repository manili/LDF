using System;
using LDF.Bases;
using LDF.Bases.MOSFET;
using LDF.Graphics;
using LDF.PowerStripes;
using LDF.Tools.Magic;
using Sky130;
using static LDF.Common;
using static Sky130.Layers;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;

            //////////////////////////////// Beginning of LDF Code ////////////////////////////////

            NFET_G5v0D10v5 nfet_g5v0d10v5 = new NFET_G5v0D10v5("nfet_g5v0d10v5", true, true, new MOSFETFingerConfiguration[] {
                new MOSFETFingerConfiguration(18, 5.0f, 1.0f),
                new MOSFETFingerConfiguration(10, 5.0f, 1.0f, Directions.Top, 2.0f)
            });

            PFET_G5v0D10v5 pfet_g5v0d10v5 = new PFET_G5v0D10v5("pfet_g5v0d10v5", true, true, new MOSFETFingerConfiguration[] {
                new MOSFETFingerConfiguration(10, 5.0f, 1.0f),
                new MOSFETFingerConfiguration(12, 5.0f, 1.0f, Directions.Top, 2.0f)
            });

            Container layout = new Container("layout", nfet_g5v0d10v5);
            pfet_g5v0d10v5.AlignWith(layout, Directions.Top, 1.0f);
            layout.GroupTogether(pfet_g5v0d10v5);

            PowerRing powerRing = new PowerRing("powerRing", new Point(0.0f, 0.0f), layout.DeviceBox.Size + 8.0f, layout.DeviceBox.Size + 4.0f,
                GetLayerById(Id.metal3), GetLayerById(Id.metal4), GetLayerById(Id.via3), "vssd1", "vccd1");
            powerRing.AlignWith(layout, Directions.Center);
            layout.GroupTogether(powerRing);
            layout.Move(new Point(0.0f, 0.0f));

            Export.ExportMagic(layout.Boxes, "/Users/mohammadaminnili/Desktop/layout.cmd");

            ////////////////////////////////  Ending of LDF Code   ////////////////////////////////

            DateTime endTime = DateTime.Now;
            Console.WriteLine("Done in {0}.", endTime - startTime);
        }
    }
}

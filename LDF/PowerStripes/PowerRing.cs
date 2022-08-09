using System;
using LDF.Bases;
using LDF.Graphics;
using static LDF.Common;
using static LDF.Bases.ExternalPort;
using System.Collections.Generic;

namespace LDF.PowerStripes
{
    public class PowerRing : DeviceBase
    {
        public PowerRing(string Name, Point Origin, Size OutsideRings, Size InsideRings, Layer TopBottom, Layer RightLeft, Layer Via, params string[] RingNames)
            : base(Name)
        {
            int ringsCount = RingNames.Length;
            // We have 2 vertical and 2 horizontal boxes per each ring, so divided by 2:
            Size betweenRings = (OutsideRings - InsideRings) / 2;

            // Based on DRC
            float viaMargin = Math.Max(Via.MinEnclosure[TopBottom.Id], Via.MinEnclosure[RightLeft.Id]);
            float ringMargin = Math.Max(TopBottom.MinSpacing[TopBottom.Id], RightLeft.MinSpacing[RightLeft.Id]);
            Size ringMarginSize = new Size(ringMargin, ringMargin);
            Size ringSize = (betweenRings - (ringMarginSize * (ringsCount - 1))) / ringsCount;

            for (int i = 0; i < RingNames.Length; i++)
            {
                // Assumes that the indexes of 0, 2, 4, 6, ... are power strips.
                Origin = Origin + (ringSize + ringMarginSize);
                Size outsideRing = OutsideRings - (ringSize * 2 * i) - (ringMarginSize * 2 * i);
                Size insideRing = OutsideRings - (ringSize * 2 * (i + 1)) - (ringMarginSize * 2 * i);
                Ring ring = new Ring("ring" + i, Origin, outsideRing, insideRing, TopBottom, RightLeft,
                    new Dictionary<Directions, ExternalPort> { { Directions.Right, new ExternalPort(RingNames[i], Classes.inout, i % 2 == 0 ? Uses.power : Uses.ground, Shapes.abutment) } });
                GroupTogether(ring);

                Box via_BL = ring.BottomLeftCollisionBox.Clone(Via);
                via_BL.Move(new Vector(viaMargin, viaMargin));
                via_BL.Resize(new Vector(-2 * viaMargin, -2 * viaMargin));
                Box via_TL = ring.TopLeftCollisionBox.Clone(Via);
                via_TL.Move(new Vector(viaMargin, viaMargin));
                via_TL.Resize(new Vector(-2 * viaMargin, -2 * viaMargin));
                Box via_TR = ring.TopRightCollisionBox.Clone(Via);
                via_TR.Move(new Vector(viaMargin, viaMargin));
                via_TR.Resize(new Vector(-2 * viaMargin, -2 * viaMargin));
                Box via_BR = ring.BottomRightCollisionBox.Clone(Via);
                via_BR.Move(new Vector(viaMargin, viaMargin));
                via_BR.Resize(new Vector(-2 * viaMargin, -2 * viaMargin));
                
                Size viaMinSize = new Size(Via.MinWidth, Via.MinWidth);
                if (via_BL.Size < viaMinSize || via_TL.Size < viaMinSize ||
                    via_TR.Size < viaMinSize || via_BR.Size < viaMinSize)
                {
                    throw new Exception("One or both sizes of OutsideRings or InsideRings" +
                        " " +
                        "is/are not proper to generate power ring. Please make more room" +
                        " " +
                        "for the rings.");
                }

                GroupTogether(via_BL, via_TL, via_TR, via_BR);
            }
        }
    }
}

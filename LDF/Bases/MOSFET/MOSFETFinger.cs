using System;
using LDF.Graphics;
using static LDF.Common;

namespace LDF.Bases.MOSFET
{
    internal class MOSFETFinger : DeviceBase
    {
        internal MOSFETFinger(string name, Point origin, MOSFETType mosfetType,
            int fingerCount, bool overlapGates, bool alignHorizontally, float width, float length)
            : base(name)
        {
            if (fingerCount <= 0)
                throw new Exception("Minimum possible FingersCount is 1");

            float minPolyToLiSize = mosfetType.PolyContact.MinWidth + 2 * mosfetType.LocalInterconnect.MinExtension[mosfetType.PolyContact.Id];
            float jump = minPolyToLiSize + ((mosfetType.PolyContact.MinSpacing[mosfetType.Diffusion.Id] - mosfetType.LocalInterconnect.MinExtension[mosfetType.PolyContact.Id]) - mosfetType.Poly.MinExtension[mosfetType.Transistor.Id]);
            MOSFETSingle[] fingers = new MOSFETSingle[fingerCount];

            for (int i = 0; i < fingerCount; i++)
            {
                if (overlapGates)
                {
                    if (i == 0)
                        fingers[i] = new MOSFETSingle(name + "_" + i, origin, mosfetType, width, length, true, true, true, true, true);
                    else
                        fingers[i] = new MOSFETSingle(name + "_" + i, origin, mosfetType, width, length, true, false, true, true, true);

                    if (i > 0)
                        fingers[i].AlignWith(fingers[i - 1], Directions.Bottom);
                }
                else
                {
                    if (length < minPolyToLiSize)
                    {
                        if (i == 0)
                            fingers[i] = new MOSFETSingle(name + "_" + i, origin, mosfetType, width, length, false, i % 2 == 0, i % 2 == 1, true, true);
                        else
                            fingers[i] = new MOSFETSingle(name + "_" + i, origin, mosfetType, width, length, false, i % 2 == 0, i % 2 == 1, true, false);

                        if (i > 0)
                        {
                            Vector margin = new Vector(-1 * (minPolyToLiSize - length) / 2, i % 2 == 1 ? -jump : jump);
                            fingers[i].AlignWith(fingers[i - 1], Directions.Right, margin);
                        }
                    }
                    else
                    {
                        if (i == 0)
                            fingers[i] = new MOSFETSingle(name + "_" + i, origin, mosfetType, width, length, false, true, true, true, true);
                        else
                            fingers[i] = new MOSFETSingle(name + "_" + i, origin, mosfetType, width, length, false, true, true, true, false);

                        if (i > 0)
                        {
                            fingers[i].AlignWith(fingers[i - 1], Directions.Right);
                        }
                    }
                }

                GroupTogether(fingers[i]);
            }

            if (alignHorizontally && overlapGates || !alignHorizontally && !overlapGates)
            {
                Rotate(origin, Degrees.D_90_Pos);
            }
        }
    }
}
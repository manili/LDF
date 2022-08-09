using System;
using LDF.Graphics;
using static LDF.Common;

namespace LDF.Bases.MOSFET
{
    internal class MOSFETSingle : DeviceBase
    {
        internal MOSFETSingle(string name, Point origin, MOSFETType mosfetType, float width, float length, bool overlapGates,
            bool polyTopContact, bool polyBottomContact, bool diffRightContact, bool diffLeftContact)
            : base(name)
        {
            if (length < mosfetType.Transistor.MinLength)
                throw new Exception("Minimum possible length for " + mosfetType.Name + " is " + mosfetType.Transistor.MinLength + "nm");
            if (width < mosfetType.Transistor.MinWidth)
                throw new Exception("Minimum possible width for " + mosfetType.Name + " is " + mosfetType.Transistor.MinWidth + "nm");

            // Transistor:
            Box transistor = new Box(origin, new Size(length, width), mosfetType.Transistor);
            GroupTogether(transistor);

            float minPolyToLiSize = mosfetType.PolyContact.MinWidth + mosfetType.LocalInterconnect.MinExtension[mosfetType.PolyContact.Id] * 2;
            Size polySize = new Size(length > minPolyToLiSize ? length : minPolyToLiSize, minPolyToLiSize);
            Size polyConSize = new Size(length > minPolyToLiSize ? length - mosfetType.LocalInterconnect.MinExtension[mosfetType.PolyContact.Id] * 2 : mosfetType.PolyContact.MinWidth, mosfetType.PolyContact.MinWidth);
            Size liPolySize = new Size(length > minPolyToLiSize ? length : minPolyToLiSize, mosfetType.PolyContact.MinWidth);

            Size diffSize = new Size(mosfetType.LocalInterconnect.MinWidth, width);
            Size diffConSize = new Size(mosfetType.LocalInterconnect.MinWidth, width - mosfetType.LocalInterconnect.MinExtension[mosfetType.DiffusionContact.Id] * 2);
            Size liDiffSize = new Size(mosfetType.LocalInterconnect.MinWidth, width);

            // Add 5nm to make sure we can draw it DRC error-free in any tech node.
            float minTopBottomWidth = MathF.Round(mosfetType.Metal1.MinArea / (liPolySize.H + mosfetType.Metal1.MinExtension[mosfetType.LocalInterconnectContact.Id] * 2), 3);
            Size met1SizeTopBottom = new Size(polySize.W < minTopBottomWidth ? minTopBottomWidth + 0.005f : polySize.W, liPolySize.H + mosfetType.Metal1.MinExtension[mosfetType.LocalInterconnectContact.Id] * 2);
            Size met1SizeRightLeft = new Size(liDiffSize.W + mosfetType.Metal1.MinExtension[mosfetType.LocalInterconnectContact.Id] * 2, diffSize.H);

            if (polyTopContact)
            {
                Box polyTop = new Box(origin, new Size(
                    length,
                    mosfetType.PolyContact.MinSpacing[mosfetType.Diffusion.Id] - mosfetType.LocalInterconnect.MinExtension[mosfetType.PolyContact.Id]
                    ), mosfetType.Poly);
                polyTop.AlignWith(transistor, Directions.Top);
                GroupTogether(polyTop);

                Contact polyLocaliTop = new Contact("polyLocaliTop", polyTop,
                    mosfetType.Poly, mosfetType.PolyContact, mosfetType.LocalInterconnect,
                    Directions.Top, polySize, polyConSize, liPolySize);
                GroupTogether(polyLocaliTop);

                Contact localiMetal1Top = new Contact("localiMetal1Top", polyLocaliTop.DeviceBox,
                    mosfetType.LocalInterconnect, mosfetType.LocalInterconnectContact, mosfetType.Metal1,
                    Directions.Center, liPolySize, polyConSize, met1SizeTopBottom);
                GroupTogether(localiMetal1Top);
            }
            else if (overlapGates)
            {
                Box polyTop = new Box(origin, new Size(
                    length,
                    mosfetType.PolyContact.MinSpacing[mosfetType.Diffusion.Id] - mosfetType.LocalInterconnect.MinExtension[mosfetType.PolyContact.Id]
                    ), mosfetType.Poly);
                polyTop.AlignWith(transistor, Directions.Top);
                GroupTogether(polyTop);
            }
            else
            {
                Box polyTop = new Box(origin,
                    new Size(length, mosfetType.Poly.MinExtension[mosfetType.Transistor.Id]), mosfetType.Poly);
                polyTop.AlignWith(transistor, Directions.Top);
                GroupTogether(polyTop);
            }

            if (polyBottomContact)
            {
                Box polyBottom = new Box(origin, new Size(
                    length,
                    mosfetType.PolyContact.MinSpacing[mosfetType.Diffusion.Id] - mosfetType.LocalInterconnect.MinExtension[mosfetType.PolyContact.Id]
                    ), mosfetType.Poly);
                polyBottom.AlignWith(transistor, Directions.Bottom);
                GroupTogether(polyBottom);

                Contact polyLocaliBottom = new Contact("polyLocaliBottom", polyBottom,
                    mosfetType.Poly, mosfetType.PolyContact, mosfetType.LocalInterconnect,
                    Directions.Bottom, polySize, polyConSize, liPolySize);
                GroupTogether(polyLocaliBottom);

                Contact localiMetal1Bottom = new Contact("localiMetal1Bottom", polyLocaliBottom.DeviceBox,
                    mosfetType.LocalInterconnect, mosfetType.LocalInterconnectContact, mosfetType.Metal1,
                    Directions.Center, liPolySize, polyConSize, met1SizeTopBottom);
                GroupTogether(localiMetal1Bottom);
            }
            else if (overlapGates)
            {
                Box polyBottom = new Box(origin, new Size(
                    length,
                    mosfetType.PolyContact.MinSpacing[mosfetType.Diffusion.Id] - mosfetType.LocalInterconnect.MinExtension[mosfetType.PolyContact.Id]
                    ), mosfetType.Poly);
                polyBottom.AlignWith(transistor, Directions.Bottom);
                GroupTogether(polyBottom);
            }
            else
            {
                Box polyBottom = new Box(origin,
                    new Size(length, mosfetType.Poly.MinExtension[mosfetType.Transistor.Id]), mosfetType.Poly);
                polyBottom.AlignWith(transistor, Directions.Bottom);
                GroupTogether(polyBottom);
            }

            if (diffRightContact)
            {
                Box diffRight = new Box(origin,
                    new Size(mosfetType.LocalInterconnect.MinWidth + mosfetType.DiffusionContact.MinSpacing[mosfetType.Transistor.Id] * 2, width), mosfetType.Diffusion);
                diffRight.AlignWith(transistor, Directions.Right);
                GroupTogether(diffRight);

                Contact diffLocaliRight = new Contact("diffLocaliRight", diffRight,
                    mosfetType.Diffusion, mosfetType.DiffusionContact, mosfetType.LocalInterconnect,
                    Directions.Center, diffSize, diffConSize, liDiffSize);
                GroupTogether(diffLocaliRight);

                Contact localiMetal1Right = new Contact("localiMetal1Right", diffLocaliRight.DeviceBox,
                    mosfetType.LocalInterconnect, mosfetType.LocalInterconnectContact, mosfetType.Metal1,
                    Directions.Center, liDiffSize, diffConSize, met1SizeRightLeft);
                GroupTogether(localiMetal1Right);
            }

            if (diffLeftContact)
            {
                Box diffLeft = new Box(origin,
                    new Size(mosfetType.LocalInterconnect.MinWidth + mosfetType.DiffusionContact.MinSpacing[mosfetType.Transistor.Id] * 2, width), mosfetType.Diffusion);
                diffLeft.AlignWith(transistor, Directions.Left);
                GroupTogether(diffLeft);

                Contact diffLocaliLeft = new Contact("diffLocaliLeft", diffLeft,
                    mosfetType.Diffusion, mosfetType.DiffusionContact, mosfetType.LocalInterconnect,
                    Directions.Center, diffSize, diffConSize, liDiffSize);
                GroupTogether(diffLocaliLeft);

                Contact localiMetal1Left = new Contact("localiMetal1Left", diffLocaliLeft.DeviceBox,
                    mosfetType.LocalInterconnect, mosfetType.LocalInterconnectContact, mosfetType.Metal1,
                    Directions.Center, liDiffSize, diffConSize, met1SizeRightLeft);
                GroupTogether(localiMetal1Left);
            }
        }
    }
}
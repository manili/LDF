using LDF.Graphics;
using static LDF.Common;

namespace LDF.Bases.MOSFET
{
    public class MOSFETBase : DeviceBase
    {
        public MOSFETBase(string Name, bool AlignHorizontally, bool CreateRing, MOSFETType MOSFETType, MOSFETFingerConfiguration[] MOSFETFingersConfigs)
            : base(Name)
        {
            Point origin = new Point(0.0f, 0.0f);

            for (int i = 0; i < MOSFETFingersConfigs.Length; i++)
            {
                MOSFETFingerConfiguration mosfetFingerConfig = MOSFETFingersConfigs[i];
                MOSFETFinger mosfetFinger = new MOSFETFinger(
                        Name + "_" + i, origin, MOSFETType,
                        mosfetFingerConfig.Count,
                        mosfetFingerConfig.ConnectGates,
                        AlignHorizontally,
                        mosfetFingerConfig.Width,
                        mosfetFingerConfig.Length
                );

                if (i > 0)
                {
                    if (mosfetFingerConfig.Margin == null)
                        mosfetFinger.AlignWith(this, mosfetFingerConfig.Direction);
                    else
                        mosfetFinger.AlignWith(this, mosfetFingerConfig.Direction, mosfetFingerConfig.Margin);
                }

                GroupTogether(mosfetFinger);
            }

            if (CreateRing)
            {
                Ring ringSubstrateDiff = new Ring("ringSubstrateDiff", origin,
                    new Size(
                        DeviceBox.Size.W + (MOSFETType.Diffusion.MinSpacing[MOSFETType.Tap.Id] + MOSFETType.LocalInterconnect.MinWidth + MOSFETType.Metal1.MinExtension[MOSFETType.LocalInterconnectContact.Id] * 2) * 2,
                        DeviceBox.Size.H + (MOSFETType.Diffusion.MinSpacing[MOSFETType.Tap.Id] + MOSFETType.LocalInterconnect.MinWidth + MOSFETType.Metal1.MinExtension[MOSFETType.LocalInterconnectContact.Id] * 2) * 2
                    ),
                    new Size(
                        DeviceBox.Size.W + MOSFETType.Diffusion.MinSpacing[MOSFETType.Tap.Id] * 2,
                        DeviceBox.Size.H + MOSFETType.Diffusion.MinSpacing[MOSFETType.Tap.Id] * 2
                    ),
                    MOSFETType.Tap);

                Ring ringLocalInterconnect = new Ring("ringLocalInterconnect", origin,
                    new Size(
                        DeviceBox.Size.W + (MOSFETType.Diffusion.MinSpacing[MOSFETType.Tap.Id] + MOSFETType.LocalInterconnect.MinWidth + MOSFETType.Metal1.MinExtension[MOSFETType.LocalInterconnectContact.Id] * 2) * 2,
                        DeviceBox.Size.H + (MOSFETType.Diffusion.MinSpacing[MOSFETType.Tap.Id] + MOSFETType.LocalInterconnect.MinWidth + MOSFETType.Metal1.MinExtension[MOSFETType.LocalInterconnectContact.Id] * 2) * 2
                    ),
                    new Size(
                        DeviceBox.Size.W + MOSFETType.Diffusion.MinSpacing[MOSFETType.Tap.Id] * 2,
                        DeviceBox.Size.H + MOSFETType.Diffusion.MinSpacing[MOSFETType.Tap.Id] * 2
                    ),
                    MOSFETType.LocalInterconnect);
                ringLocalInterconnect.AlignWith(ringSubstrateDiff, Directions.Center);
                ringSubstrateDiff.GroupTogether(ringLocalInterconnect);

                Ring ringMetal1 = new Ring("ringMetal1", origin,
                    new Size(
                        DeviceBox.Size.W + (MOSFETType.Diffusion.MinSpacing[MOSFETType.Tap.Id] + MOSFETType.LocalInterconnect.MinWidth + MOSFETType.Metal1.MinExtension[MOSFETType.LocalInterconnectContact.Id] * 2) * 2,
                        DeviceBox.Size.H + (MOSFETType.Diffusion.MinSpacing[MOSFETType.Tap.Id] + MOSFETType.LocalInterconnect.MinWidth + MOSFETType.Metal1.MinExtension[MOSFETType.LocalInterconnectContact.Id] * 2) * 2
                    ),
                    new Size(
                        DeviceBox.Size.W + MOSFETType.Diffusion.MinSpacing[MOSFETType.Tap.Id] * 2,
                        DeviceBox.Size.H + MOSFETType.Diffusion.MinSpacing[MOSFETType.Tap.Id] * 2
                    ),
                    MOSFETType.Metal1);
                ringMetal1.AlignWith(ringSubstrateDiff, Directions.Center);
                ringSubstrateDiff.GroupTogether(ringMetal1);

                AlignWith(ringSubstrateDiff, Directions.Center);
                GroupTogether(ringSubstrateDiff);

                Box ringTopBottomContact = new Box(
                    origin,
                    new Size(ringSubstrateDiff.TopBox.Size.W - (ringSubstrateDiff.TopRightCollisionBox.Size.W + MOSFETType.LocalInterconnectContact.MinSpacing[MOSFETType.LocalInterconnectContact.Id]) * 2, MOSFETType.TapContact.MinWidth),
                    new Layer()); // Dummy Layer For Now
                Box ringRightLeftContact = new Box(
                    origin,
                    new Size(MOSFETType.TapContact.MinWidth, ringSubstrateDiff.RightBox.Size.H - (ringSubstrateDiff.TopRightCollisionBox.Size.H + MOSFETType.LocalInterconnectContact.MinSpacing[MOSFETType.LocalInterconnectContact.Id]) * 2),
                    new Layer()); // Dummy Layer For Now


                Box topTapContact = ringTopBottomContact.Clone(MOSFETType.TapContact);
                topTapContact.AlignWith(ringSubstrateDiff.TopBox, Directions.Center);
                Box bottomTapContact = ringTopBottomContact.Clone(MOSFETType.TapContact);
                bottomTapContact.AlignWith(ringSubstrateDiff.BottomBox, Directions.Center);
                Box rightTapContact = ringRightLeftContact.Clone(MOSFETType.TapContact);
                rightTapContact.AlignWith(ringSubstrateDiff.RightBox, Directions.Center);
                Box leftTapContact = ringRightLeftContact.Clone(MOSFETType.TapContact);
                leftTapContact.AlignWith(ringSubstrateDiff.LeftBox, Directions.Center);
                GroupTogether(topTapContact, bottomTapContact, rightTapContact, leftTapContact);

                Box topLiContact = ringTopBottomContact.Clone(MOSFETType.LocalInterconnectContact);
                topLiContact.AlignWith(ringSubstrateDiff.TopBox, Directions.Center);
                Box bottomLiContact = ringTopBottomContact.Clone(MOSFETType.LocalInterconnectContact);
                bottomLiContact.AlignWith(ringSubstrateDiff.BottomBox, Directions.Center);
                Box rightLiContact = ringRightLeftContact.Clone(MOSFETType.LocalInterconnectContact);
                rightLiContact.AlignWith(ringSubstrateDiff.RightBox, Directions.Center);
                Box leftLiContact = ringRightLeftContact.Clone(MOSFETType.LocalInterconnectContact);
                leftLiContact.AlignWith(ringSubstrateDiff.LeftBox, Directions.Center);
                GroupTogether(topLiContact, bottomLiContact, rightLiContact, leftLiContact);

                Box well = new Box(
                    origin,
                    new Size(
                        DeviceBox.Size.W + MOSFETType.Substrate.MinExtension[MOSFETType.Tap.Id] * 2,
                        DeviceBox.Size.H + MOSFETType.Substrate.MinExtension[MOSFETType.Tap.Id] * 2
                    ),
                    MOSFETType.Substrate);
                well.AlignWith(DeviceBox, Directions.Center);

                GroupTogether(well);
                Move(new Vector(origin, new Point(DeviceBox.LowerLeft.X, DeviceBox.LowerLeft.Y)));
            }
            else
            {
                Box well = new Box(
                    origin,
                    new Size(
                        DeviceBox.Size.W + MOSFETType.Substrate.MinExtension[MOSFETType.Diffusion.Id] * 2,
                        DeviceBox.Size.H + MOSFETType.Substrate.MinExtension[MOSFETType.Diffusion.Id] * 2
                    ),
                    MOSFETType.Substrate);
                well.AlignWith(DeviceBox, Directions.Center);

                GroupTogether(well);
                Move(new Vector(origin, new Point(DeviceBox.LowerLeft.X, DeviceBox.LowerLeft.Y)));
            }
        }
    }
}
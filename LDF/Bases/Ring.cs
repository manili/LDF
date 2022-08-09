using System;
using System.Collections.Generic;
using LDF.Graphics;
using static LDF.Common;

namespace LDF.Bases
{
    public class Ring : DeviceBase
    {
        public Box TopBox { get; }
        public Box BottomBox { get; }
        public Box RightBox { get; }
        public Box LeftBox { get; }

        public Box TopRightCollisionBox { get; }
        public Box TopLeftCollisionBox { get; }
        public Box BottomRightCollisionBox { get; }
        public Box BottomLeftCollisionBox { get; }

        public Ring(string Name, Point Origin, Size Outside, Size Inside, Layer Layer,
            Dictionary<Directions, ExternalPort> Ports = null)
            : base(Name)
        {
            Ring ring = new Ring(Name, Origin, Outside, Inside, Layer, Layer, Layer, Layer, Ports);
            GroupTogether(ring);

            TopBox = ring.TopBox;
            BottomBox = ring.BottomBox;
            RightBox = ring.RightBox;
            LeftBox = ring.LeftBox;

            TopRightCollisionBox = ring.TopRightCollisionBox;
            TopLeftCollisionBox = ring.TopLeftCollisionBox;
            BottomRightCollisionBox = ring.BottomRightCollisionBox;
            BottomLeftCollisionBox = ring.BottomLeftCollisionBox;
        }

        public Ring(string Name, Point Origin, Size Outside, Size Inside, Layer TopBottom, Layer RightLeft,
            Dictionary<Directions, ExternalPort> Ports = null)
            : base(Name)
        {
            Ring ring = new Ring(Name, Origin, Outside, Inside, TopBottom, TopBottom, RightLeft, RightLeft, Ports);
            GroupTogether(ring);

            TopBox = ring.TopBox;
            BottomBox = ring.BottomBox;
            RightBox = ring.RightBox;
            LeftBox = ring.LeftBox;

            TopRightCollisionBox = ring.TopRightCollisionBox;
            TopLeftCollisionBox = ring.TopLeftCollisionBox;
            BottomRightCollisionBox = ring.BottomRightCollisionBox;
            BottomLeftCollisionBox = ring.BottomLeftCollisionBox;
        }

        public Ring(string Name, Point Origin, Size Outside, Size Inside, Layer Top, Layer Bottom, Layer Right, Layer Left,
            Dictionary<Directions, ExternalPort> Ports = null)
            : base(Name)
        {
            if (Outside < Inside)
                throw new Exception("Outside rect must be bigger than Inside rect.");

            Box outsideBox = new Box(Origin, Outside, new Layer());         // Dummy Layer For Now
            Box insideBox = new Box(Origin, Inside, new Layer());           // Dummy Layer For Now
            insideBox.AlignWith(outsideBox, Directions.Center);

            Size ringSize = (Outside - Inside) / 2;

            TopBox = new Box(Origin, new Size(Outside.W, ringSize.H), Top, Ports != null && Ports.ContainsKey(Directions.Top) ? Ports[Directions.Top] : null);
            TopBox.AlignWith(insideBox, Directions.Top);
            BottomBox = new Box(Origin, new Size(Outside.W, ringSize.H), Bottom, Ports != null && Ports.ContainsKey(Directions.Bottom) ? Ports[Directions.Bottom] : null);
            BottomBox.AlignWith(insideBox, Directions.Bottom);
            RightBox = new Box(Origin, new Size(ringSize.W, Outside.H), Right, Ports != null && Ports.ContainsKey(Directions.Right) ? Ports[Directions.Right] : null);
            RightBox.AlignWith(insideBox, Directions.Right);
            LeftBox = new Box(Origin, new Size(ringSize.W, Outside.H), Left, Ports != null && Ports.ContainsKey(Directions.Left) ? Ports[Directions.Left] : null);
            LeftBox.AlignWith(insideBox, Directions.Left);
            GroupTogether(TopBox, BottomBox, RightBox, LeftBox);

            TopRightCollisionBox = TopBox.FindCollisionWith(RightBox, new Layer());       // Dummy Layer For Now
            TopLeftCollisionBox = TopBox.FindCollisionWith(LeftBox, new Layer());         // Dummy Layer For Now
            BottomRightCollisionBox = BottomBox.FindCollisionWith(RightBox, new Layer()); // Dummy Layer For Now
            BottomLeftCollisionBox = BottomBox.FindCollisionWith(LeftBox, new Layer());   // Dummy Layer For Now
        }
    }
}

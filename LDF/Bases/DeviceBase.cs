using System.Collections.Generic;
using LDF.Graphics;
using static LDF.Common;

namespace LDF.Bases
{
    abstract public class DeviceBase
    {
        private List<Box> _boxes;

        public string Name { get; }
        public IReadOnlyList<Box> Boxes { get { return _boxes.AsReadOnly(); } }
        public Box DeviceBox
        {
            get
            {
                Point ll = new Point(float.MaxValue, float.MaxValue);
                Point ur = new Point(float.MinValue, float.MinValue);

                for (int i = 0; i < _boxes.Count; i++)
                {
                    // Box LowerLeft
                    if (_boxes[i].LowerLeft.X < ll.X)
                        ll = new Point(_boxes[i].LowerLeft.X, ll.Y);
                    if (_boxes[i].LowerLeft.Y < ll.Y)
                        ll = new Point(ll.X, _boxes[i].LowerLeft.Y);

                    // Box UpperRight
                    if (ur.X < _boxes[i].UpperRight.X)
                        ur = new Point(_boxes[i].UpperRight.X, ur.Y);
                    if (ur.Y < _boxes[i].UpperRight.Y)
                        ur = new Point(ur.X, _boxes[i].UpperRight.Y);
                }

                return new Box(ll, ur, new Layer());
            }
        }

        public DeviceBase(string Name)
        {
            this.Name = Name;
            _boxes = new List<Box>();
        }

        public void Rotate(Point Origin, Degrees Degree)
        {
            for (int i = 0; i < _boxes.Count; i++)
            {
                _boxes[i].Rotate(Origin, Degree);
            }
        }

        public void Move(Vector Movement)
        {
            for (int i = 0; i < _boxes.Count; i++)
            {
                _boxes[i].Move(Movement);
            }
        }

        public void Move(Point NewLowerLeft)
        {
            Move(new Vector(NewLowerLeft, DeviceBox.LowerLeft));
        }

        public void AlignWith(DeviceBase Device, Directions Direction, float Margin = 0.0f)
        {
            switch (Direction)
            {
                case Directions.Center:
                    AlignWith(Device, Direction, new Vector(0.0f, 0.0f));
                    break;
                case Directions.Top:
                    AlignWith(Device, Direction, new Vector(0.0f, +Margin));
                    break;
                case Directions.Left:
                    AlignWith(Device, Direction, new Vector(-Margin, 0.0f));
                    break;
                case Directions.Right:
                    AlignWith(Device, Direction, new Vector(+Margin, 0.0f));
                    break;
                case Directions.Bottom:
                    AlignWith(Device, Direction, new Vector(0.0f, -Margin));
                    break;
                default:
                    return;
            }
        }

        public void AlignWith(DeviceBase Device, Directions Direction, Vector Margin)
        {
            switch (Direction)
            {
                case Directions.Center:
                    Move(new Vector(Device.DeviceBox.Center, DeviceBox.Center));
                    break;
                case Directions.Top:
                    AlignWith(Device, Directions.Center);
                    Move(new Vector(0.0f, Device.DeviceBox.UpperRight.Y - DeviceBox.LowerLeft.Y) + Margin);
                    break;
                case Directions.Left:
                    AlignWith(Device, Directions.Center);
                    Move(new Vector(Device.DeviceBox.LowerLeft.X - DeviceBox.UpperRight.X, 0.0f) + Margin);
                    break;
                case Directions.Right:
                    AlignWith(Device, Directions.Center);
                    Move(new Vector(Device.DeviceBox.UpperRight.X - DeviceBox.LowerLeft.X, 0.0f) + Margin);
                    break;
                case Directions.Bottom:
                    AlignWith(Device, Directions.Center);
                    Move(new Vector(0.0f, Device.DeviceBox.LowerLeft.Y - DeviceBox.UpperRight.Y) + Margin);
                    break;
                default:
                    return;
            }
        }

        public void GroupTogether(params Box[] boxes)
        {
            _boxes.AddRange(boxes);
        }

        public void GroupTogether(params DeviceBase[] Devices)
        {
            foreach (var device in Devices)
            {
                _boxes.AddRange(device._boxes);
            }
        }
    }
}

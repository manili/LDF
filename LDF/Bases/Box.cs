using System;
using LDF.Graphics;
using static LDF.Common;

namespace LDF.Bases
{
    public class Box
    {
        private ExternalPort _port;
        private Layer _layer;
        private Size _size;
        private Point _center;
        private Point _lowerLeft;
        private Point _upperRight;

        public ExternalPort Port { get { return _port; } private set { _port = value; } }
        public Layer Layer { get { return _layer; } private set { _layer = value; } }
        public Size Size { get { return _size; } private set { _size = value; } }
        public Point Center { get { return _center; } private set { _center = value; } }
        public Point LowerLeft
        {
            get
            {
                return _lowerLeft;
            }
            private set
            {
                _lowerLeft = value;

                // Make sure that the class is not constructing (instantiating).
                if (_lowerLeft != null && _upperRight != null)
                {
                    _size = new Size(
                        Math.Abs((_upperRight - _lowerLeft).X),
                        Math.Abs((_upperRight - _lowerLeft).Y)
                    );
                    _center = new Point(
                        _lowerLeft.X + _size.W / 2,
                        _lowerLeft.Y + _size.H / 2
                    );
                }
            }
        }
        public Point UpperRight
        {
            get
            {
                return _upperRight;
            }
            private set
            {
                _upperRight = value;

                // Make sure that the class is not constructing (instantiating).
                if (_lowerLeft != null && _upperRight != null)
                {
                    _size = new Size(
                        Math.Abs((_upperRight - _lowerLeft).X),
                        Math.Abs((_upperRight - _lowerLeft).Y)
                    );
                    _center = new Point(
                        _lowerLeft.X + _size.W / 2,
                        _lowerLeft.Y + _size.H / 2
                    );
                }
            }
        }

        public Box(Point LowerLeft, Point UpperRight, Layer Layer, ExternalPort Port = null)
        {
            this.Layer = Layer;
            this.Size = new Size(
                Math.Abs((UpperRight - LowerLeft).X),
                Math.Abs((UpperRight - LowerLeft).Y)
            );
            this.Port = Port;
            this.LowerLeft = LowerLeft;
            this.UpperRight = UpperRight;
            this.Center = new Point(LowerLeft.X + Size.W / 2, LowerLeft.Y + Size.H / 2);
        }

        public Box(Point LowerLeft, Size Size, Layer Layer, ExternalPort Port = null)
        {
            this.Layer = Layer;
            this.Size = Size;
            this.Port = Port;
            this.LowerLeft = LowerLeft;
            this.UpperRight = LowerLeft + Size;
            this.Center = new Point(LowerLeft.X + Size.W / 2, LowerLeft.Y + Size.H / 2);
        }

        public Box(float X0, float Y0, Size Size, Layer Layer, ExternalPort Port = null)
        {
            this.Layer = Layer;
            this.Size = Size;
            this.Port = Port;
            this.LowerLeft = new Point(X0, Y0);
            this.UpperRight = new Point(X0 + Size.W, Y0 + Size.H);
            this.Center = new Point(LowerLeft.X + Size.W / 2, LowerLeft.Y + Size.H / 2);
        }

        public Box(float X0, float Y0, float Width, float Height, Layer Layer, ExternalPort Port = null)
        {
            this.Layer = Layer;
            this.Size = new Size(Width, Height);
            this.Port = Port;
            this.LowerLeft = new Point(X0, Y0);
            this.UpperRight = new Point(X0 + Width, Y0 + Height);
            this.Center = new Point(LowerLeft.X + Size.W / 2, LowerLeft.Y + Size.H / 2);
        }

        public void Rotate(Point Origin, Degrees Degree)
        {
            Point ll, ur;

            switch (Degree)
            {
                case Degrees.D_90_Pos:
                    ll = new Point(-1 * (LowerLeft.Y - Origin.Y) + Origin.X, (LowerLeft.X - Origin.X) + Origin.Y);
                    ur = new Point(-1 * (UpperRight.Y - Origin.Y) + Origin.X, (UpperRight.X - Origin.X) + Origin.Y);
                    break;
                case Degrees.D_90_Neg:
                    ll = new Point((LowerLeft.Y - Origin.Y) + Origin.X, -1 * (LowerLeft.X - Origin.X) + Origin.Y);
                    ur = new Point((UpperRight.Y - Origin.Y) + Origin.X, -1 * (UpperRight.X - Origin.X) + Origin.Y);
                    break;
                case Degrees.D_180_Pos:
                    Rotate(Origin, Degrees.D_90_Pos);
                    Rotate(Origin, Degrees.D_90_Pos);
                    return;
                case Degrees.D_180_Neg:
                    Rotate(Origin, Degrees.D_90_Neg);
                    Rotate(Origin, Degrees.D_90_Neg);
                    return;
                default:
                    return;
            }

            Point tmpur = new Point(ur.X, ur.Y);
            if (ur.X < ll.X)
            {
                ur = new Point(ll.X, ur.Y);
                ll = new Point(tmpur.X, ll.Y);
            }
            if (ur.Y < ll.Y)
            {
                ur = new Point(ur.X, ll.Y);
                ll = new Point(ll.X, tmpur.Y);
            }

            UpperRight = ur;
            LowerLeft = ll;
        }

        public void Resize(Vector ResizingVector)
        {
            Point newUpperRight = new Point(
                UpperRight.X + ResizingVector.X,
                UpperRight.Y + ResizingVector.Y);
            UpperRight = newUpperRight;
        }

        public void Move(Point LowerLeftNewPoint)
        {
            Vector movement = new Vector(LowerLeftNewPoint, LowerLeft);
            LowerLeft = LowerLeft + movement;
            UpperRight = UpperRight + movement;
        }

        public void Move(Vector MovementVector)
        {
            LowerLeft = LowerLeft + MovementVector;
            UpperRight = UpperRight + MovementVector;
        }

        public void AlignWith(Box Box, Directions Direction, float Margin = 0.0f)
        {
            switch (Direction)
            {
                case Directions.Center:
                    AlignWith(Box, Direction, new Vector(0.0f, 0.0f));
                    break;
                case Directions.Top:
                    AlignWith(Box, Direction, new Vector(0.0f, +Margin));
                    break;
                case Directions.Left:
                    AlignWith(Box, Direction, new Vector(-Margin, 0.0f));
                    break;
                case Directions.Right:
                    AlignWith(Box, Direction, new Vector(+Margin, 0.0f));
                    break;
                case Directions.Bottom:
                    AlignWith(Box, Direction, new Vector(0.0f, -Margin));
                    break;
                default:
                    return;
            }
        }

        public void AlignWith(Box Box, Directions Direction, Vector Margin)
        {
            switch (Direction)
            {
                case Directions.Center:
                    Move(new Vector(Box.Center, Center));
                    break;
                case Directions.Top:
                    AlignWith(Box, Directions.Center);
                    Move(new Vector(0.0f, Box.UpperRight.Y - LowerLeft.Y) + Margin);
                    break;
                case Directions.Left:
                    AlignWith(Box, Directions.Center);
                    Move(new Vector(Box.LowerLeft.X - UpperRight.X, 0.0f) + Margin);
                    break;
                case Directions.Right:
                    AlignWith(Box, Directions.Center);
                    Move(new Vector(Box.UpperRight.X - LowerLeft.X, 0.0f) + Margin);
                    break;
                case Directions.Bottom:
                    AlignWith(Box, Directions.Center);
                    Move(new Vector(0.0f, Box.LowerLeft.Y - UpperRight.Y) + Margin);
                    break;
                default:
                    return;
            }
        }

        public Box FindCollisionWith(Box OtherBox, Layer newLayer)
        {
            float x0 = 0, x1 = 0;
            float y0 = 0, y1 = 0;

            if (OtherBox.LowerLeft.X < LowerLeft.X)
            {
                if (OtherBox.UpperRight.X <= LowerLeft.X)
                {
                    return null;
                }
                if (OtherBox.UpperRight.X < UpperRight.X)
                {
                    x0 = LowerLeft.X;
                    x1 = OtherBox.UpperRight.X;
                }
                if (OtherBox.UpperRight.X >= UpperRight.X)
                {
                    x0 = LowerLeft.X;
                    x1 = UpperRight.X;
                }
            }
            else if (OtherBox.LowerLeft.X >= LowerLeft.X)
            {
                if (OtherBox.LowerLeft.X >= UpperRight.X)
                {
                    return null;
                }
                if (OtherBox.UpperRight.X < UpperRight.X)
                {
                    x0 = OtherBox.LowerLeft.X;
                    x1 = OtherBox.UpperRight.X;
                }
                if (OtherBox.UpperRight.X >= UpperRight.X)
                {
                    x0 = OtherBox.LowerLeft.X;
                    x1 = UpperRight.X;
                }
            }
            else
            {
                return null;
            }

            if (OtherBox.LowerLeft.Y < LowerLeft.Y)
            {
                if (OtherBox.UpperRight.Y <= LowerLeft.Y)
                {
                    return null;
                }
                if (OtherBox.UpperRight.Y < UpperRight.Y)
                {
                    y0 = LowerLeft.Y;
                    y1 = OtherBox.UpperRight.Y;
                }
                if (OtherBox.UpperRight.Y >= UpperRight.Y)
                {
                    y0 = LowerLeft.Y;
                    y1 = UpperRight.Y;
                }
            }
            else if (OtherBox.LowerLeft.Y >= LowerLeft.Y)
            {
                if (OtherBox.LowerLeft.Y >= UpperRight.Y)
                {
                    return null;
                }
                if (OtherBox.UpperRight.Y < UpperRight.Y)
                {
                    y0 = OtherBox.LowerLeft.Y;
                    y1 = OtherBox.UpperRight.Y;
                }
                if (OtherBox.UpperRight.Y >= UpperRight.Y)
                {
                    y0 = OtherBox.LowerLeft.Y;
                    y1 = UpperRight.Y;
                }
            }
            else
            {
                return null;
            }

            //It has nothing to do with the port because it is a whole new box
            return new Box(new Point(x0, y0), new Point(x1, y1), newLayer);
        }

        public Box Clone()
        {
            return new Box(LowerLeft, UpperRight, Layer, Port);
        }

        public Box Clone(Layer Layer)
        {
            return new Box(LowerLeft, UpperRight, Layer, Port);
        }
    }
}

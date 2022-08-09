using LDF.Graphics;
using static LDF.Common;

namespace LDF.Bases.MOSFET
{
    public class MOSFETFingerConfiguration
    {
        public int Count { get; }
        public float Width { get; }
        public float Length { get; }
        public Directions Direction { get; }
        public Vector Margin { get; }
        public bool ConnectGates { get; }

        public MOSFETFingerConfiguration(int Count, float Width, float Length)
        {
            this.Count = Count;
            this.Width = Width;
            this.Length = Length;
            Direction = Directions.Center;
            Margin = null;
            ConnectGates = false;
        }

        public MOSFETFingerConfiguration(int Count, float Width, float Length, Directions Direction)
        {
            this.Count = Count;
            this.Width = Width;
            this.Length = Length;
            this.Direction = Direction;
            Margin = null;
            ConnectGates = false;
        }

        public MOSFETFingerConfiguration(int Count, float Width, float Length, Directions Direction, Vector Margin)
        {
            this.Count = Count;
            this.Width = Width;
            this.Length = Length;
            this.Direction = Direction;
            this.Margin = Margin;
            ConnectGates = false;
        }

        public MOSFETFingerConfiguration(int Count, float Width, float Length, Directions Direction, float Margin)
        {
            this.Count = Count;
            this.Width = Width;
            this.Length = Length;
            this.Direction = Direction;

            switch (Direction)
            {
                case Directions.Center:
                    this.Margin = null;
                    break;
                case Directions.Top:
                    this.Margin = new Vector(0.0f, Margin);
                    break;
                case Directions.Left:
                    this.Margin = new Vector(-Margin, 0.0f);
                    break;
                case Directions.Right:
                    this.Margin = new Vector(Margin, 0.0f);
                    break;
                case Directions.Bottom:
                    this.Margin = new Vector(0.0f, -Margin);
                    break;
                default:
                    this.Margin = null;
                    break;
            }

            ConnectGates = false;
        }

        public MOSFETFingerConfiguration(int Count, float Width, float Length, Directions Direction, Vector Margin, bool ConnectGates)
        {
            this.Count = Count;
            this.Width = Width;
            this.Length = Length;
            this.Direction = Direction;
            this.Margin = Margin;
            this.ConnectGates = ConnectGates;
        }

        public MOSFETFingerConfiguration(int Count, float Width, float Length, Directions Direction, float Margin, bool ConnectGates)
        {
            this.Count = Count;
            this.Width = Width;
            this.Length = Length;
            this.Direction = Direction;

            switch (Direction)
            {
                case Directions.Center:
                    this.Margin = null;
                    break;
                case Directions.Top:
                    this.Margin = new Vector(0.0f, Margin);
                    break;
                case Directions.Left:
                    this.Margin = new Vector(-Margin, 0.0f);
                    break;
                case Directions.Right:
                    this.Margin = new Vector(Margin, 0.0f);
                    break;
                case Directions.Bottom:
                    this.Margin = new Vector(0.0f, -Margin);
                    break;
                default:
                    this.Margin = null;
                    break;
            }

            this.ConnectGates = ConnectGates;
        }
    }
}

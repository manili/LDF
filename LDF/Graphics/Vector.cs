namespace LDF.Graphics
{
    public class Vector
    {
        public float X { get; }
        public float Y { get; }

        public Vector(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Vector(Point EndPoint, Point StartPoint)
        {
            X = (EndPoint - StartPoint).X;
            Y = (EndPoint - StartPoint).Y;
        }

        public Vector(Point StartPoint, Size Size)
        {
            X = StartPoint.X + Size.W;
            Y = StartPoint.Y + Size.H;
        }

        public static Vector operator -(Vector V1, Vector V2)
        {
            return new Vector(V1.X - V2.X, V1.Y - V2.Y);
        }

        public static Vector operator -(Vector V1, float Margin)
        {
            return new Vector(V1.X - Margin, V1.Y - Margin);
        }

        public static Vector operator +(Vector V1, Vector V2)
        {
            return new Vector(V1.X + V2.X, V1.Y + V2.Y);
        }

        public static Vector operator +(Vector V1, float Margin)
        {
            return new Vector(V1.X + Margin, V1.Y + Margin);
        }

        public static Vector operator /(Vector V, float Scale)
        {
            return new Vector(V.X / Scale, V.Y / Scale);
        }

        public static Vector operator *(Vector V, float Scale)
        {
            return new Vector(V.X * Scale, V.Y * Scale);
        }
    }
}

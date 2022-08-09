namespace LDF.Graphics
{
    public class Point
    {
        public float X { get; }
        public float Y { get; }
        
        public Point(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static Point operator -(Point P1, Point P2)
        {
            return new Point(P1.X - P2.X, P1.Y - P2.Y);
        }

        public static Point operator -(Point P, Size S)
        {
            return new Point(P.X - S.W, P.Y - S.H);
        }

        public static Point operator -(Point P, Vector V)
        {
            return new Point(P.X - V.X, P.Y - V.Y);
        }

        public static Point operator +(Point P1, Point P2)
        {
            return new Point(P1.X + P2.X, P1.Y + P2.Y);
        }

        public static Point operator +(Point P, Size S)
        {
            return new Point(P.X + S.W, P.Y + S.H);
        }

        public static Point operator +(Point P, Vector V)
        {
            return new Point(P.X + V.X, P.Y + V.Y);
        }
    }
}

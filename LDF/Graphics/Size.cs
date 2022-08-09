using System;

namespace LDF.Graphics
{
    public class Size
    {
        public float W { get; }
        public float H { get; }
        public float Area { get { return W * H; } }

        public Size(float W, float H)
        {
            if (W < 0 || H < 0)
            {
                throw new Exception("Width or Height must be at leat zero.");
            }

            this.W = W;
            this.H = H;
        }

        public static Size operator -(Size S1, Size S2)
        {
            return new Size(S1.W - S2.W, S1.H - S2.H);
        }

        public static Size operator -(Size S1, float Scale)
        {
            return new Size(S1.W - Scale, S1.H - Scale);
        }

        public static Size operator +(Size S1, Size S2)
        {
            return new Size(S1.W + S2.W, S1.H + S2.H);
        }

        public static Size operator +(Size S1, float Scale)
        {
            return new Size(S1.W + Scale, S1.H + Scale);
        }

        public static Size operator /(Size S, float Scale)
        {
            return new Size(S.W / Scale, S.H / Scale);
        }

        public static Size operator *(Size S, float Scale)
        {
            return new Size(S.W * Scale, S.H * Scale);
        }

        public static bool operator ==(Size S1, Size S2)
        {
            return (S1.W == S2.W && S1.H == S2.H);
        }

        public static bool operator !=(Size S1, Size S2)
        {
            return (S1.W != S2.W || S1.H != S2.H);
        }

        public static bool operator <=(Size S1, Size S2)
        {
            return (S1.W <= S2.W && S1.H <= S2.H);
        }

        public static bool operator >=(Size S1, Size S2)
        {
            return (S1.W >= S2.W && S1.H >= S2.H);
        }

        public static bool operator <(Size S1, Size S2)
        {
            return (S1.W < S2.W && S1.H < S2.H);
        }

        public static bool operator >(Size S1, Size S2)
        {
            return (S1.W > S2.W && S1.H > S2.H);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

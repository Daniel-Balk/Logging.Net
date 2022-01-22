namespace Logging.Net.ConsoleUI
{
    public struct ConsolePoint
    {
        public ConsolePoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }

        public static bool operator ==(ConsolePoint a, ConsolePoint b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(ConsolePoint a, ConsolePoint b)
        {
            return a.X != b.X | a.Y != b.Y;
        }

        public override bool Equals(object obj)
        {
            return this == (ConsolePoint)obj;
        }

        public override int GetHashCode()
        {
            long hp = (long)X.GetHashCode() + (long)Y.GetHashCode();
            return (int)(hp / 2L);
        }
    }
}
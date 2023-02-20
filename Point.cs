using System;

struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public double GetDistance(Point point)
    {
        int dx = this.X - point.X;
        int dy = this.Y - point.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_27
{
    public struct Vector32
    {

        public Vector32(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }
        public static bool operator ==(Vector32 left, Vector32 right)
        => left.X == right.X && left.Y == right.Y;
        public static bool operator !=(Vector32 left, Vector32 right)
        => !(left == right);
        public static Vector32 operator +(Vector32 left, Vector32 right)
        => new Vector32(left.X + right.X, left.Y + right.Y);
        public static Vector32 operator +(Vector32 left, int right)
        => new Vector32(left.X + right, left.Y + right);
        public static Vector32 operator +(int left, Vector32 right)
        => right + left;
        public static Vector32 operator -(Vector32 left, Vector32 right)
        => new Vector32(left.X - right.X, left.Y - right.Y);
        public static Vector32 operator -(Vector32 left, int right)
        => new Vector32(left.X - right, left.Y - right);
        public static Vector32 operator -(int left, Vector32 right)
        => right - left;
        public static implicit operator Vector64(Vector32 vector)
        => new Vector64(vector.X, vector.Y);
        public override string ToString() => $"{{{X}, {Y}}}";
    }

    public struct Vector64
    {
        public Vector64(long x, long y)
        {
            X = x;
            Y = y;
        }
        public long X { get; }
        public long Y { get; }
        public override string ToString() => $"{{{X}, {Y}}}";
    }

}

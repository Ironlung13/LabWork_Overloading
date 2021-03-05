using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Overloading
{
    public class Vector3D
    {
        public (int X0, int Y0, int Z0) Start { get; } = (0, 0, 0);
        public (int X, int Y, int Z) End { get; }

        private Vector3D() { }
        public Vector3D(int x, int y, int z, int x0, int y0, int z0)
        {
            End = (x, y, z);
            Start = (x0, y0, z0);
        }
        public Vector3D(int x, int y, int z) : this(x, y, z, 0, 0, 0) { }
        public Vector3D((int x, int y, int z) end) : this(end.x, end.y, end.z, 0, 0, 0) { }
        public Vector3D((int x, int y, int z) end, int x0, int y0, int z0) : this(end.x, end.y, end.z, x0, y0, z0) { }
        public Vector3D((int x, int y, int z) end, (int x0, int y0, int z0) start) : this(end, start.x0, start.y0, start.z0) { }
        public override string ToString()
        {
            return base.ToString();
        }

        public static Vector3D Sum(Vector3D a, Vector3D b)
        {
            if (a.Start != b.Start)
            {
                throw new ArgumentException("Can't sum vectors!");
            }
            return new Vector3D((a.End.X + b.End.X, a.End.Y + b.End.Y, a.End.Z + b.End.Z) ,a.Start);
        }
        public static Vector3D MultiplyByNumber(Vector3D a, int number)
        {
            return new Vector3D((a.End.X * number, a.End.Y * number, a.End.Z * number), a.Start);
        }

        public static Vector3D operator+(Vector3D a, Vector3D b)
        {
            return Sum(a, b);
        }
        public static Vector3D operator*(Vector3D a, int number)
        {
            return MultiplyByNumber(a, number);
        }
    }
}

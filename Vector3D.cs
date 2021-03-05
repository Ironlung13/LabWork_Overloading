using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Overloading
{
    public class Vector3D
    {
        public (double X0, double Y0, double Z0) Start { get; } = (0, 0, 0);
        public (double X, double Y, double Z) End { get; }

        private Vector3D() { }
        public Vector3D(double x, double y, double z, double x0, double y0, double z0)
        {
            End = (x, y, z);
            Start = (x0, y0, z0);
        }
        public Vector3D(double x, double y, double z) : this(x, y, z, 0, 0, 0) { }
        public Vector3D((double x, double y, double z) end) : this(end.x, end.y, end.z, 0, 0, 0) { }
        public Vector3D((double x, double y, double z) end, double x0, double y0, double z0) : this(end.x, end.y, end.z, x0, y0, z0) { }
        public Vector3D((double x, double y, double z) end, (double x0, double y0, double z0) start) : this(end, start.x0, start.y0, start.z0) { }
        public override string ToString()
        {
            return $"Vector base point: [X:{Start.X0,6:F2}, Y:{Start.Y0,6:F2}, Z:{Start.Z0,6:F2}].\nVector end point:  [X:{End.X,6:F2}, Y:{End.Y,6:F2}, Z:{End.Z,6:F2}].";
        }
        public static Vector3D Sum(Vector3D a, Vector3D b)
        {
            try
            {
                return new Vector3D((a.End.X + b.End.X,
                                     a.End.Y + b.End.Y,
                                     a.End.Z + b.End.Z), a.Start);
            }
            catch (OverflowException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
        }
        public static Vector3D Sum(Vector3D a, (double x, double y, double z) values)
        {
            try
            {
                return new Vector3D((a.End.X + values.x,
                                     a.End.Y + values.y,
                                     a.End.Z + values.z), a.Start);
            }
            catch (OverflowException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
        }
        public static Vector3D Subtract(Vector3D a, Vector3D b)
        {
            try
            {
                return new Vector3D((a.End.X - b.End.X,
                                     a.End.Y - b.End.Y,
                                     a.End.Z - b.End.Z), a.Start);
            }
            catch (OverflowException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
        }
        public static Vector3D Subtract(Vector3D a, (double x, double y, double z) values)
        {
            try
            {
                return new Vector3D((a.End.X - values.x,
                                     a.End.Y - values.y,
                                     a.End.Z - values.z), a.Start);
            }
            catch (OverflowException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
        }
        public static Vector3D Multiply(Vector3D a, double number)
        {
            try
            {
                return new Vector3D((a.End.X * number,
                                     a.End.Y * number,
                                     a.End.Z * number), a.Start);
            }
            catch (OverflowException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
        }
        public static Vector3D Multiply(Vector3D a, Vector3D b)
        {
            return new Vector3D((a.End.Y * b.End.Z - a.End.Z * b.End.Y, 
                                 a.End.X * b.End.Z - a.End.Z * b.End.X, 
                                 a.End.X * b.End.Y - a.End.Y * b.End.X), a.Start);
        }

        public static Vector3D operator+(Vector3D a, Vector3D b)
        {
            return Sum(a, b);
        }
        public static Vector3D operator+(Vector3D a, (double x, double y, double z) values)
        {
            return Sum(a, values);
        }
        public static Vector3D operator-(Vector3D a, Vector3D b)
        {
            return Subtract(a, b);
        }
        public static Vector3D operator-(Vector3D a, (double x, double y, double z) values)
        {
            return Subtract(a, values);
        }
        public static Vector3D operator*(Vector3D a, double number)
        {
            return Multiply(a, number);
        }
        public static Vector3D operator*(Vector3D a, Vector3D b)
        {
            return Multiply(a, b);
        }
    }
}

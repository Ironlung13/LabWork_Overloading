using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Overloading
{
    public class Vector3D
    {
        public (double X, double Y, double Z) EndPoint { get; }

        private Vector3D() { }
        public Vector3D(double x, double y, double z)
        {
            EndPoint = (x, y, z);
        }
        public Vector3D((double x, double y, double z) end) : this(end.x, end.y, end.z) { }
        public override string ToString()
        {
            return $"Vector end point:  [X:{EndPoint.X,6:F2}, Y:{EndPoint.Y,6:F2}, Z:{EndPoint.Z,6:F2}].";
        }
        public static Vector3D Sum(Vector3D a, Vector3D b)
        {
            try
            {
                return new Vector3D((a.EndPoint.X + b.EndPoint.X,
                                     a.EndPoint.Y + b.EndPoint.Y,
                                     a.EndPoint.Z + b.EndPoint.Z));
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
                return new Vector3D((a.EndPoint.X + values.x,
                                     a.EndPoint.Y + values.y,
                                     a.EndPoint.Z + values.z));
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
                return new Vector3D((a.EndPoint.X - b.EndPoint.X,
                                     a.EndPoint.Y - b.EndPoint.Y,
                                     a.EndPoint.Z - b.EndPoint.Z));
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
                return new Vector3D((a.EndPoint.X - values.x,
                                     a.EndPoint.Y - values.y,
                                     a.EndPoint.Z - values.z));
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
                return new Vector3D((a.EndPoint.X * number,
                                     a.EndPoint.Y * number,
                                     a.EndPoint.Z * number));
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
            return new Vector3D((a.EndPoint.Y * b.EndPoint.Z - a.EndPoint.Z * b.EndPoint.Y, 
                                 a.EndPoint.X * b.EndPoint.Z - a.EndPoint.Z * b.EndPoint.X, 
                                 a.EndPoint.X * b.EndPoint.Y - a.EndPoint.Y * b.EndPoint.X));
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

using System;

namespace HW11
{
    internal class Task1
    {
        public class Vector3D
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }

            public Vector3D(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public Vector3D MultiplyByScalar(double scalar)
            {
                return new Vector3D(X * scalar, Y * scalar, Z * scalar);
            }

            public Vector3D Add(Vector3D otherVector)
            {
                return new Vector3D(X + otherVector.X, Y + otherVector.Y, Z + otherVector.Z);
            }

            public Vector3D Subtract(Vector3D otherVector)
            {
                return new Vector3D(X - otherVector.X, Y - otherVector.Y, Z - otherVector.Z);
            }
        }
    }
}

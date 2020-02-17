using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chumaxhenko
{
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector()
            : this(0.0, 0.0, 0.0)
        {
        }
        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public double Length()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }
        public double SkalComposotion(Vector vec01)
        {
            return (vec01.X + vec01.Y + vec01.Z);
        }
        public double SkalComposotion(double xVec, double yVec, double zVec)
        {
            return X * xVec + Y * yVec + Z * zVec;
        }
        public Vector Composotion(Vector vec01)
        {
            Vector res = new Vector();
            res.X = Y * vec01.Z - Z - vec01.Y;
            res.Y = Z * vec01.X - X * vec01.Z;
            res.Z = X * vec01.Y - Y * vec01.X;
            return res;
        }
        public Vector Composition(double xVec, double yVec, double zVec)
        {
            Vector res = new Vector();
            res.X = Y * zVec - Z - yVec;
            res.Y = Z * xVec - X * zVec;
            res.Z = X * yVec - Y * xVec;
            return res;
        }
        public override string ToString()
        {
            return ($"x={X},  y={Y}, z={Z}.");
        }
    }
}

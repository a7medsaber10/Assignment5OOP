using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5OOP.Classes
{
    internal class _3DPoint : IComparable, ICloneable
    {

        #region Properties
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        #endregion

        #region Methods
        public _3DPoint(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }


        public _3DPoint(int x, int y) : this(x, y, 0)
        {

        }

        public _3DPoint(int x) : this(x, 0, 0)
        {

        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(object? obj)
        {
            _3DPoint otherPoint = (_3DPoint)obj;

            if ((this.X < otherPoint.X) && (this.Y < otherPoint.Y))
            {
                return -1;
            }
            else if ((this.X > otherPoint.X) && (this.Y > otherPoint.Y))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public object Clone()
        {
            return new _3DPoint(this.X, this.Y, this.Z);
        }

        public static bool operator ==(_3DPoint p1, _3DPoint p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }

        public static bool operator !=(_3DPoint p1, _3DPoint p2)
        {
            return !(p1 == p2);
        } 
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Inferno.Framework
{
    /// <summary>
    /// A 2 Point Vector
    /// </summary>
    public struct Vector2
    {
        #region Private Fields
        private static readonly Vector2 zeroVector = new Vector2(0f, 0f);
        private static readonly Vector2 unitVector = new Vector2(1f, 1f);
        private static readonly Vector2 unitXVector = new Vector2(1f, 0f);
        private static readonly Vector2 unitYVector = new Vector2(0f, 1f);

        #endregion

        #region Public Fields

        /// <summary>
        /// The X modifier of the Vector
        /// </summary>
        public float X;

        /// <summary>
        /// The Y modifier of the Vector
        /// </summary>
        public float Y;

        #endregion

        #region Public Properties

        /// <summary>
        /// The size of the vector
        /// </summary>
        public float Magnitude
        {
            get
            {
                return (float)Math.Sqrt(X * X + Y * Y);
            }
        }

        #endregion

        #region Static Properties

        public static Vector2 Zero
        {
            get
            {
                return zeroVector;
            }
        }

        public static Vector2 One
        {
            get
            {
                return unitVector;
            }
        }

        public static Vector2 UnitX
        {
            get
            {
                return unitXVector;
            }
        }

        public static Vector2 UnitY
        {
            get
            {
                return unitYVector;
            }
        }

        #endregion

        #region Constructors

        public Vector2(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Vector2(float val)
        {
            this.X = val;
            this.Y = val;
        }

        #endregion

        #region Operators

        public static Vector2 operator -(Vector2 value)
        {
            value.X = -value.X;
            value.Y = -value.Y;
            return value;
        }

        public void Invert()
        {
            X = -X;
            Y = -Y;
        }

        public static Vector2 Invert(Vector2 value)
        {
            return -value;
        }

        public static void Invert(Vector2 value, out Vector2 result)
        {
            result = -value;
        }

        public static Vector2 operator +(Vector2 value1, Vector2 value2)
        {
            value1.X += value2.X;
            value1.Y += value2.Y;
            return value1;
        }

        public static Vector2 operator -(Vector2 value1, Vector2 value2)
        {
            value1.X -= value2.X;
            value1.Y -= value2.Y;
            return value1;
        }

        public void Subtract(Vector2 sub)
        {
            X -= sub.X;
            Y -= sub.Y;
        }

        public static Vector2 Subtract(Vector2 value1, Vector2 value2)
        {
            return value1 - value2;
        }

        public static void Subtract(Vector2 value1, Vector2 value2, out Vector2 result)
        {
            result = value1 - value2;
        }

        public static Vector2 operator *(Vector2 value1, Vector2 value2)
        {
            value1.X *= value2.X;
            value1.Y *= value2.Y;
            return value1;
        }

        public void Multiply(Vector2 mult)
        {
            X *= mult.X;
            Y *= mult.Y;
        }

        public static Vector2 Multiply(Vector2 value1, Vector2 value2)
        {
            return value1 * value2;
        }

        public static void Multiply(Vector2 value1, Vector2 value2, out Vector2 result)
        {
            result = value1 * value2;
        }

        public static Vector2 operator *(Vector2 value, float sf)
        {
            value.X *= sf;
            value.Y *= sf;
            return value;
        }

        public void Multiply(float sf)
        {
            X *= sf;
            Y *= sf;
        }

        public static Vector2 Multiply(Vector2 value1, float sf)
        {
            return value1 * sf;
        }

        public static void Multiply(Vector2 value1, float sf, out Vector2 result)
        {
            result = value1 * sf;
        }

        public static Vector2 operator /(Vector2 value1, Vector2 value2)
        {
            value1.X /= value2.X;
            value1.Y /= value2.Y;
            return value1;
        }

        public void Divide(Vector2 div)
        {
            X /= div.X;
            Y /= div.Y;
        }

        public static Vector2 Divide(Vector2 value1, Vector2 value2)
        {
            return value1 / value2;
        }

        public static void Divide(Vector2 value1, Vector2 value2, out Vector2 result)
        {
            result = value1 / value2;
        }

        public static Vector2 operator /(Vector2 value, float div)
        {
            value.X /= div;
            value.Y /= div;
            return value;
        }

        public void Divide(float div)
        {
            X /= div;
            Y /= div;
        }

        public static Vector2 Divide(Vector2 value1, float div)
        {
            return value1 / div;
        }

        public static void Divide(Vector2 value1, float div, out Vector2 result)
        {
            result = value1 / div;
        }

        public static bool operator ==(Vector2 value1, Vector2 value2)
        {
            return value1.X == value2.X && value1.Y == value2.Y;
        }

        public bool Equals(Vector2 value)
        {
            return X == value.X && Y == value.Y;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Vector2))
            {
                return Equals((Vector2)obj);
            }
            return false;
        }

        public static bool Equals(Vector2 value1, Vector2 value2)
        {
            return value1 == value2;
        }

        public static bool operator !=(Vector2 value1, Vector2 value2)
        {
            return value1.X != value2.X || value1.Y != value2.Y;
        }

        public override int GetHashCode()
        {
            //From monogame because I have no idea
            return (X.GetHashCode() * 397) ^ Y.GetHashCode();
        }

        #endregion
    }
}

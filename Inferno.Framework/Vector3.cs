using System;
using System.Collections.Generic;
using System.Text;

namespace Inferno.Framework
{
    public struct Vector3
    {
        #region Private Fields

        private static readonly Vector3 zeroVector = new Vector3(0f, 0f, 0f);
        private static readonly Vector3 unitVector = new Vector3(1f, 1f, 1f);
        private static readonly Vector3 unitXVector = new Vector3(1f, 0f, 0f);
        private static readonly Vector3 unitYVector = new Vector3(0f, 1f, 0f);
        private static readonly Vector3 unitZVector = new Vector3(0f, 0f, 1f);

        #endregion

        #region Public Fields

        public float X;
        public float Y;
        public float Z;

        #endregion

        #region Public Properties

        public float Magnitude
        {
            get
            {
                return (float)Math.Sqrt(X * X + Y * Y + Z * Z);
            }
        }

        #endregion

        #region Static Properties

        #endregion

        #region Constructors

        public Vector3(float X, float Y, float Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public Vector3(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
            this.Z = 0;
        }

        public Vector3(Vector2 v2)
        {
            this.X = v2.X;
            this.Y = v2.Y;
            this.Z = 0;
        }

        #endregion

        #region Operators

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Inferno.Framework
{
    public struct Rectangle
    {
        public int X;
        public int Y;
        public int Height;
        public int Width;

        public Rectangle(int X, int Y, int Height, int Width)
        {
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Height = Height;
        }
    }
}

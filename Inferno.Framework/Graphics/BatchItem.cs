using System;
using System.Collections.Generic;
using System.Text;

namespace Inferno.Framework.Graphics
{
    public struct BatchItem
    {
        public Vector2 Position;
        public float Depth;
        public Texture2D Texture;
        public float Width;
        public float Height;

        public BatchItem(Vector2 Position, float Depth, Texture2D Texture)
        {
            this.Position = Position;
            this.Depth = Depth;
            this.Texture = Texture;
            this.Width = Texture.Width;
            this.Height = Texture.Height;
        }

        public BatchItem(Vector2 Position, float Depth, Texture2D Texture, float Width, float Height)
        {
            this.Position = Position;
            this.Depth = Depth;
            this.Texture = Texture;
            this.Width = Width;
            this.Height = Height;
        }
    }
}

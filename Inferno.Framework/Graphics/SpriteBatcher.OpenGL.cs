#if OpenGL

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Inferno.Framework.Graphics
{
    public partial class SpriteBatcher
    {
		public void DrawItem(BatchItem item)
        {
            GL.BindTexture(TextureTarget.Texture2D, item.Texture.ID);
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.5f, 0.5f, 0.5f);

            GL.Vertex2(item.Position.X, item.Position.Y);
            GL.Vertex2(item.Position.X + item.Width, item.Position.Y);
            GL.Vertex2(item.Position.X + item.Width, item.Position.Y + item.Height);
            GL.Vertex2(item.Position.X, item.Position.Y + item.Height);

            GL.End();
        }
    }
}

#endif
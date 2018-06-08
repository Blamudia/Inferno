#if OpenGL

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Inferno.Framework.Graphics
{
    //This is where the OpenGL specific components of Texture2D is stored
#pragma warning disable CS0282 // There is no defined ordering between fields in multiple declarations of partial struct
    public partial struct Texture2D
#pragma warning restore CS0282 // There is no defined ordering between fields in multiple declarations of partial struct
    {
        private int id;
        public int ID
        {
            get
            {
                return id;
            }
        }

        public void Setup()
        {
            //This will configure the texture for OpenGL
            id = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2D, id);

            BitmapData data = _bmp.LockBits(new System.Drawing.Rectangle(0, 0, _bmp.Width, _bmp.Height),
                ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, data.Width, data.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);
            _bmp.UnlockBits(data);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);
        }

        #region Constructors

        public Texture2D(string FilePath)
        {
            this._Path = FilePath;
            this._bmp = new Bitmap(_Path);
            this.id = -1;
            Setup();
        }

        #endregion
    }
}

#endif
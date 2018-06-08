using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Inferno.Framework.Graphics
{
#pragma warning disable CS0282 // There is no defined ordering between fields in multiple declarations of partial struct
    public partial struct Texture2D
#pragma warning restore CS0282 // There is no defined ordering between fields in multiple declarations of partial struct
    {
        #region Generic Fields

        private readonly string _Path;
        private Bitmap _bmp;

        public int Width
        {
            get
            {
                return _bmp.Width;
            }
        }

        public int Height
        {
            get
            {
                return _bmp.Height;
            }
        }

        #endregion
    }
}

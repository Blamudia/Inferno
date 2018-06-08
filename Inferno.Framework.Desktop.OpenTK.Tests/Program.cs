using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inferno.Framework.Graphics;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace TestingNs
{
    class Program
    {
        static void Main()
        {
            new Tests().Run();
        }
    }

    public class Tests : GameWindow
    {
        public Tests() : base(300, // initial width
                            300, // initial height
                            GraphicsMode.Default,
                            "dreamstatecoding",  // initial title
                            GameWindowFlags.Default,
                            DisplayDevice.Default,
                            4, // OpenGL major version
                            0, // OpenGL minor version
                            GraphicsContextFlags.ForwardCompatible)
        {
            Title += ": OpenGL Version: " + GL.GetString(StringName.Version);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.Enable(EnableCap.Texture2D);

            CursorVisible = true;

            nthings = new Texture2D("nerdthings.png");
        }

        Texture2D nthings;

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            Title = $"(Vsync: {VSync}) FPS: {1f / e.Time:0}";

            Color4 backColor;
            backColor.A = 1.0f;
            backColor.R = 1f;
            backColor.G = 1f;
            backColor.B = 1f;
            GL.ClearColor(backColor);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            //GL.LoadIdentity();

            //GL.Translate(-1f, 0f, 0);

            SpriteBatch.Begin();

            SpriteBatch.Draw(nthings, new Inferno.Framework.Vector2(0f, 0f), 500f/Width, 500f/Height);

            SpriteBatch.End();

            SwapBuffers();
        }
    }
}

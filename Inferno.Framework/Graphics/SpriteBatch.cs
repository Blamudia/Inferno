using System;
using System.Collections.Generic;
using System.Text;

namespace Inferno.Framework.Graphics
{
    public enum BatchSortMode
    {
        Immediate,
        Depth
    }

    public static class SpriteBatch
    {
        private static List<BatchItem> _CurrentBatch;
        private static bool _CalledBegin = false;
        private static BatchSortMode _SortMode;
        private static SpriteBatcher _SpriteBatcher;

        public static void Begin(BatchSortMode sortMode = BatchSortMode.Immediate)
        {
            if (_CalledBegin)
                throw new InvalidOperationException("Cannot call Begin again until End() has been called");
            _CalledBegin = true;

            if (_CurrentBatch == null)
                _CurrentBatch = new List<BatchItem>();

            _CurrentBatch.Clear();

            if (_SpriteBatcher == null)
                _SpriteBatcher = new SpriteBatcher();
        }

        public static void Draw(Texture2D texture, Vector2 Position)
        {
            _CurrentBatch.Add(new BatchItem(Position, 0, texture));
        }

        public static void Draw(Texture2D texture, Vector2 Position, float Width, float Height)
        {
            _CurrentBatch.Add(new BatchItem(Position, 0, texture, Width, Height));
        }

        public static void End()
        {
            //This is where we sort and draw the batch

            switch (_SortMode)
            {
                case BatchSortMode.Immediate:
                default:
                    //Just draw the entire list regardless of the depth or order
                    for (int i = 0; i < _CurrentBatch.Count; i++)
                        _SpriteBatcher.DrawItem(_CurrentBatch[i]);
                    break;
            }

            _CurrentBatch.Clear();

            _CalledBegin = false;
        }
    }
}

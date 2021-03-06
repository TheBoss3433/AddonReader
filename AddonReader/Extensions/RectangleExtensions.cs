﻿using System.Drawing;
using PInvoke;

namespace TenBot.Extensions
{
    public static class RectangleExtensions
    {
        public static Rectangle Move(this Rectangle rectangle, Point offset)
        {
            var x = rectangle.X + offset.X;
            var y = rectangle.Y + offset.Y;

            return new Rectangle(new Point(x, y), rectangle.Size);
        }

        public static Rectangle ToRectangle(this RECT r)
        {
            return new Rectangle(r.left, r.top, r.right - r.left, r.bottom - r.top);
        }

        public static Point Middle(this Rectangle rectangle)
        {
            return new Point(rectangle.Location.X + rectangle.Width / 2, rectangle.Location.Y + rectangle.Height / 2);
        }
    }
}
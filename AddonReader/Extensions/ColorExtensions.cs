﻿using System.Drawing;

namespace AddonReader.Extensions
{
    public static class ColorExtensions
    {
        public static string ToChars(this Color color)
        {
            string chars = "";
            chars += ((char)color.R).ToString();
            chars += ((char)color.G).ToString();
            chars += ((char)color.B).ToString();
            return chars;
        }
        public static int ToInt(this Color color)
        {
            return (color.R + color.G * 256 + color.B * 256 * 256);
        }
        public static double ToDouble(this Color color)
        {
            return color.ToInt() / 10000.0;
        }

    }
}
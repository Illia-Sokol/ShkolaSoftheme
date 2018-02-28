using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Color
    {
        public ColorSchema CarColor { get; }

        public Color(ColorSchema color)
        {
            CarColor = color;
        }
    }

    enum ColorSchema
    {
        Black,
        White,
        Red,
        Blue,
        Silver,
        Yellow,
        Green
    }
}

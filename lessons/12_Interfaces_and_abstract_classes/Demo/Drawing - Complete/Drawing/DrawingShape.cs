using System;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace Drawing
{
    abstract class DrawingShape : IDraw, IColor
    {
        protected int Size;
        protected int LocX, LocY;
        protected Shape Shape = null;

        protected DrawingShape(int size)
        {
            Size = size;
        }

        public void SetLocation(int xCoord, int yCoord)
        {
            LocX = xCoord;
            LocY = yCoord;
        }

        public void SetColor(Color color)
        {
            if (Shape != null)
            {
                var brush = new SolidColorBrush(color);
                Shape.Fill = brush;
            }
        }

        public virtual void Draw(Canvas canvas)
        {
            if (Shape == null)
            {
                throw new InvalidOperationException("Shape is null");
            }

            Shape.Height = Size;
            Shape.Width = Size;
            Canvas.SetTop(Shape, LocY);
            Canvas.SetLeft(Shape, LocX);
            canvas.Children.Add(Shape);
        }

    }
}

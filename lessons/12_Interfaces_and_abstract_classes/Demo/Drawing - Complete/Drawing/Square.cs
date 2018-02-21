using System.Windows.Shapes;
using System.Windows.Controls;

namespace Drawing
{
    class Square : DrawingShape
    {
        public Square(int sideLength)
            : base(sideLength)
        {
        }

        public override void Draw(Canvas canvas)
        {
            if (Shape != null)
            {
                canvas.Children.Remove(Shape);
            }
            else
            {
                Shape = new Rectangle();
            }

            base.Draw(canvas);
        }
    }
}

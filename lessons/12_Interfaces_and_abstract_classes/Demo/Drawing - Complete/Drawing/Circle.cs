using System.Windows.Shapes;
using System.Windows.Controls;

namespace Drawing
{
    class Circle : DrawingShape
    {
        public Circle(int diameter)
            : base(diameter)
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
                Shape = new Ellipse();
            }

            base.Draw(canvas);
        }
    }
}

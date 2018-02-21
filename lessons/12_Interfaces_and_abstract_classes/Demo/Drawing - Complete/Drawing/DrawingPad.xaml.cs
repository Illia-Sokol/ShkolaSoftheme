using System.Windows.Input;
using System.Windows.Media;

namespace Drawing
{
    public partial class DrawingPadWindow
    {
        public DrawingPadWindow()
        {
            InitializeComponent();
        }

        private void drawingCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var mouseLocation = e.GetPosition(drawingCanvas);
            var mySquare = new Square(100);

            IDraw drawSquare = mySquare;
            drawSquare.SetLocation((int)mouseLocation.X, (int)mouseLocation.Y);
            drawSquare.Draw(drawingCanvas);

            IColor colorSquare = mySquare;
            colorSquare.SetColor(Colors.BlueViolet);
        }

        private void drawingCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var mouseLocation = e.GetPosition(drawingCanvas);
            var myCircle = new Circle(100);

            IDraw drawCircle = myCircle;
            drawCircle.SetLocation((int)mouseLocation.X, (int)mouseLocation.Y);
            drawCircle.Draw(drawingCanvas);

            IColor colorCircle = myCircle;
            colorCircle.SetColor(Colors.HotPink);
        }       
    }
}

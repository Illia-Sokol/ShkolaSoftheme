using System.Windows.Controls;

namespace Drawing
{
    interface IDraw
    {
        void SetLocation(int xCoord, int yCoord);

        void Draw(Canvas canvas);
    }
}

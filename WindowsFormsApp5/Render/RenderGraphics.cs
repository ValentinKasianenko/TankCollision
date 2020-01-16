using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    public class RenderGraphics
    {
        /// <summary> Залить поле цветом </summary>
        public void FillField(PictureBox picture, Color color)
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(color);

            picture.Image = bmp;
        }

        /// <summary> Нарисовать фигуры </summary>
        public void RenderFigures(PictureBox picture, List<IFigure> figures)
        {
            Graphics g = Graphics.FromImage(picture.Image);
            foreach (IFigure figure in figures)
            {
                g.DrawPath(new Pen(figure.GetCollision() ? figure.GetCollisionColor() : figure.GetColor()), figure.GetGraphics());
            }
        }
    }
}

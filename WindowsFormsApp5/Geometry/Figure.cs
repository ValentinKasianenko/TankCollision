using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Figures
{
    public class Figure : IFigure
    {
        GraphicsPath graphicsPath;
        bool isCollision;
        Color color;
        List<PointF> points;

        public Figure(Color color, List<PointF> points)
        {
            graphicsPath = new GraphicsPath();
            SetCollision(false);
            SetColor(color);
            StartFigure();
            SetPoints(points);
            EndFigure();
        }

        public Figure(Color color, List<PointF> points, float offsetX, float offsetY)
        {
            graphicsPath = new GraphicsPath();
            SetCollision(false);
            SetColor(color);
            StartFigure();
            SetPoints(points);
            AddOffset(offsetX, offsetY);
            EndFigure();
        }

        public void EndFigure()
        {
            graphicsPath.CloseFigure();
        }

        public bool GetCollision()
        {
            return isCollision;
        }

        public Color GetCollisionColor()
        {
            return Color.Red;
        }

        public Color GetColor()
        {
            return color;
        }

        public List<PointF> GetPoints()
        {
            return points;
        }

        public void SetCollision(bool isCollision)
        {
            this.isCollision = isCollision;
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        public void AddOffset(float offsetX, float offsetY)
        {
            List<PointF> newPoints = new List<PointF>() { };
            for (int i = 0; i < points.Count; i++)
            {
                newPoints.Add(new PointF(points[i].X + offsetX, points[i].Y + offsetY));
            }
            points = newPoints;
        }

        public void SetPoints(List<PointF> points)
        {
            this.points = points;
            graphicsPath.AddLines(points.ToArray());
        }

        public void StartFigure()
        {
            graphicsPath.StartFigure();
        }

        public GraphicsPath GetGraphics()
        {
            return graphicsPath;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    public class Movement : IMovement
    {
        private delegate List<PointF> DelegateMovement(List<PointF> points, float offset);

        readonly Dictionary<Keys, DelegateMovement> movementDictionary = new Dictionary<Keys, DelegateMovement>()
        {
            { Keys.A , (points, offset) => GoLeft(points, offset) },
            { Keys.D , (points, offset) => GoRight(points, offset) },
            { Keys.W , (points, offset) => GoTop(points, offset) },
            { Keys.S , (points, offset) => GoDown(points, offset) }
        };

        static List<PointF> GoLeft(List<PointF> points, float offset)
        {
            return AddOffset(points, -Math.Abs(offset), 0);
        }

        static List<PointF> GoRight(List<PointF> points, float offset)
        {
            return AddOffset(points, Math.Abs(offset), 0);
        }

        static List<PointF> GoTop(List<PointF> points, float offset)
        {
            return AddOffset(points, 0, -Math.Abs(offset));
        }

        static List<PointF> GoDown(List<PointF> points, float offset)
        {
           return AddOffset(points, 0, Math.Abs(offset));
        }

        public bool CheckValidKey(KeyEventArgs key)
        {
            return movementDictionary.ContainsKey(key.KeyCode);
        }

        private static List<PointF> AddOffset(List<PointF> points, float offsetX, float offsetY)
        {
            List<PointF> newPoints = new List<PointF>() { };
            for (int i = 0; i < points.Count; i++)
            {
                newPoints.Add(new PointF(points[i].X + offsetX, points[i].Y + offsetY));
            }

            return newPoints;
        }

        public List<PointF> GetNewPosition(KeyEventArgs key, List<PointF> points, float step)
        {
            return movementDictionary[key.KeyCode](points, step);
        }
    }
}

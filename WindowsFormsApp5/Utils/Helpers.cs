using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Figures
{
    public class Helpers
    {
        /// <summary> Выбор цвета </summary>
        public Color SelectColor(Color colorDefault)
        {
            ColorDialog colorDialog = new ColorDialog
            {
                FullOpen = true
            };

            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return colorDefault;
            }

            return colorDialog.Color;

        }

        /// <summary> Проверка на коллизию </summary>
        public bool CheckCollision(IFigure figureA, IFigure figureB)
        {
            // нашли пересечение отрезков
            List<string> linesA = new List<string>() { };
            for (int i = 0; i < figureA.GetPoints().Count - 1; i++)
            {
                linesA.Add(figureA.GetPoints()[i].X + "," + figureA.GetPoints()[i].Y + ";" + figureA.GetPoints()[i + 1].X + "," + figureA.GetPoints()[i + 1].Y + ";");
            }

            List<string> linesB = new List<string>() { };
            for (int i = 0; i < figureB.GetPoints().Count - 1; i++)
            {
                linesB.Add(figureB.GetPoints()[i].X + "," + figureB.GetPoints()[i].Y + ";" + figureB.GetPoints()[i + 1].X + "," + figureB.GetPoints()[i + 1].Y + ";");
            }

            bool collision = false;
            linesA.ForEach(_A => {
                linesB.ForEach(_B => {
                    PointF startA = new PointF(int.Parse(_A.Split(';')[0].Split(',')[0]), int.Parse(_A.Split(';')[0].Split(',')[1]));
                    PointF endA = new PointF(int.Parse(_A.Split(';')[1].Split(',')[0]), int.Parse(_A.Split(';')[1].Split(',')[1]));
                    PointF startB = new PointF(int.Parse(_B.Split(';')[0].Split(',')[0]), int.Parse(_B.Split(';')[0].Split(',')[1]));
                    PointF endB = new PointF(int.Parse(_B.Split(';')[1].Split(',')[0]), int.Parse(_B.Split(';')[1].Split(',')[1]));
                    if (CheckCollisionLines(startA, endA, startB, endB))
                    {
                        collision = true;
                    }
                });
            });

            if (collision)
            {
                return true;
            }

            return false;
        }

        /// <summary> Проверка что отрезки пересекаются </summary>
        public bool CheckCollisionLines(PointF startA, PointF endA, PointF startB, PointF endB)
        {
            float v1 = (endB.X - startB.X) * (startA.Y - startB.Y) - (endB.Y - startB.Y) * (startA.X - startB.X);
            float v2 = (endB.X - startB.X) * (endA.Y - startB.Y) - (endB.Y - startB.Y) * (endA.X - startB.X);
            float v3 = (endA.X - startA.X) * (startB.Y - startA.Y) - (endA.Y - startA.Y) * (startB.X - startA.X);
            float v4 = (endA.X - startA.X) * (startB.Y - startA.Y) - (endA.Y - startA.Y) * (endB.X - startA.X);
            return (v1 * v2 < 0) && (v3 * v4 < 0);
        }

        /// <summary> Получить массив точек через строку </summary>
        public List<PointF> GetPointsFromString(string pointsString)
        {
            List<PointF> pointsResult = new List<PointF>() { };
            ;

            if (pointsString.Length == 0)
            {
                return null;
            }

            string[] points = pointsString.Split(';');
            if (points.Length == 0)
            {
                return null;
            }

            for (int i = 0; i < points.Length; i++)
            {
                string[] pointPair = points[i].Split(',');
                if (pointPair.Length % 2 != 0 || pointPair[1] == "")
                {
                    return null;
                }
            }

            for (int i = 0; i < points.Length; i++)
            {
                string[] pointPair = points[i].Split(',');
                pointsResult.Add(new PointF(int.Parse(pointPair[0]), int.Parse(pointPair[1])));
            }

            return pointsResult;
        }

        /// <summary> Получить круг по радиусу и степени сжатия </summary>
        public string GetPointsForCircle(int radius, int CompressedLevel)
        {
            int angle = 360;
            StringBuilder resultBuild = new StringBuilder();
            for (int i = 0; i < angle; i++)
            {
                double rad = (double)i / 180 * 3.14;
                string x = string.Format("{0:0}", radius * Math.Cos(rad));
                string y = string.Format("{0:0}", radius * Math.Sin(rad));

                resultBuild.Append(x);
                resultBuild.Append(',');
                resultBuild.Append(y);
                resultBuild.Append(';');
            }
            string resulBuildString = resultBuild.ToString();
            string[] resulStringArr = resulBuildString.Remove(resulBuildString.Length - 1).Split(';');
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < resulStringArr.Length; i++)
            {
                if (i % CompressedLevel == 0)
                {
                    result.Append(resulStringArr[i]);
                    result.Append(';');
                }
            }

            string resultString = result.ToString();

            return resultString.Remove(resultString.Length - 1);
        }
    }
}

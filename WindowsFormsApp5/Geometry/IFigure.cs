using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Figures
{
    public interface IFigure
    {
        /// <summary> Получить граф путь </summary>
        GraphicsPath GetGraphics();

        /// <summary> Добавить смещение </summary>
        void AddOffset(float offsetX, float offsetY);

        /// <summary> Начать собирать фигуру </summary>
        void StartFigure();

        /// <summary> Закончить собирать фигуру </summary>
        void EndFigure();

        /// <summary> Получить цвет фигуры </summary>
        Color GetColor();

        /// <summary> Установить цвет фигуры </summary>
        void SetColor(Color color);

        /// <summary> Получить все точки фигуры </summary>
        List<PointF> GetPoints();

        /// <summary> Установить все точки фигуры </summary>
        void SetPoints(List<PointF> points);

        /// <summary> Получить цвет тела при косании </summary>
        Color GetCollisionColor();

        /// <summary> Установить значение косания </summary>
        void SetCollision(bool isCollision);

        /// <summary> Получить значение косания </summary>
        bool GetCollision();
    }
}

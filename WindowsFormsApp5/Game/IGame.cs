using System.Collections.Generic;

namespace Figures
{
    public interface IGame
    {
        /// <summary> Получить поле </summary>
        IField GetField();

        /// <summary> Установить поле </summary>
        void SetField(IField field);

        /// <summary> Получить фигуры </summary>
        List<IFigure> GetFigures();

        /// <summary> Установить фигуры </summary>
        void SetFigures(List<IFigure> figures);

        /// <summary> Добавить фигуру </summary>
        void AddFigure(IFigure figure);

        /// <summary> Получить перемещение </summary>
        IMovement GetMovement();

        /// <summary> Установить перемещение </summary>
        void SetMovement(IMovement movement);

        /// <summary> Очистить фигуры </summary>
        void ClearFigures();
    }
}

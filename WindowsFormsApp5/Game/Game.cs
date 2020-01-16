using System.Collections.Generic;

namespace Figures
{
    public class Game : IGame
    {
        IMovement movement;
        IField field;
        List<IFigure> figures;

        public Game(IMovement movement, IField field, List<IFigure> figures)
        {
            SetMovement(movement);
            SetField(field);
            SetFigures(figures);
        }

        public IMovement GetMovement()
        {
            return movement;
        }

        public IField GetField()
        {
            return field;
        }

        public List<IFigure> GetFigures()
        {
            return figures;
        }

        public void AddFigure(IFigure figure)
        {
            figures.Add(figure);
        }

        public void SetField(IField field)
        {
            this.field = field;
        }

        public void SetFigures(List<IFigure> figures)
        {
            this.figures = figures;
        }

        public void SetMovement(IMovement movement)
        {
            this.movement = movement;
        }

        public void ClearFigures()
        {
            figures.Clear();
        }
    }
}

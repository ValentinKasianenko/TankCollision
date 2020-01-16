using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    public interface IMovement: IAction
    {
        /// <summary> Добавить к точкам нужное смещение </summary>
        List<PointF> GetNewPosition(KeyEventArgs key, List<PointF> points, float step);
    }
}

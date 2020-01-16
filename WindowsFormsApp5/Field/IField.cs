using System.Drawing;

namespace Figures
{
    public interface IField
    {
        /// <summary> Получить цвет поля </summary>
        Color GetColorField();

        /// <summary> Задать цвет поля </summary>
        void SetColorField(Color color);
    }
}

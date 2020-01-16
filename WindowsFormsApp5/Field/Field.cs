using System.Drawing;

namespace Figures
{
    public class Field : IField
    {
        Color colorField;

        public Field(Color colorField)
        {
            this.colorField = colorField;
        }

        public Color GetColorField()
        {
            return colorField;
        }

        public void SetColorField(Color color)
        {
            colorField = color;
        }
    }
}

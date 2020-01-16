using System.Windows.Forms;

namespace Figures
{
    public interface IAction
    {
        /// <summary> Узнать принадлежность клавиши для действия </summary>
        bool CheckValidKey(KeyEventArgs key);
    }
}

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    public partial class MainForm : Form
    {
        RenderGraphics renderGraphics;
        Helpers helpers;
        IGame game;

        List<IFigure> currentFigures;

        public MainForm()
        {
            InitializeComponent();

            helpers = new Helpers();
            renderGraphics = new RenderGraphics();

            currentFigures = new List<IFigure>() { };
            IMovement movement = new Movement();
            IField field = new Field(PictureBoxColorField.BackColor);
            List<IFigure> figures = new List<IFigure>() { };

            game = new Game(movement, field, figures);
        }

        #region Поле
        /// <summary> Очистить поле </summary>
        private void ButtonClearField_Click(object sender, System.EventArgs e)
        {
            renderGraphics.FillField(PictureBoxField, game.GetField().GetColorField());
            game.ClearFigures();
            ListBoxFigures.Items.Clear();
        }

        /// <summary> Нарисовать поле и фигуры </summary>
        private void RenderAll()
        {
            renderGraphics.FillField(PictureBoxField, game.GetField().GetColorField());
            renderGraphics.RenderFigures(PictureBoxField, game.GetFigures());
        }

        /// <summary> Выбрать цвет поля </summary>
        private void ButtonColorFiled_Click(object sender, System.EventArgs e)
        {
            PictureBoxColorField.BackColor = helpers.SelectColor(PictureBoxColorField.BackColor);
            game.GetField().SetColorField(PictureBoxColorField.BackColor);
            RenderAll();
        }
        #endregion

        #region Нажатия клавиш
        /// <summary> Нажали клавишу </summary>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            MoveAllFigures(e);
        }

        /// <summary> Перемещение всех фигур </summary>
        private void MoveAllFigures(KeyEventArgs e)
        {
            if (!game.GetMovement().CheckValidKey(e))
            {
                return;
            }

            if (currentFigures.Count != 0)
            {
                int step = 1;
                // перемещаем активные фигуры
                currentFigures.ForEach(currentFigure =>
                {
                    List<PointF> newPoints = game.GetMovement().GetNewPosition(e, currentFigure.GetPoints(), step);
                    foreach (IFigure figure in game.GetFigures())
                    {
                        if (figure == currentFigure)
                        {
                            continue;
                        }

                        currentFigure.GetGraphics().Reset();
                        currentFigure.StartFigure();
                        currentFigure.SetPoints(newPoints);
                        currentFigure.EndFigure();
                    }
                });

                // проверяем все фигуры на коллизии
                foreach (IFigure _figure in game.GetFigures())
                {
                    bool isCollision = false;
                    foreach (IFigure figure in game.GetFigures())
                    {
                        if (figure == _figure)
                        {
                            continue;
                        }

                        if (helpers.CheckCollision(_figure, figure) || helpers.CheckCollision(figure, _figure))
                        {
                            isCollision = true;
                        }
                    }
                    _figure.SetCollision(isCollision);
                }

                RenderAll();
            }
        }
        #endregion

        #region Конструктор фигур
        /// <summary> Выбрать цвет тела фигуры </summary>
        private void ButtonFigureColorBody_Click(object sender, System.EventArgs e)
        {
            PictureBoxFigureColorBody.BackColor = helpers.SelectColor(PictureBoxFigureColorBody.BackColor);
        }

        /// <summary> Добавить фигуру на поле </summary>
        private void ButtonAddFigure_Click(object sender, System.EventArgs e)
        {
            List<PointF> pointsFigure = helpers.GetPointsFromString(TextBoxPointsFigure.Text);
            if (pointsFigure == null)
            {
                MessageBox.Show("Координаты фигуры не коректны");
                return;
            }
           
            IFigure figure = new Figure(PictureBoxFigureColorBody.BackColor, pointsFigure);

            game.AddFigure(figure);
            ListBoxFigures.Items.Add("Фигура №" + (ListBoxFigures.Items.Count + 1) + " [" + figure.GetPoints().Count + "-x угольник]");

            ListBoxFigures.ClearSelected();
            ListBoxFigures.SelectedIndex = ListBoxFigures.Items.Count - 1; // выбираем последнюю добавленную

            RenderAll();
        }
        #endregion

        #region Шаблоны фигур
        /// <summary> Получить 3 угольник </summary>
        private void IsPolygon3_CheckedChanged(object sender, System.EventArgs e)
        {
            TextBoxPointsFigure.Text = "0,0;30,60;60,0";
        }

        /// <summary> Получить 4 угольник </summary>
        private void IsPolygon4_CheckedChanged(object sender, System.EventArgs e)
        {
            TextBoxPointsFigure.Text = "100,0;150,50;100,150;0,100";
        }

        /// <summary> Получить 5 угольник </summary
        private void IsPolygon5_CheckedChanged(object sender, System.EventArgs e)
        {
            TextBoxPointsFigure.Text = "0,0;60,0;100,80;80,100;20,100";
        }

        /// <summary> Получить круг </summary>
        private void IsPolygonCircle_CheckedChanged(object sender, System.EventArgs e)
        {
            TextBoxPointsFigure.Text = helpers.GetPointsForCircle((int)NumericUpDownradiusCircle.Value, (int)NumericUpDownCompressedLevel.Value);
        }

        /// <summary> Получить круг </summary>
        private void NumericUpDownradiusCircle_ValueChanged(object sender, System.EventArgs e)
        {
            IsPolygonCircle.Select();
            TextBoxPointsFigure.Text = helpers.GetPointsForCircle((int)NumericUpDownradiusCircle.Value, (int)NumericUpDownCompressedLevel.Value);
        }

        /// <summary> Получить круг </summary>
        private void NumericUpDownCompressedLevel_ValueChanged(object sender, System.EventArgs e)
        {
            IsPolygonCircle.Select();
            TextBoxPointsFigure.Text = helpers.GetPointsForCircle((int)NumericUpDownradiusCircle.Value, (int)NumericUpDownCompressedLevel.Value);
        }

        /// <summary> Получить впуклый четрыех угольник </summary>
        private void IsInPolygon4_CheckedChanged(object sender, System.EventArgs e)
        {
            TextBoxPointsFigure.Text = "100,200;200,100;150,200;200,300";
        }
        #endregion

        /// <summary> Выбрали другую фигуру </summary>
        private void ListBoxFigures_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SelectFigures();
        }

        /// <summary> Выбрать выделенные фигуры </summary>
        private void SelectFigures()
        {
            var enumerator = ListBoxFigures.SelectedIndices.GetEnumerator();
            currentFigures.Clear();

            while (enumerator.MoveNext())
            {
                AddSelectFigure((int)enumerator.Current);
            }
        }

        /// <summary> Добавить фигуру по индексу </summary>
        private void AddSelectFigure(int index)
        {
            currentFigures.Add(game.GetFigures()[index]);
        }
    }
}

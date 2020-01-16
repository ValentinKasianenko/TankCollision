using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Drawing;

namespace FiguresTest
{
    [TestClass]
    public class CollisionTests
    {
        Helpers helpers;

        [TestInitialize]
        public void Initialize()
        {     
            helpers = new Helpers();
        }
        
        /// <summary> ���� �� ��, ��� ������� ������������ </summary>
        [TestMethod]
        public void TestFigureCollisionLines()
        {
            Assert.IsTrue(helpers.CheckCollisionLines(new PointF(1,1), new PointF(5,5), new PointF(1,2), new PointF(3,1)));
        }

        /// <summary> ���� �� ��, ��� ������� �� ������������ </summary>
        [TestMethod]
        public void TestFigureNoCollisionLines()
        {
            Assert.IsFalse(helpers.CheckCollisionLines(new PointF(1, 1), new PointF(1, 5), new PointF(2, 1), new PointF(2, 5)));
        }

        /// <summary> ���� �� ��������� ����������� ���� ����� </summary>
        [TestMethod]
        public void TestFigureCollision()
        {
            IFigure figureA = new Figure(Color.Red, helpers.GetPointsFromString("100,100;200,100;100,200;200,200"));
            IFigure figureB = new Figure(Color.Red, helpers.GetPointsFromString("100,150;200,150;110,160"));
            //5,5; 30,50; 50,5
            Assert.IsTrue(helpers.CheckCollision(figureA, figureB));
        }

        /// <summary> ���� �� ��������� ������������� ���� ����� </summary>
        [TestMethod]
        public void TestFigureNoCollision()
        {
            IFigure figureA = new Figure(Color.Red, helpers.GetPointsFromString("100,100;200,100;100,200;200,200"));
            IFigure figureB = new Figure(Color.Red, helpers.GetPointsFromString("0,0;30,60;60,0"));
            //5,5; 30,50; 50,5
            Assert.IsFalse(helpers.CheckCollision(figureA, figureB));
        }

        /// <summary> ���� �� ������ </summary>
        [TestMethod]
        public void TestFigureCollisionBublik()
        {
            IFigure figureA = new Figure(Color.Red, helpers.GetPointsFromString("0,0;30,60;60,0"));
            IFigure figureB = new Figure(Color.Red, helpers.GetPointsFromString("5,5; 30,50; 50,5"));
            //5,5; 30,50; 50,5
            Assert.IsFalse(helpers.CheckCollision(figureA, figureB));
        }

        /// <summary> ���� �� ��, ��� �������� ������ ������������ � �������� (����������� � �������� ����) </summary>
        [TestMethod]
        public void TestFigureNoCollision�onvexVsConcave()
        {
            IFigure figureA = new Figure(Color.Red, helpers.GetPointsFromString("100,100;200,100;100,200;200,200"));
            IFigure figureB = new Figure(Color.Red, helpers.GetPointsFromString("100,150;120,150;110,160"));
            //5,5; 30,50; 50,5
            Assert.IsFalse(helpers.CheckCollision(figureA, figureB));

            IFigure figureA1 = new Figure(Color.Red, helpers.GetPointsFromString("100,100;200,100;100,200;200,200"));
            IFigure figureB1 = new Figure(Color.Red, helpers.GetPointsFromString("150,170; 150,190; 155,180"));
            //5,5; 30,50; 50,5
            Assert.IsFalse(helpers.CheckCollision(figureA1, figureB1));
        }

        /// <summary> ���� �� ����������� ���� ������ (���� �� ������ �� ���� ���������) </summary>
        [TestMethod]
        public void TestDoubleFigureNoCollision�onvexVsConcave()
        {
            IFigure figureMain = new Figure(Color.Red, helpers.GetPointsFromString("100,100;200,100;100,200;200,200"));
            bool collision = false;

            List<IFigure> figures = new List<IFigure>()
            {
               new Figure(Color.Red, helpers.GetPointsFromString("100,150;200,150;110,160")), //����������
               new Figure(Color.Red, helpers.GetPointsFromString("150,170; 150,190; 155,180")), //�� ����������
            };

            figures.ForEach(figure =>
            {
                if (helpers.CheckCollision(figureMain, figure) == true)
                {
                    collision = true;
                }
            });
            Assert.AreEqual(collision, true);
        }

        /// <summary> ���� �� ����������� ���� ������ (���� �� ������ �� ���� ���������) </summary>
        [TestMethod]
        public void TestDoubleFigureVeryNoCollision�onvexVsConcave()
        {
            IFigure figureMain = new Figure(Color.Red, helpers.GetPointsFromString("100,100;200,100;100,200;200,200"));
            bool collision = false;

            List<IFigure> figures = new List<IFigure>()
            {
               new Figure(Color.Red, helpers.GetPointsFromString("150,120; 150,140; 155,130")), // �� ����������
               new Figure(Color.Red, helpers.GetPointsFromString("150,170; 150,190; 155,180")), //�� ����������
            };

            figures.ForEach(figure =>
            {
                if (helpers.CheckCollision(figureMain, figure) == true)
                {
                    collision = true;
                }
            });
            Assert.AreEqual(collision, false);
        }

        /// <summary> ���� �� ����������� ���� ������ (���� �� ������ �� ���� ���������) </summary>
        [TestMethod]
        public void TestDoubleFigureVeryCollision�onvexVsConcave()
        {
            IFigure figureMain = new Figure(Color.Red, helpers.GetPointsFromString("100,100;200,100;100,200;200,200"));
            bool collision = false;

            List<IFigure> figures = new List<IFigure>()
            {
               new Figure(Color.Red, helpers.GetPointsFromString("100,150;200,150;110,160")), // ����������
               new Figure(Color.Red, helpers.GetPointsFromString("150,250; 150,190; 155,180")), //����������
            };

            figures.ForEach(figure =>
            {
                if (helpers.CheckCollision(figureMain, figure) == true)
                {
                    collision = true;
                }
            });
            Assert.AreEqual(collision, true);
        }

        /// <summary> ���� �� ��, ��� �������� ������ ���������� � �������� </summary>
        [TestMethod]
        public void TestFigureCollision�onvexVsConcave()
        {
            IFigure figureA = new Figure(Color.Red, helpers.GetPointsFromString("100,100;200,100;100,200;200,200"));
            IFigure figureB = new Figure(Color.Red, helpers.GetPointsFromString("100,150;200,150;110,160"));
            //5,5; 30,50; 50,5
            Assert.IsTrue(helpers.CheckCollision(figureA, figureB));
        }
    }
}

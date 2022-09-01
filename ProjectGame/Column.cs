using System.Drawing;
using System.Windows.Forms;

namespace ProjectGame
{
    public partial class Column : UserControl
    {
        public enum EColor
        {
            White,
            Red,
            Blue
        }

        public enum EState
        {
            Start,
            Background,
            First,
            Second,
            Third,
            Fourth,
            Fifth,
            Sixth,
            Final
        }

        #region Fields

        private const float LIGHT_BORDER_PERCENTAGE = 0.05f;
        private int numberOfTokens = 0;
        public EState StateOfRow = EState.Start;
        private readonly Brush backgrounBrush = new SolidBrush(Color.Gray);
        private Brush firstBrush = new SolidBrush(Color.White);
        private Brush secondBrush = new SolidBrush(Color.White);
        private Brush thirdBrush = new SolidBrush(Color.White);
        private Brush fourthBrush = new SolidBrush(Color.White);
        private Brush fifthBrush = new SolidBrush(Color.White);
        private Brush sixthBrush = new SolidBrush(Color.White);
        public int[] tokens = new int[6];

        #endregion Fields

        public Column()
        {
            InitializeComponent();
        }

        public void ResetColumn()
        {
            firstBrush = new SolidBrush(Color.White);
            secondBrush = new SolidBrush(Color.White);
            thirdBrush = new SolidBrush(Color.White);
            fourthBrush = new SolidBrush(Color.White);
            fifthBrush = new SolidBrush(Color.White);
            sixthBrush = new SolidBrush(Color.White);
            StateOfRow = EState.Start;
            numberOfTokens = 0;
            Invalidate();
        }

        private float GetLeftFloat(Graphics g)
        {
            return g.VisibleClipBounds.Width / 2f - GetLightRadius(g) / 2f;
        }

        private float GetTopFloat(Graphics g, int idFromTop)
        {
            return GetBoxHeight(g) * idFromTop + GetBoxHeight(g) * LIGHT_BORDER_PERCENTAGE;
        }

        private void DrawBackground(Graphics g)
        {
            g.FillRectangle(backgrounBrush, g.VisibleClipBounds);
        }

        private void DrawFirst(Graphics g)
        {
            SwitchBrush();
            RectangleF firstRectangle = new RectangleF(GetLeftFloat(g), GetTopFloat(g, 5), GetLightRadius(g), GetLightRadius(g));
            g.FillEllipse(firstBrush, firstRectangle);
        }

        private void DrawSecond(Graphics g)
        {
            SwitchBrush();
            RectangleF secondRectangle = new RectangleF(GetLeftFloat(g), GetTopFloat(g, 4), GetLightRadius(g), GetLightRadius(g));
            g.FillEllipse(secondBrush, secondRectangle);
        }

        private void DrawThird(Graphics g)
        {
            SwitchBrush();
            RectangleF thirdRectangle = new RectangleF(GetLeftFloat(g), GetTopFloat(g, 3), GetLightRadius(g), GetLightRadius(g));
            g.FillEllipse(thirdBrush, thirdRectangle);
        }

        private void DrawFourth(Graphics g)
        {
            SwitchBrush();
            RectangleF fourthRectangle = new RectangleF(GetLeftFloat(g), GetTopFloat(g, 2), GetLightRadius(g), GetLightRadius(g));
            g.FillEllipse(fourthBrush, fourthRectangle);
        }

        private void DrawFifth(Graphics g)
        {
            SwitchBrush();
            RectangleF fifthRectangle = new RectangleF(GetLeftFloat(g), GetTopFloat(g, 1), GetLightRadius(g), GetLightRadius(g));
            g.FillEllipse(fifthBrush, fifthRectangle);
        }

        private void DrawSixth(Graphics g)
        {
            SwitchBrush();
            RectangleF sixthRectangle = new RectangleF(GetLeftFloat(g), GetTopFloat(g, 0), GetLightRadius(g), GetLightRadius(g));
            g.FillEllipse(sixthBrush, sixthRectangle);
        }

        private float GetBoxHeight(Graphics g)
        {
            return g.VisibleClipBounds.Height / 6f;
        }

        private float GetLightRadius(Graphics g)
        {
            return GetBoxHeight(g) * (1 - 2 * LIGHT_BORDER_PERCENTAGE);
        }

        private void SwitchBrush()
        {
            Brush brush = new SolidBrush(Color.White);

            switch (Form1.ColorOfPlayer)
            {
                case Form1.EColor.White:
                    brush = new SolidBrush(Color.White);
                    break;

                case Form1.EColor.Red:
                    brush = new SolidBrush(Color.Red);
                    break;

                case Form1.EColor.Blue:
                    brush = new SolidBrush(Color.Blue);
                    break;
            }

            switch (StateOfRow)
            {
                case EState.First:
                    firstBrush = brush;
                    break;

                case EState.Second:
                    secondBrush = brush;
                    break;

                case EState.Third:
                    thirdBrush = brush;
                    break;

                case EState.Fourth:
                    fourthBrush = brush;
                    break;

                case EState.Fifth:
                    fifthBrush = brush;
                    break;

                case EState.Sixth:
                    sixthBrush = brush;
                    break;
            }
        }

        private int AddColorOfToken()
        {
            if (Form1.ColorOfPlayer == Form1.EColor.Blue)
            {
                return 2;
            }
            return 1;
        }

        private void Column_MouseClick(object sender, MouseEventArgs e)
        {
            switch (numberOfTokens)
            {
                case 0:
                    StateOfRow = EState.First;
                    tokens[0] = AddColorOfToken();
                    numberOfTokens++;
                    break;

                case 1:
                    StateOfRow = EState.Second;
                    tokens[1] = AddColorOfToken();
                    numberOfTokens++;
                    break;

                case 2:
                    StateOfRow = EState.Third;
                    tokens[2] = AddColorOfToken();
                    numberOfTokens++;
                    break;

                case 3:
                    StateOfRow = EState.Fourth;
                    tokens[3] = AddColorOfToken();
                    numberOfTokens++;
                    break;

                case 4:
                    StateOfRow = EState.Fifth;
                    tokens[4] = AddColorOfToken();
                    numberOfTokens++;
                    break;

                case 5:
                    StateOfRow = EState.Sixth;
                    tokens[5] = AddColorOfToken();
                    numberOfTokens++;
                    break;

                case 6:
                    StateOfRow = EState.Final;
                    break;

                default:
                    StateOfRow = EState.Final;
                    break;
            }
            Invalidate();
        }

        private void Column_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawBackground(g);
            DrawFirst(g);
            DrawSecond(g);
            DrawThird(g);
            DrawFourth(g);
            DrawFifth(g);
            DrawSixth(g);
        }
    }
}
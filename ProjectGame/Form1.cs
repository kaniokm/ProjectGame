using System;
using System.Windows.Forms;

namespace ProjectGame
{
    public partial class Form1 : Form
    {
        #region Fields

        private readonly Column[] columns = new Column[7];

        public static EColor ColorOfPlayer = EColor.White;

        #endregion Fields

        public enum EColor
        {
            White,
            Red,
            Blue
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void RestartGame()
        {
            label1.Text = "Červený je na tahu.";
            label1.ForeColor = System.Drawing.Color.Red;
            SetColumns();
            ResetTokens();
            ColorOfPlayer = EColor.Blue;
            foreach (Column column in columns)
            {
                column.ResetColumn();
            }
        }

        private void ResetTokens()
        {
            for (int i = 0; i < 7; i++)
            {

                for (int j = 0; j < 6; j++)
                {
                    columns[i].tokens[j] = 0;
                }
                
            }
        }

        private void SetColumns()
        {
            columns[0] = this.column1;
            columns[1] = this.column2;
            columns[2] = this.column3;
            columns[3] = this.column4;
            columns[4] = this.column5;
            columns[5] = this.column6;
            columns[6] = this.column7;
        }

        private void Column_MouseClick(object sender, MouseEventArgs e)
        {
            Column clmn = (Column)sender;
            if (clmn.StateOfRow != Column.EState.Final)
            {
                if (ColorOfPlayer == EColor.Red)
                {
                    label1.Text = "Červený je na tahu.";
                    label1.ForeColor = System.Drawing.Color.Red;
                    ColorOfPlayer = EColor.Blue;
                }
                else
                if (ColorOfPlayer == EColor.Blue)

                {
                    label1.Text = "Modrý je na tahu.";
                    label1.ForeColor = System.Drawing.Color.Blue;
                    ColorOfPlayer = EColor.Red;
                }
            }
            CheckForResult();
        }

        private bool CheckRows()
        {
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 7 - 3; col++)
                {
                    int element = columns[col].tokens[row];
                    if (element != 0)
                        if (element == columns[col + 1].tokens[row] &&
                            element == columns[col + 2].tokens[row] &&
                            element == columns[col + 3].tokens[row])
                        {
                            return true;
                        }
                }
            }
            return false;
        }

        private bool CheckColumns()
        {
            for (int row = 0; row < 6 - 3; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    int element = columns[col].tokens[row];
                    if (element != 0)
                        if (element == columns[col].tokens[row + 1] &&
                            element == columns[col].tokens[row + 2] &&
                            element == columns[col].tokens[row + 3])
                        {
                            return true;
                        }
                }
            }
            return false;
        }

        private bool CheckMainDiagonal()
        {
            for (int row = 0; row < 6 - 3; row++)
            {
                for (int col = 0; col < 7 - 3; col++)
                {
                    int element = columns[col].tokens[row];
                    if (element != 0)
                        if (element == columns[col + 1].tokens[row + 1] &&
                            element == columns[col + 2].tokens[row + 2] &&
                            element == columns[col + 3].tokens[row + 3])
                        {
                            return true;
                        }
                }
            }
            return false;
        }

        private bool CheckCounterDiagonal()
        {
            for (int row = 0; row < 6 - 3; row++)
            {
                for (int col = 3; col < 7; col++)
                {
                    int element = columns[col].tokens[row];
                    if (element != 0)
                        if (element == columns[col - 1].tokens[row + 1] &&
                            element == columns[col - 2].tokens[row + 2] &&
                            element == columns[col - 3].tokens[row + 3])
                        {
                            return true;
                        }
                }
            }
            return false;
        }

        private bool CheckForDraw()
        {
            if ((columns[0].tokens[5] != 0) && (columns[1].tokens[5] != 0) && (columns[2].tokens[5] != 0) && (columns[3].tokens[5] != 0) && (columns[4].tokens[5] != 0) && (columns[5].tokens[5] != 0) && (columns[6].tokens[5] != 0))
            { return true; }
            return false;
        }

        private void CheckForResult()
        {
            if (CheckRows() || CheckColumns() || CheckMainDiagonal() || CheckCounterDiagonal())
            {
                if (ColorOfPlayer == EColor.Blue)
                {
                    ResultOfGame("Modrý vyhrál.");
                }
                else
                if (ColorOfPlayer == EColor.Red)
                {
                    ResultOfGame("Červený vyhrál.");
                }
            }
            if (CheckForDraw())
            {
                ResultOfGame("Remíza.");
            }
        }

        private DialogResult ResultOfGame(String messege)
        {
            DialogResult result = MessageBox.Show(messege + " Chcete hrát další hru?", "Konec hry", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                RestartGame();
            }
            else
                Close();

            return result;
        }
    }
}
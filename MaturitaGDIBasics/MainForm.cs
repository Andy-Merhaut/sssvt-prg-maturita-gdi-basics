using System.Drawing;
using System.Windows.Forms;

namespace MaturitaGDIBasics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            /*pocatek, odkud mi zacina vykreslovani LAJNY*/
            /*definice    =    souradnice(X, Y)*/
            Point pocatek = new Point(100, 50);
            Point konec = new Point(200, 50);

            Pen blackPen = new Pen(Color.Black);
            Font font = new Font("Arial", 20);
            SolidBrush brush = new SolidBrush(Color.DeepPink);

            e.Graphics.DrawLine(blackPen, pocatek, konec);

            e.Graphics.DrawRectangle(blackPen, pocatek.X + 20, pocatek.Y + 20, 75, 50);

            e.Graphics.DrawString("TEXT", font, brush, pocatek.X + 20 + 5, pocatek.Y + 20 + 5);
        }
    }
}

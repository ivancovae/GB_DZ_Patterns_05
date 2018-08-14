using System.Windows.Forms;
using System.Drawing;

namespace Patterns_05
{
    class Program
    {
        static Graphics graphics;
        static void Main(string[] args)
        {
            Main mainForm = new Main();
            mainForm.MouseClick += MainForm_MouseClick;
            graphics = mainForm.CreateGraphics();
            mainForm.ShowDialog();
        }

        private static void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                RectangleFactory.GetRectangle("Red").DrawRectangle(graphics, e.Location, new Size(20, 20));
            else if (e.Button == MouseButtons.Right)
                CicleFactory.GetCicle("Blue").DrawCicle(graphics, e.Location, new Size(20, 20));
        }
    }
}

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Patterns_05
{
    class Program
    {
        private static Graphics graphics;
        static void Main(string[] args)
        {
            AbstractMath math = new ProxyMath();

            try
            {
                var result = math.Addition(2, 3);
                result = math.Division(5, 3);
                result = math.Subtraction(3, 3);
                result = math.Multiplication(3, 2);
                result = math.Min(3, 5);
            }
            catch (NotImplementedException e)
            {
                MessageBox.Show($"Вы используете упрощенную версию Math, метод {e.Message} использовать недопускается");
            }

            Main mainForm = new Main();
            mainForm.MouseClick += MainForm_MouseClick;
            graphics = mainForm.CreateGraphics();
            mainForm.ShowDialog();
        }

        private static void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ObjectFactory.GetObject("Rectangle").Draw(graphics, e.Location, new Size(20, 20));
            else if (e.Button == MouseButtons.Right)
                ObjectFactory.GetObject("Cicle").Draw(graphics, e.Location, new Size(20, 20));
        }
    }
}

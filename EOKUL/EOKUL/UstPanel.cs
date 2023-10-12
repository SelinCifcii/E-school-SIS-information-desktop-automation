using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOKUL
{
    public static class FormHelper
    {
        private static int Move;
        private static int Mouse_X;
        private static int Mouse_Y;

        public static void InitializeForm(Form form, Panel dragPanel, PictureBox maximizeButton)
        {
            dragPanel.MouseDown += (sender, e) =>
            {
                Move = 1;
                Mouse_X = e.X;
                Mouse_Y = e.Y;
            };

            dragPanel.MouseMove += (sender, e) =>
            {
                if (Move == 1 && e.Button == MouseButtons.Left)
                {
                    Point screenCoordinates = form.PointToScreen(e.Location);
                    form.SetDesktopLocation(screenCoordinates.X - Mouse_X, screenCoordinates.Y - Mouse_Y);
                }
            };

            dragPanel.MouseUp += (sender, e) =>
            {
                Move = 0;
            };

            maximizeButton.Click += (sender, e) =>
            {
                form.WindowState = form.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            };
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Proje_1
{

    public static class FormSize
    {
        private static Dictionary<Control, Rectangle> originalControlRectangles;
        private static Rectangle originalFormSize;

        public static void Initialize(Form form)
        {
            originalFormSize = new Rectangle(form.Location.X, form.Location.Y, form.Size.Width, form.Size.Height);
            originalControlRectangles = GetControlRectangles(form);

            form.Load += Form_Load;
            form.Resize += Form_Resize;
        }

        private static void Form_Load(object sender, EventArgs e)
        {
            Form form = (Form)sender;
            originalControlRectangles = GetControlRectangles(form);
        }

        private static Dictionary<Control, Rectangle> GetControlRectangles(Form form)
        {
            Dictionary<Control, Rectangle> controlRectangles = new Dictionary<Control, Rectangle>();

            foreach (Control control in GetAllControls(form))
            {
                controlRectangles[control] = new Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height);
            }

            return controlRectangles;
        }

        private static IEnumerable<Control> GetAllControls(Control control)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControls(ctrl)).Concat(controls);
        }

        private static void ResizeControl(Rectangle originalRectangle, Control control, Form form)
        {
            float xRatio = (float)(form.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(form.Height) / (float)(originalFormSize.Height);

            int newX = (int)(originalRectangle.X * xRatio);
            int newY = (int)(originalRectangle.Y * yRatio);

            int newWidth = (int)(originalRectangle.Width * xRatio);
            int newHeight = (int)(originalRectangle.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private static void Form_Resize(object sender, EventArgs e)
        {
            Form form = (Form)sender;

            foreach (var kvp in originalControlRectangles)
            {
                ResizeControl(kvp.Value, kvp.Key, form);
            }
        }
    }

}


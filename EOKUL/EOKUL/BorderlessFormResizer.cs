using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOKUL
{
    public class BorderlessFormResizer
    {
        private const int WM_NCHITTEST = 0x0084;
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;
        private const int WM_NCLBUTTONDOWN = 161;

        private Form form;
        private int borderWidth;

        public BorderlessFormResizer(Form form, int borderWidth)
        {
            this.form = form;
            this.borderWidth = borderWidth;

            Initialize();
        }

        private void Initialize()
        {
            // Formun kenarlığını kaldır
            form.FormBorderStyle = FormBorderStyle.None;

            // Fare olaylarını ele al
            form.MouseDown += Form_MouseDown;
            form.MouseMove += Form_MouseMove;

            // WM_NCHITTEST mesajını ele al
            NativeMethods.SetWindowLong(form.Handle, NativeMethods.GWL_WNDPROC, NativeMethods.GetWndProcDelegate(HandleWndProc));
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Kenar çizgisi üzerinde olup olmadığını kontrol et
                int cursorX = e.X;
                int cursorY = e.Y;

                if (cursorX < borderWidth && cursorY < borderWidth)
                {
                    ResizeForm(HTTOPLEFT);
                }
                else if (cursorX > form.ClientSize.Width - borderWidth && cursorY < borderWidth)
                {
                    ResizeForm(HTTOPRIGHT);
                }
                else if (cursorX < borderWidth && cursorY > form.ClientSize.Height - borderWidth)
                {
                    ResizeForm(HTBOTTOMLEFT);
                }
                else if (cursorX > form.ClientSize.Width - borderWidth && cursorY > form.ClientSize.Height - borderWidth)
                {
                    ResizeForm(HTBOTTOMRIGHT);
                }
                else if (cursorX < borderWidth)
                {
                    ResizeForm(HTLEFT);
                }
                else if (cursorX > form.ClientSize.Width - borderWidth)
                {
                    ResizeForm(HTRIGHT);
                }
                else if (cursorY < borderWidth)
                {
                    ResizeForm(HTTOP);
                }
                else if (cursorY > form.ClientSize.Height - borderWidth)
                {
                    ResizeForm(HTBOTTOM);
                }
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.None)
            {
                int cursorX = e.X;
                int cursorY = e.Y;

                if (cursorX < borderWidth && cursorY < borderWidth)
                {
                    form.Cursor = Cursors.SizeNWSE;
                }
                else if (cursorX < borderWidth && cursorY > form.Height - borderWidth)
                {
                    form.Cursor = Cursors.SizeNESW;
                }
                else if (cursorX > form.Width - borderWidth && cursorY < borderWidth)
                {
                    form.Cursor = Cursors.SizeNESW;
                }
                else if (cursorX > form.Width - borderWidth && cursorY > form.Height - borderWidth)
                {
                    form.Cursor = Cursors.SizeNWSE;
                }
                else if (cursorX < borderWidth)
                {
                    form.Cursor = Cursors.SizeWE;
                }
                else if (cursorX > form.Width - borderWidth)
                {
                    form.Cursor = Cursors.SizeWE;
                }
                else if (cursorY < borderWidth)
                {
                    form.Cursor = Cursors.SizeNS;
                }
                else if (cursorY > form.Height - borderWidth)
                {
                    form.Cursor = Cursors.SizeNS;
                }
                else
                {
                    form.Cursor = Cursors.Default;
                }
            }
        }

        private void ResizeForm(int direction)
        {
            NativeMethods.ReleaseCapture();
            NativeMethods.SendMessage(form.Handle, NativeMethods.WM_NCHITTEST, (IntPtr)direction, IntPtr.Zero);
            //WM_NCLBUTTONDOWN
        }

        private IntPtr HandleWndProc(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam)
        {
            if (msg == WM_NCHITTEST)
            {
                Point point = form.PointToClient(new Point((int)lParam));
                if (point.X < borderWidth && point.Y < borderWidth)
                    return (IntPtr)HTTOPLEFT;
                if (point.X > form.ClientSize.Width - borderWidth && point.Y < borderWidth)
                    return (IntPtr)HTTOPRIGHT;
                if (point.X < borderWidth && point.Y > form.ClientSize.Height - borderWidth)
                    return (IntPtr)HTBOTTOMLEFT;
                if (point.X > form.ClientSize.Width - borderWidth && point.Y > form.ClientSize.Height - borderWidth)
                    return (IntPtr)HTBOTTOMRIGHT;
                if (point.X < borderWidth)
                    return (IntPtr)HTLEFT;
                if (point.X > form.ClientSize.Width - borderWidth)
                    return (IntPtr)HTRIGHT;
                if (point.Y < borderWidth)
                    return (IntPtr)HTTOP;
                if (point.Y > form.ClientSize.Height - borderWidth)
                    return (IntPtr)HTBOTTOM;
            }
            return NativeMethods.CallWindowProc(NativeMethods.GetWindowLong(form.Handle, NativeMethods.GWL_WNDPROC), hWnd, msg, wParam, lParam);
        }
    }

    internal static class NativeMethods
    {
        public const int GWL_WNDPROC = -4;
        public const int WM_NCHITTEST = 0x0084;
        public const int HT_CAPTION = 0x2;
        public const int HTLEFT = 10;
        public const int HTRIGHT = 11;
        public const int HTTOP = 12;
        public const int HTTOPLEFT = 13;
        public const int HTTOPRIGHT = 14;
        public const int HTBOTTOM = 15;
        public const int HTBOTTOMLEFT = 16;
        public const int HTBOTTOMRIGHT = 17;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowLong(IntPtr hWnd, int nIndex, Delegate newWndProc);

        [DllImport("user32.dll")]
        public static extern IntPtr CallWindowProc(IntPtr lpPrevWndFunc, IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public static WndProcDelegate GetWndProcDelegate(WndProcDelegate wndProc) => new WndProcDelegate(wndProc);

        public delegate IntPtr WndProcDelegate(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace NPForm.CoreLib
{
    /// <summary>
    /// Describe: WIN32 Core API
    /// Author  : Ziegler Penn
    /// Date    : 2014-6-27
    /// E-mail  : hacker_i@foxmail.com
    /// </summary>
    public class WIN32API
    {
        public const uint WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int WM_MOVE = 0x0003;
        public const int HTCAPTION = 0x0002;
        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int WM_LBUTTONUP = 0x0202;
        public const int WM_NCHITTEST = 0x0084;
        public const int HTLEFT = 10;
        public const int HTRIGHT = 11;
        public const int HTTOP = 12;
        public const int HTTOPLEFT = 13;
        public const int HTTOPRIGHT = 14;
        public const int HTBOTTOM = 15;
        public const int HTBOTTOMLEFT = 0x10;
        public const int HTBOTTOMRIGHT = 17;
        public const int CS_DropSHADOW = 0x20000;       //窗体阴影
        public const int GCL_STYLE = (-26);             //窗体阴影       
        public const int AW_HOR_POSITIVE = 0x00000001;
        public const int AW_HOR_NEGATIVE = 0x00000002;
        public const int AW_VER_POSITIVE = 0x00000004;
        public const int AW_VER_NEGATIVE = 0x00000008;
        public const int AW_CENTER = 0x00000010;
        public const int AW_HIDE = 0x00010000;
        public const int AW_ACTIVATE = 0x00020000;
        public const int AW_SLIDE = 0x00040000;
        public const int AW_BLEND = 0x00080000;

        [DllImport("User32.DLL")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("User32.DLL")]
        public static extern bool ReleaseCapture();

        [DllImport("gdi32.dll")]
        public static extern int CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("user32.dll")]
        public static extern int SetWindowRgn(IntPtr hwnd, int hRgn, Boolean bRedraw);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        /* AnimateWindow(this.Handle, 500, AW_CENTER | AW_HIDE); */
        [DllImport("user32")]
        public static extern bool AnimateWindow(IntPtr whnd, int dwtime, int dwflag);
    }
}

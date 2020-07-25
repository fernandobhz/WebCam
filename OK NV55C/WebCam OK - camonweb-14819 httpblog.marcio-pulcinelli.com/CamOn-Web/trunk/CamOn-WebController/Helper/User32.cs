using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace CamOnWebController.Helper
{
    public enum ShowWindowCommands : int
    {
        Hide = 0,
        Normal = 1,
        ShowMinimized = 2,
        Maximize = 3,
        ShowMaximized = 3,
        ShowNoActivate = 4,
        Show = 5,
        Minimize = 6,
        ShowMinNoActive = 7,
        ShowNA = 8,
        Restore = 9,
        ShowDefault = 10,
        ForceMinimize = 11
    }

    public class User32
    {

        public const int CB_GETCOUNT = 0x0146;
        public const int CB_GETLBTEXT = 0x0148;
        public const int CB_SETCURSEL = 0x014E;

        public const int WM_USER = 1024;
        
        public const int WM_LBUTTONDOWN = 0x0201;
        public const int WM_LBUTTONUP = 0x0202;

        public const int WM_CAP_CONNECT = 1034;
        public const int WM_CAP_DISCONNECT = 1035;
        public const int WM_CAP_GET_FRAME = 1084;
        public const int WM_CAP_COPY = 1054;
        public const int WM_CAP_START = WM_USER;
        public const int WM_CAP_STOP = WM_CAP_START + 68;

        public const int WM_CAP_DLG_VIDEOFORMAT = WM_CAP_START + 41;
        public const int WM_CAP_DLG_VIDEOSOURCE = WM_CAP_START + 42;
        public const int WM_CAP_DLG_VIDEODISPLAY = WM_CAP_START + 43;
        public const int WM_CAP_GET_VIDEOFORMAT = WM_CAP_START + 44;
        public const int WM_CAP_SET_VIDEOFORMAT = WM_CAP_START + 45;
        public const int WM_CAP_DLG_VIDEOCOMPRESSION = WM_CAP_START + 46;
        public const int WM_CAP_SET_PREVIEW = WM_CAP_START + 50;
        public const int WM_CAP_SET_PREVIEWRATE = WM_CAP_START + 52;
        public const int WM_CAP_SET_SCALE = WM_CAP_START + 53;
        public const int WM_CAP_SEQUENCE = WM_CAP_START + 62;
        public const int WM_CAP_FILE_SAVEAS = WM_CAP_START + 23;
        public const int WM_CAP_SET_SEQUENCE_SETUP = WM_CAP_START + 64;
        public const int WM_CAP_FILE_SET_CAPTURE_FILEA = WM_CAP_START + 20;

        //Esta chamada é uma das mais importantes e é vital para o funcionamento do SO.
        [DllImport("user32.dll", EntryPoint = "SendMessage", SetLastError = true)]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, 
                                                 IntPtr hwndChildAfter, 
                                                 string lpszClass, 
                                                 string lpszWindow);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, 
                                                 IntPtr childAfter, 
                                                 string className, 
                                                 IntPtr windowTitle);

        [DllImport("avicap32.dll", 
                    EntryPoint = "capCreateCaptureWindowA", 
                    SetLastError = true)]
        public static extern int capCreateCaptureWindowA(string lpszWindowName, 
                                                         int dwStyle, 
                                                         int X, 
                                                         int Y, 
                                                         int nWidth, 
                                                         int nHeight, 
                                                         int hwndParent, 
                                                         int nID);

        [DllImport("avicap32.dll", 
                    EntryPoint = "capDriverConnect", 
                    SetLastError = true)]
        public static extern int capDriverConnect(IntPtr hWnd, int drv);

                [DllImport("avicap32.dll", 
                    EntryPoint = "capDriverConnect", 
                    SetLastError = true)]
        public static extern int capCaptureSequence(IntPtr hWnd);


        [DllImport("avicap32.dll")]
        public static extern bool capGetDriverDescriptionA(short wDriverIndex,
            [MarshalAs(UnmanagedType.VBByRefStr)]ref String lpszName,
           int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref String lpszVer, int cbVer);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(IntPtr hWnd, ShowWindowCommands nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyWindow(IntPtr hwnd);

        [DllImport("user32.dll", 
                   CharSet = CharSet.Auto, 
                   SetLastError = false, EntryPoint = "SendMessage")]
        public static extern IntPtr SendRefMessage(IntPtr hWnd, 
                                                   int Msg, 
                                                   int wParam, 
                                                   StringBuilder lParam);

        [DllImport("user32.dll",
                   CharSet = CharSet.Auto,
                   SetLastError = false, EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessage(IntPtr hWnd,
                                                   int Msg,
                                                   int wParam,
                                                   string lParam);
        [DllImport("user32.dll",
             CharSet = CharSet.Auto,
             SetLastError = false, EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessage(IntPtr hWnd,
                                                   int Msg,
                                                   int wParam,
                                                   object lParam);

        [DllImport("user32.dll",
               CharSet = CharSet.Auto,
               SetLastError = false, EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessage(IntPtr hWnd,
                                                   int Msg,
                                                   string wParam,
                                                   int lParam);
    }
}

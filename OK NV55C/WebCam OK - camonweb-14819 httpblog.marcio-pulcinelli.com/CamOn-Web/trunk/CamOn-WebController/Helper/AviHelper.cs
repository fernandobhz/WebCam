using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace CamOnWebController.Helper
{
    /// <summary>
    /// Class with constants for each type of CODEC.
    /// </summary>
    public class FOURCC
    {
        public static readonly int DIVX = FOURCC.mmioFOURCC('d', 'i', 'v', 'x');
        public static readonly int MP42 = FOURCC.mmioFOURCC('M', 'P', '4', '2');
        public static readonly int streamtypeVIDEO = mmioFOURCC('v', 'i', 'd', 's');
        public static readonly int streamtypeAUDIO = mmioFOURCC('a', 'u', 'd', 's');
        public static readonly int streamtypeMIDI = mmioFOURCC('m', 'i', 'd', 's');
        public static readonly int streamtypeTEXT = mmioFOURCC('t', 'x', 't', 's');
        public static readonly int ICTYPE_VIDEO = mmioFOURCC('v', 'i', 'd', 'c');
        public static readonly int ICTYPE_AUDIO = mmioFOURCC('a', 'u', 'd', 'c');
        public static readonly int ICM_FRAMERATE = mmioFOURCC('F', 'r', 'm', 'R');
        public static readonly int ICM_KEYFRAMERATE = mmioFOURCC('K', 'e', 'y', 'R');

        public static int mmioFOURCC(char ch0, char ch1, char ch2, char ch3)
        {
            return ((int)(byte)(ch0) | ((byte)(ch1) << 8) | ((byte)(ch2) << 16) | ((byte)(ch3) << 24));
        }
    }

    /// <summary>
    /// Helper class for creating AVI files.
    /// </summary>
    public class AviHelper
    {
        [DllImport("avifil32.dll")]
        private static extern void AVIFileInit();

        [DllImport("avifil32.dll")]
        private static extern int AVIFileOpenW(ref int ptr_pfile,
                                               [MarshalAs(UnmanagedType.LPWStr)]string fileName,
                                               int flags,
                                               int dummy);

        [DllImport("avifil32.dll")]
        private static extern int AVIFileCreateStream(int ptr_pfile,
                                                      out IntPtr ptr_ptr_avi,
                                                      ref AVISTREAMINFOW ptr_streaminfo);

        [DllImport("avifil32.dll")]
        private static extern int AVIMakeCompressedStream(out IntPtr ppsCompressed,
                                                          IntPtr aviStream,
                                                          ref AVICOMPRESSOPTIONS ao,
                                                          int dummy);

        [DllImport("avifil32.dll")]
        private static extern int AVIStreamSetFormat(IntPtr aviStream,
                                                     int lPos,
                                                     ref BITMAPINFOHEADER lpFormat,
                                                     int cbFormat);

        [DllImport("avifil32.dll")]
        unsafe private static extern int AVISaveOptions(int hwnd,
                                                        uint flags,
                                                        int nStreams,
                                                        IntPtr* ptr_ptr_avi,
                                                        AVICOMPRESSOPTIONS** ao);

        [DllImport("avifil32.dll")]
        private static extern int AVIStreamWrite(IntPtr aviStream,
                                                 int lStart,
                                                 int lSamples,
                                                 IntPtr lpBuffer,
                                                 int cbBuffer,
                                                 int dwFlags,
                                                 int dummy1,
                                                 int dummy2);

        [DllImport("avifil32.dll")]
        private static extern int AVIStreamRelease(IntPtr aviStream);

        [DllImport("avifil32.dll")]
        private static extern int AVIFileRelease(int pfile);

        [DllImport("avifil32.dll")]
        private static extern void AVIFileExit();

        private IntPtr m_ps = new IntPtr(0);
        private IntPtr m_psCompressed = new IntPtr(0);

        private int m_pfile = 0;
        private int m_count = 0;

        private uint m_frameRate = 0;
        private uint m_width = 0;
        private uint m_stride = 0;
        private uint m_height = 0;
        private uint m_fccType = 1935960438;
        private uint m_fccHandler = (uint)FOURCC.streamtypeVIDEO;
        private Bitmap m_bmp;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private struct AVISTREAMINFOW
        {
            public uint fccType;
            public uint fccHandler;
            public uint dwFlags;
            public uint dwCaps;

            public ushort wPriority;
            public ushort wLanguage;

            public uint dwScale;
            public uint dwRate;
            public uint dwStart;
            public uint dwLength;
            public uint dwInitialFrames;
            public uint dwSuggestedBufferSize;
            public uint dwQuality;
            public uint dwSampleSize;
            public uint rect_left;
            public uint rect_top;
            public uint rect_right;
            public uint rect_bottom;
            public uint dwEditCount;
            public uint dwFormatChangeCount;

            public ushort szName0;
            public ushort szName1;
            public ushort szName2;
            public ushort szName3;
            public ushort szName4;
            public ushort szName5;
            public ushort szName6;
            public ushort szName7;
            public ushort szName8;
            public ushort szName9;
            public ushort szName10;
            public ushort szName11;
            public ushort szName12;
            public ushort szName13;
            public ushort szName14;
            public ushort szName15;
            public ushort szName16;
            public ushort szName17;
            public ushort szName18;
            public ushort szName19;
            public ushort szName20;
            public ushort szName21;
            public ushort szName22;
            public ushort szName23;
            public ushort szName24;
            public ushort szName25;
            public ushort szName26;
            public ushort szName27;
            public ushort szName28;
            public ushort szName29;
            public ushort szName30;
            public ushort szName31;
            public ushort szName32;
            public ushort szName33;
            public ushort szName34;
            public ushort szName35;
            public ushort szName36;
            public ushort szName37;
            public ushort szName38;
            public ushort szName39;
            public ushort szName40;
            public ushort szName41;
            public ushort szName42;
            public ushort szName43;
            public ushort szName44;
            public ushort szName45;
            public ushort szName46;
            public ushort szName47;
            public ushort szName48;
            public ushort szName49;
            public ushort szName50;
            public ushort szName51;
            public ushort szName52;
            public ushort szName53;
            public ushort szName54;
            public ushort szName55;
            public ushort szName56;
            public ushort szName57;
            public ushort szName58;
            public ushort szName59;
            public ushort szName60;
            public ushort szName61;
            public ushort szName62;
            public ushort szName63;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private struct AVICOMPRESSOPTIONS
        {
            public uint fccType;
            public uint fccHandler;
            public uint dwKeyFrameEvery;
            public uint dwQuality;
            public uint dwBytesPerSecond;
            public uint dwFlags;
            public IntPtr lpFormat;
            public uint cbFormat;
            public IntPtr lpParms;
            public uint cbParms;
            public uint dwInterleaveEvery;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BITMAPINFOHEADER
        {
            public uint biSize;
            public int biWidth;
            public int biHeight;
            public short biPlanes;
            public short biBitCount;
            public uint biCompression;
            public uint biSizeImage;
            public int biXPelsPerMeter;
            public int biYPelsPerMeter;
            public uint biClrUsed;
            public uint biClrImportant;
        }

        public class AviException : ApplicationException
        {
            private const int AVIERR_BADPARAM = -2147205018;
            private string err_msg;

            public AviException(string s) : base(s) { }
            public AviException(string s, int hr) : base(s)
            {

                if (hr == AVIERR_BADPARAM)
                {
                    err_msg = "AVIERR_BADPARAM";
                }
                else
                {
                    err_msg = "unknown";
                }
            }

            public string ErrMsg()
            {
                return err_msg;
            }
        }

        /// <summary>
        /// Method for generating AVI file.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="frameRate"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public Bitmap Open(string fileName, uint frameRate, int width, int height)
        {
            m_frameRate = frameRate;
            m_width = (uint)width;
            m_height = (uint)height;
            m_bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            BitmapData bmpDat = m_bmp.LockBits(new Rectangle(0, 0, width, height), 
                                               ImageLockMode.ReadOnly, 
                                               PixelFormat.Format24bppRgb);

            m_stride = (uint)bmpDat.Stride;
            m_bmp.UnlockBits(bmpDat);
            AVIFileInit();

            int hr = AVIFileOpenW(ref m_pfile, 
                                  fileName, 
                                  4097 /* OF_WRITE | OF_CREATE (winbase.h) */, 
                                  0);

            if (hr != 0)
            {
                throw new AviException("Error creating the file.");
            }

            CreateStream();
            SetOptions();

            return m_bmp;
        }

        /// <summary>
        /// Method to add frames in the video file.
        /// </summary>
        public void AddFrame()
        {
            BitmapData bmpDat = m_bmp.LockBits(new Rectangle(0, 0, (int)m_width, (int)m_height), 
                                               ImageLockMode.ReadOnly, 
                                               PixelFormat.Format24bppRgb);

            int hr = AVIStreamWrite(m_psCompressed, 
                                    m_count, 
                                    1,
                                    bmpDat.Scan0, // Ponteiro para os dados.
                                    (int)(m_stride * m_height),
                                    0, // 16 = AVIIF_KEYFRAMe
                                    0,
                                    0);

            if (hr != 0)
            {
                throw new AviException("Err: AVIStreamWrite");
            }

            m_bmp.UnlockBits(bmpDat);

            m_count++;
        }

        /// <summary>
        /// Method to close (finish) and save the video stream.
        /// </summary>
        public void Close()
        {
            AVIStreamRelease(m_ps);
            AVIStreamRelease(m_psCompressed);

            AVIFileRelease(m_pfile);
            AVIFileExit();
        }

        /// <summary>
        /// Method to create the video stream.
        /// </summary>
        private void CreateStream()
        {
            AVISTREAMINFOW strhdr = new AVISTREAMINFOW();
            strhdr.fccType = m_fccType;
            strhdr.fccHandler = m_fccHandler;
            strhdr.dwFlags = 0;
            strhdr.dwCaps = 0;
            strhdr.wPriority = 0;
            strhdr.wLanguage = 0;
            strhdr.dwScale = 1;
            strhdr.dwRate = m_frameRate; // Frames per Second
            strhdr.dwStart = 0;
            strhdr.dwLength = 0;
            strhdr.dwInitialFrames = 0;
            strhdr.dwSuggestedBufferSize = m_height * m_stride;
            strhdr.dwQuality = 0xffffffff; //-1;         // Use default
            strhdr.dwSampleSize = 0;
            strhdr.rect_top = 0;
            strhdr.rect_left = 0;
            strhdr.rect_bottom = m_height;
            strhdr.rect_right = m_width;
            strhdr.dwEditCount = 0;
            strhdr.dwFormatChangeCount = 0;
            strhdr.szName0 = 0;
            strhdr.szName1 = 0;

            int hr = AVIFileCreateStream(m_pfile, out m_ps, ref strhdr);

            if (hr != 0)
            {
                throw new AviException("Err: AVIFileCreateStream");
            }
        }

        /// <summary>
        /// Method to set the video options.
        /// </summary>
        unsafe private void SetOptions()
        {
            AVICOMPRESSOPTIONS opts = new AVICOMPRESSOPTIONS();
            opts.fccType = 0; 
            opts.fccHandler = 0;
            opts.dwKeyFrameEvery = 0;
            opts.dwQuality = 0; 
            opts.dwFlags = 0;  // AVICOMRPESSF_KEYFRAMES = 4
            opts.dwBytesPerSecond = 0;
            opts.lpFormat = new IntPtr(0);
            opts.cbFormat = 0;
            opts.lpParms = new IntPtr(0);
            opts.cbParms = 0;
            opts.dwInterleaveEvery = 0;

            AVICOMPRESSOPTIONS* p = &opts;
            AVICOMPRESSOPTIONS** pp = &p;

            IntPtr x = m_ps;
            IntPtr* ptr_ps = &x;

            // Need to study the best way for setting the options.
            // AVISaveOptions(0, 0, 1, ptr_ps, pp);

            int hr = AVIMakeCompressedStream(out m_psCompressed, 
                                             m_ps, 
                                             ref opts, 
                                             0);

            if (hr != 0)
            {
                throw new AviException("Err: AVIMakeCompressedStream");
            }

            BITMAPINFOHEADER bi = new BITMAPINFOHEADER();
            bi.biSize = 40;
            bi.biWidth = (int)m_width;
            bi.biHeight = (int)m_height;
            bi.biPlanes = 1;
            bi.biBitCount = 24;
            bi.biCompression = 0;  // 0 = BI_RGB
            bi.biSizeImage = m_stride * m_height;
            bi.biXPelsPerMeter = 0;
            bi.biYPelsPerMeter = 0;
            bi.biClrUsed = 0;
            bi.biClrImportant = 0;

            hr = AVIStreamSetFormat(m_psCompressed, 
                                    0, 
                                    ref bi, 
                                    40);

            if (hr != 0)
            {
                throw new AviException("Err: AVIStreamSetFormat", hr);
            }
        }
    };
}

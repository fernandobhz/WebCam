using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CamOnWebController.Helper
{
    /// <summary>
    /// Helper class for clipboard.
    /// </summary>
    public class ClipboardHelper
    {
        /// <summary>
        /// Retrieve image from the clipboard.
        /// </summary>
        /// <returns>Image from the clipboard.</returns>
        public static System.Drawing.Image GetImage()
        {
            System.Drawing.Image oImage = null;

            try
            {
                IDataObject data = Clipboard.GetDataObject();
                if (data != null)
                {
                    if (data.GetDataPresent(DataFormats.Bitmap))
                    {
                        oImage = (Image)data.GetData(DataFormats.Bitmap, true);
                    }
                }

                return oImage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieve text from the clipboard.
        /// </summary>
        /// <returns>String with text.</returns>
        public static string GetText()
        {
            string strTexto = null;

            try
            {
                IDataObject data = Clipboard.GetDataObject();
                if (data != null)
                {
                    if (data.GetDataPresent(DataFormats.Text))
                    {
                        strTexto = data.GetData(DataFormats.Text, true).ToString();
                    }
                }

                return strTexto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

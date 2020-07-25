using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace CamOnWebController.Helper
{
    /// <summary>
    /// Classe de tratamento de bitmaps.
    /// </summary>
    public class BitmapHelper
    {
        /// <summary>
        ///Método mGerarBitmap -> este overload simplesmente passa o nome do arquivo bitmap como parâmentro
        ///e retorna um objeto do tipo System.Drawing.Bitmap que poderá ser utilizado por qualquer objeto 
        ///que aceite System.Drawing.Image dentro do visual studio.net
        /// </summary>
        /// <param name="bitmapPath"></param>
        /// <returns></returns>
        public System.Drawing.Bitmap Generate(string bitmapPath)
        {
            byte[] ByteArray;
            System.Drawing.Bitmap oBitmap;
            MemoryStream memStream;
            try
            {
                ByteArray = GerarByteArray(bitmapPath);
                memStream = new MemoryStream();
                memStream.Write(ByteArray, 0, ByteArray.Length);
                oBitmap = new System.Drawing.Bitmap(memStream);
                return oBitmap;
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        /// <summary>
        ///Método mGerarBitmap -> este overload simplesmente pega do clipboard o bitmap 
        ///e retorna um objeto do tipo System.Drawing.Bitmap que poderá ser utilizado por qualquer objeto 
        ///que aceite System.Drawing.Image dentro do visual studio.net
        /// </summary>
        /// <param name="BitmapPath"></param>
        /// <returns></returns>
        public System.Drawing.Bitmap GenerateFromClipboard()
        {
            System.Drawing.Bitmap oBitmap;
            try
            {
                oBitmap = (System.Drawing.Bitmap)ClipboardHelper.GetImage();
                
                return oBitmap;
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        /// <summary>
        /// Método para salvar imagem.
        /// </summary>
        /// <param name="img">Objeto de imagem.</param>
        /// <param name="caminho">Caminho para a imagem.</param>
        /// <param name="formato">Formato desejado para a imagem.</param>
        public void SaveImage(Image img, string caminho, ImageFormat formato)
        {
            using (Graphics g = Graphics.FromImage(img))
            {
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            }

            img.Save(caminho, formato);
        }

        /// <summary>
        ///Método mGerarBitmap -> este overload simplesmente passa um array de bytes como parâmentro
        ///e retorna um objeto do tipo System.Drawing.Bitmap que poderá ser utilizado por qualquer objeto 
        ///que aceite System.Drawing.Image dentro do visual studio.net
        /// </summary>
        /// <param name="byteArray"></param>
        /// <returns></returns>
        public System.Drawing.Bitmap GenerateFromByteArray(byte[] byteArray)
        {
            System.Drawing.Bitmap oBitmap;
            MemoryStream memStream;
            try
            {
                memStream = new MemoryStream();
                memStream.Write(byteArray, 0, byteArray.Length);
                oBitmap = new System.Drawing.Bitmap(memStream);
                return oBitmap;
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        /// <summary>
        ///Método mGerarByteArray -> este método simplesmente passa o nome do arquivo bitmap como parâmentro
        ///e retorna um Array de Bytes que poderá ser utilizado por qualquer incluido em um campo imagem
        ///do banco de dados Access.
        /// </summary>
        /// <param name="bitmapPath"></param>
        /// <returns></returns>
        public byte[] GerarByteArray(string bitmapPath)
        {
            try
            {
                FileStream fs = new FileStream(bitmapPath, FileMode.Open);
                byte[] buffer = new byte[Convert.ToInt32(fs.Length)];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();
                return buffer;
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        /// <summary>
        ///Método mGerarByteArray -> este método simplesmente uma imagem como parâmentro
        ///e retorna um Array de Bytes que poderá ser utilizado por qualquer incluido em um campo imagem
        ///do banco de dados Access.
        /// </summary>
        /// <param name="bmpBitmap"></param>
        /// <returns></returns>
        public byte[] GerarByteArray(System.Drawing.Image bmpBitmap)
        {
            System.Drawing.Bitmap BmpImagem;
            MemoryStream MemStream = new MemoryStream();
            byte[] ByteArray;
            try
            {
                if (bmpBitmap == null) return null;

                BmpImagem = (System.Drawing.Bitmap)bmpBitmap;
                BmpImagem.Save(MemStream, ImageFormat.Bmp);
                MemStream.Flush();
                ByteArray = MemStream.ToArray();
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            return ByteArray;
        }
    }
}

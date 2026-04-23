using System;
using System.Drawing;

namespace RestaurantManagement.Utilities
{
    /// <summary>
    /// Ndihmues për gjenerimin e kodit të barres
    /// </summary>
    public static class BarcodeGenerator
    {
        /// <summary>
        /// Gjenerimi i kodit të barres si bitmap
        /// Shënim: Duke përdorur nje thjeshtë implementim teksti për tani
        /// Në praktikë, do të përdorni ZXing.Net ose një bibliotekë të ngjashme
        /// </summary>
        public static Bitmap GenerateBarcode(string data)
        {
            if (string.IsNullOrEmpty(data))
                throw new ArgumentException("Të dhënat nuk mund të jenë bosh");

            // Kjo është këtej implementim - në praktikë, përdorni ZXing.Net
            // ZXing.Net nuget: Install-Package ZXing.Net
            
            Bitmap barcode = new Bitmap(200, 100);
            using (Graphics g = Graphics.FromImage(barcode))
            {
                g.Clear(Color.White);
                g.DrawString(data, new Font("Arial", 10), Brushes.Black, new PointF(10, 40));
            }

            return barcode;
        }

        /// <summary>
        /// Gjenerimi i kodit QR
        /// </summary>
        public static Bitmap GenerateQRCode(string data)
        {
            if (string.IsNullOrEmpty(data))
                throw new ArgumentException("Të dhënat nuk mund të jenë bosh");

            // Kjo në praktikë do të përdorë ZXing.Net ose nje bibliotekë të ngjashme
            Bitmap qrCode = new Bitmap(200, 200);
            using (Graphics g = Graphics.FromImage(qrCode))
            {
                g.Clear(Color.White);
                g.DrawString("QR:" + data.Substring(0, Math.Min(20, data.Length)), 
                    new Font("Arial", 10), Brushes.Black, new PointF(10, 90));
            }

            return qrCode;
        }
    }
}

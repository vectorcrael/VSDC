using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using QRCoder;

namespace VSDCAPIApiClient;

public class QrCodeGenerator
{
    public static byte[] GenerateQrCodeAsBinary(string input)
    {
        using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
        {
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q))
            {
                using (QRCode qrCodeurl = new QRCode(qrCodeData))
                {
                    using (Bitmap qrCodeImage = qrCodeurl.GetGraphic(20))
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            qrCodeImage.Save(memoryStream, ImageFormat.Png);
                            return memoryStream.ToArray();
                        }
                    }
                }
            }
        }
    }
}

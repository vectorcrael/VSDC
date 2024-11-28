using System.Drawing.Imaging;
using QRCoder;

namespace ServicesLayer;

public class QrCodeGenerator
{
    public static byte[] GenerateQrCodeAsBinary(string input)
    {
        using (var qrGenerator = new QRCodeGenerator())
        {
            using (var qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q))
            {
                using (var qrCodeurl = new QRCode(qrCodeData))
                {
                    using (var qrCodeImage = qrCodeurl.GetGraphic(20))
                    {
                        using (var memoryStream = new MemoryStream())
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
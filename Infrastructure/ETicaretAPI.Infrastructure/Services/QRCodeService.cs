using ETicaretAPI.Application.Abstractions.Services;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QRCoder.QRCodeGenerator;

namespace ETicaretAPI.Infrastructure.Services
{
    public class QRCodeService : IQRCodeService
    {

        public byte[] GenerateQRCodeAsync(string text)
        {
            QRCodeGenerator generator = new QRCodeGenerator();
            QRCodeData data = generator.CreateQrCode(text, ECCLevel.Q);
            PngByteQRCode qrCode = new PngByteQRCode(data);
            byte[] byteGraphic = qrCode.GetGraphic(10, new byte[] { 84, 99, 71 }, new byte[] { 240, 240, 240 });
            return byteGraphic;
        }
    }
}

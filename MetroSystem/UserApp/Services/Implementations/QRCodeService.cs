using QRCoder;
using System.Text.Json;
using UsersApp.Models;
using UsersApp.Services.Interfaces;

namespace UsersApp.Services.Implementations
{
    public class QRCodeService : IQRCodeService
    {
        private readonly IUserService _userService;

        public QRCodeService(IUserService userService)
        {
            _userService = userService;
        }

        public byte[] GenerateQRCode(string qrcodeId, DateTime expirationTime)
        {
            string userId = _userService.GetCurrentUserId();
            string phone = _userService.GetCurrentUserPhone();

            if (string.IsNullOrEmpty(userId))
            {
                throw new Exception("User details not found. Please log in.");
            }

            var checkInData = new StationCheckInData
            {
                UserId = userId,
                Phone = phone,
                QrCodeId = qrcodeId,
                GenerationTime = DateTime.UtcNow,
                ExpirationTime = expirationTime
            };

            string qrData = checkInData.ToQRString();
            Console.WriteLine($"Generated QR Data {qrData}");

            using (var qrGenerator = new QRCodeGenerator())
            {
                var qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
                using (var qrCode = new PngByteQRCode (qrCodeData))
                {
                    return qrCode.GetGraphic(20);
                }
            }
        }

        public StationCheckInData DecodeQRCode(string qrData) 
        {
            try
            {
                var data = JsonSerializer.Deserialize<StationCheckInData>(qrData);
                if (data == null || string.IsNullOrEmpty(data.UserId) || string.IsNullOrEmpty(data.QrCodeId))
                {
                    throw new Exception("Invalid QR code data: Missing required fields");
                }

                // Check expiration time
                if (DateTime.UtcNow > data.ExpirationTime)
                {
                    throw new Exception("QR code has expired.");
                }

                return data;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to decode QR data: {ex.Message}");
            }
        }
    }
}

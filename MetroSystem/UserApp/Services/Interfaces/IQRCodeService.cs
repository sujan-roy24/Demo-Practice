using UsersApp.Models;

namespace UsersApp.Services.Interfaces
{
    public interface IQRCodeService
    {
        byte[] GenerateQRCode(string qrcodeId, DateTime expirationTime);
        StationCheckInData DecodeQRCode(string qrData);
    }
}

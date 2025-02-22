using Microsoft.AspNetCore.Mvc;
using UsersApp.Services.Interfaces;

namespace UsersApp.Controllers
{
    public class QRCodeController : Controller
    {
        private readonly IQRCodeService _qrCodeService;
        public QRCodeController(IQRCodeService qrCodeService)
        {
            _qrCodeService = qrCodeService;
        }

        public IActionResult Generate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GenerateQRCode()
        {
            string qrcodeId = Guid.NewGuid().ToString();
            DateTime expirationTime = DateTime.UtcNow.AddMinutes(30);
            try
            {
                if (string.IsNullOrEmpty(qrcodeId))
                {
                    ModelState.AddModelError("", "QR Code ID is required.");
                    return View("Generate");
                }

                byte[] qrCodeImage = _qrCodeService.GenerateQRCode(qrcodeId, expirationTime);
                string qrCodeBase64 = Convert.ToBase64String(qrCodeImage);

                return View("Display", qrCodeBase64);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Error generating QR Code: {ex.Message}");
                return View("Generate");
            }
        }
        public IActionResult Display(string qrCodeBase64)
        {
            return View("Display", qrCodeBase64);
        }

        public IActionResult Scan() => View();

        [HttpPost]
        public async Task<IActionResult> ValidateQRCode([FromBody] string qrData)
        {
            try
            {
                var checkInData = _qrCodeService.DecodeQRCode(qrData);
                return Json(new
                {
                    isValid = true,
                    userId = checkInData.UserId,
                    phone = checkInData.Phone,
                    expirationTime = checkInData.ExpirationTime.ToString("o")
                });
            }
            catch (Exception ex)
            {
                return Json(new { isValid = false, error = ex.Message });
            }
        }
    }
}

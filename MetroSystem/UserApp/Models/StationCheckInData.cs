namespace UsersApp.Models
{
    public class StationCheckInData
    {
        public string UserId { get; set; }
        public string Phone { get; set; }
        public string QrCodeId { get; set; }
        public DateTime GenerationTime { get; set; }
        public DateTime ExpirationTime { get; set; }

        public string ToQRString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }
    }
}

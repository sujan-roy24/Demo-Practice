namespace UsersApp.ViewModels
{
    public class ProfileViewModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public int LoginCount { get; set; }
    }
}

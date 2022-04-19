namespace JWT_roles_lab.Models
{
    public class RefreshRequest
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}

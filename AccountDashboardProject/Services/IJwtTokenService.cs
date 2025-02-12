namespace AccountDashboardProject.Services
{
    public interface IJwtTokenService
    {
        string GenerateToken(string userId, string userEmail, string role);
    }
}

namespace AccountDashboardProject
{
    public interface IJwtTokenService
    {
        string GenerateToken(string userId, string userEmail, string role);
    }
}

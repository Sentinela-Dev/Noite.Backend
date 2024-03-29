namespace Noite.Backend.Adapters.Tokens;

public interface IWebTokenProvider
{
    string GenerateToken(string userId, string username, string role);
    string? ReadIdFromToken(string token);
}

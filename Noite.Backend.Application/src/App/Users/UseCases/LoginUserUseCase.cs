namespace Noite.Backend.Application.App.Users.UseCases;

public class LoginUserUseCase
{
    public record Simple(string email, string password);

    public LoginUserUseCase()
    {

    }

    public async Task Execute(Simple loginDto)
    {

    }
}

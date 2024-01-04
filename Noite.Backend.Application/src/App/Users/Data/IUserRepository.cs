using Noite.Backend.Application.App.Users.Entity;

namespace Noite.Backend.Application.App.Users.Data;

public interface IUserRepository
{
    Task<User> Save(User user);

    Task<User?> FindById(string id);
    Task<User?> FindByEmail(string email);
}


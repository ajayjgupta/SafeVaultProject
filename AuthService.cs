
public class AuthService
{
    public User Authenticate(string username, string password, User storedUser)
    {
        if (storedUser == null) return null;
        return PasswordHasher.VerifyPassword(password, storedUser.PasswordHash) ? storedUser : null;
    }
}

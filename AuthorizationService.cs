
using System;

public static class AuthorizationService
{
    public static void CheckAdminAccess(User user)
    {
        if (user == null || user.Role != Roles.Admin)
        {
            throw new UnauthorizedAccessException();
        }
    }
}

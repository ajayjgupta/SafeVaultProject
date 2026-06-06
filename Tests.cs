
using NUnit.Framework;
using System;

[TestFixture]
public class SecurityTests
{
    [Test]
    public void XSS_Test()
    {
        string input = "<script>alert(1)</script>";
        string result = InputSecurity.Sanitize(input);
        Assert.IsFalse(result.Contains("<script>"));
    }

    [Test]
    public void Username_Validation_Test()
    {
        Assert.IsFalse(InputSecurity.IsValidUsername("admin'; DROP"));
    }

    [Test]
    public void Password_Hash_Test()
    {
        string pass = "secure123";
        string hash = PasswordHasher.HashPassword(pass);
        Assert.IsTrue(PasswordHasher.VerifyPassword(pass, hash));
    }

    [Test]
    public void Authorization_Test()
    {
        var user = new User { Role = Roles.User };
        Assert.Throws<UnauthorizedAccessException>(() => AuthorizationService.CheckAdminAccess(user));
    }
}

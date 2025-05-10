// Services/UserSessionService.cs
public class UserSessionService
{
    public string? CurrentUserEmail { get; private set; }

    public void Login(string email)
    {
        CurrentUserEmail = email;
    }

    public void Logout()
    {
        CurrentUserEmail = null;
    }

    public bool IsLoggedIn => !string.IsNullOrEmpty(CurrentUserEmail);
}

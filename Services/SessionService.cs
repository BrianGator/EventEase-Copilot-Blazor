namespace EventEase_Copilot_Blazor.Services;

public class SessionService
{
    public string CurrentUserName { get; private set; } = string.Empty;

    public string CurrentUserEmail { get; private set; } = string.Empty;

    public bool HasUser => !string.IsNullOrWhiteSpace(CurrentUserName) && !string.IsNullOrWhiteSpace(CurrentUserEmail);

    public void SetUser(string name, string email)
    {
        CurrentUserName = name;
        CurrentUserEmail = email;
    }

    public void ClearUser()
    {
        CurrentUserName = string.Empty;
        CurrentUserEmail = string.Empty;
    }
}

namespace BlazorSample.Components.Pages;

public partial class Login
{
    private string username = string.Empty;
    private string password = string.Empty;

    private void HandleLogin()
    {
        // Implement your login logic here
        Console.WriteLine($"Username: {username}, Password: {password}");
    }
}
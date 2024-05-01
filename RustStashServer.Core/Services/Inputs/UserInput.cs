namespace RustStashServer.Core.Services.Inputs;

public class UserInput
{
    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string UserImage { get; set; }
}
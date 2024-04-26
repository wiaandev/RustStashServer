namespace RustStashServer.Core.Services.Inputs;

public class CreateUserInput
{
    public UserInput? UserInput { get; set; } = null!;

    public string Role { get; set; } = string.Empty;
}
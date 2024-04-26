using System.Collections.Immutable;
using Microsoft.AspNetCore.Identity;

namespace RustStashServer.Core.Entities.Auth;

public class Role : IdentityRole<int>
{
    public const string Admin = "Admin";
    public const string User = "User";

    public static readonly ImmutableList<string> allRoles = new List<string> { Admin, User }.ToImmutableList();
}
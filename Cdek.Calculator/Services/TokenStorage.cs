namespace Cdek.Calculator.Services;

/// <summary>
/// Interface ITokenStorage
/// </summary>
public interface ITokenStorage
{
    /// <summary>
    /// Gets or sets the token.
    /// </summary>
    /// <value>The token.</value>
    public string token { get; set; }
}

/// <summary>
/// Class TokenStorage.
/// </summary>
public class TokenStorage : ITokenStorage
{
    /// <summary>
    /// Gets or sets the token.
    /// </summary>
    /// <value>The token.</value>
    public string token { get; set; }
}
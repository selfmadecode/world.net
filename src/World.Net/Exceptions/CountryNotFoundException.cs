namespace World.Net;

/// <summary>
/// The exception that is thrown when a country is not found in the collection.
/// </summary>
public sealed class CountryNotFoundException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CountryNotFoundException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    public CountryNotFoundException(string message) : base(message)
    {
    }
}

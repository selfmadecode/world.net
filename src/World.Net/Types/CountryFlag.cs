namespace World.Net.Types;

/// <summary>
/// Represents flag information for a country.
/// </summary>
public sealed class CountryFlag
{
    public string ISO2 { get; }
    public string Emoji { get; }
    public string? AssetUrl { get; }

    public CountryFlag(string iso2, string emoji, string? assetUrl = null)
    {
        ISO2 = iso2;
        Emoji = emoji;
        AssetUrl = assetUrl;
    }
}

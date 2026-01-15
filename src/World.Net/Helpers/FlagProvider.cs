using System.Linq;
using World.Net.Types;

namespace World.Net.Helpers;

internal static class FlagProvider
{    
    public static CountryFlag GetFlag(string iso2)
    {
        iso2 = iso2?.ToUpperInvariant() ?? string.Empty;
        string emoji = iso2.Length == 2 ? BuildFlagEmoji(iso2) : string.Empty;
        string assetUrl = $"https://flags.example.com/{iso2}.png";
        return new CountryFlag(iso2, emoji, assetUrl);

        static string BuildFlagEmoji(string code)
        {
            if (code.Length != 2) return string.Empty;
            var chars = code.ToUpperInvariant().ToCharArray();
            return string.Concat(chars.Select(c => char.ConvertFromUtf32(0x1F1E6 + (c - 'A'))));
        }
    }
}

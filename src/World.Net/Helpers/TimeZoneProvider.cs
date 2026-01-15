namespace World.Net.Helpers;

/// <summary>
/// Provides time zone information for countries based on their ISO 3166-1 alpha-2 codes.
/// </summary>
/// <remarks>
/// This provider returns one or more time zones for a given country using
/// IANA time zone identifiers and their associated UTC offsets.
/// <para>
/// Some countries span multiple time zones; in such cases, all applicable
/// time zones are returned. The UTC offsets represent the standard offset
/// and do not account for daylight saving time (DST).
/// </para>
/// <para>
/// The data is intended as a reasonable default for country-level modeling
/// and may be overridden by individual country implementations when
/// more specific or localized behavior is required.
/// </para>
/// </remarks>

public static class TimeZoneProvider
{
    private static readonly IReadOnlyDictionary<string, IReadOnlyCollection<CountryTimeZone>> TimeZones
        = new Dictionary<string, IReadOnlyCollection<CountryTimeZone>>(StringComparer.OrdinalIgnoreCase)
        {
            // ======================
            // EUROPE
            // ======================
            ["AL"] = [TZ("Europe/Tirane", "UTC+1")],
            ["AD"] = [TZ("Europe/Andorra", "UTC+1")],
            ["AT"] = [TZ("Europe/Vienna", "UTC+1")],
            ["BE"] = [TZ("Europe/Brussels", "UTC+1")],
            ["BG"] = [TZ("Europe/Sofia", "UTC+2")],
            ["CH"] = [TZ("Europe/Zurich", "UTC+1")],
            ["CY"] = [TZ("Asia/Nicosia", "UTC+2")],
            ["CZ"] = [TZ("Europe/Prague", "UTC+1")],
            ["DE"] = [TZ("Europe/Berlin", "UTC+1")],
            ["DK"] = [TZ("Europe/Copenhagen", "UTC+1")],
            ["EE"] = [TZ("Europe/Tallinn", "UTC+2")],
            ["ES"] =
            [
                TZ("Europe/Madrid", "UTC+1"),
                TZ("Atlantic/Canary", "UTC+0")
            ],
            ["FI"] = [TZ("Europe/Helsinki", "UTC+2")],
            ["FR"] = new[] { TZ("Europe/Paris", "UTC+1") },
            ["GB"] = new[] { TZ("Europe/London", "UTC+0") },
            ["GR"] = new[] { TZ("Europe/Athens", "UTC+2") },
            ["HR"] = new[] { TZ("Europe/Zagreb", "UTC+1") },
            ["HU"] = new[] { TZ("Europe/Budapest", "UTC+1") },
            ["IE"] = new[] { TZ("Europe/Dublin", "UTC+0") },
            ["IS"] = new[] { TZ("Atlantic/Reykjavik", "UTC+0") },
            ["IT"] = new[] { TZ("Europe/Rome", "UTC+1") },
            ["LT"] = new[] { TZ("Europe/Vilnius", "UTC+2") },
            ["LU"] = new[] { TZ("Europe/Luxembourg", "UTC+1") },
            ["LV"] = new[] { TZ("Europe/Riga", "UTC+2") },
            ["MT"] = new[] { TZ("Europe/Malta", "UTC+1") },
            ["NL"] = new[] { TZ("Europe/Amsterdam", "UTC+1") },
            ["NO"] = new[] { TZ("Europe/Oslo", "UTC+1") },
            ["PL"] = new[] { TZ("Europe/Warsaw", "UTC+1") },
            ["PT"] = new[]
            {
                TZ("Europe/Lisbon", "UTC+0"),
                TZ("Atlantic/Azores", "UTC-1"),
                TZ("Atlantic/Madeira", "UTC+0")
            },
            ["RO"] = new[] { TZ("Europe/Bucharest", "UTC+2") },
            ["RU"] = new[]
            {
                TZ("Europe/Moscow", "UTC+3"),
                TZ("Asia/Yekaterinburg", "UTC+5"),
                TZ("Asia/Novosibirsk", "UTC+7"),
                TZ("Asia/Vladivostok", "UTC+10"),
                TZ("Asia/Kamchatka", "UTC+12")
            },
            ["SE"] = new[] { TZ("Europe/Stockholm", "UTC+1") },
            ["SI"] = new[] { TZ("Europe/Ljubljana", "UTC+1") },
            ["SK"] = new[] { TZ("Europe/Bratislava", "UTC+1") },
            ["UA"] = new[] { TZ("Europe/Kyiv", "UTC+2") },

            // ======================
            // AFRICA
            // ======================
            ["DZ"] = new[] { TZ("Africa/Algiers", "UTC+1") },
            ["EG"] = [TZ("Africa/Cairo", "UTC+2")],
            ["ET"] = new[] { TZ("Africa/Addis_Ababa", "UTC+3") },
            ["GH"] = new[] { TZ("Africa/Accra", "UTC+0") },
            ["KE"] = new[] { TZ("Africa/Nairobi", "UTC+3") },
            ["MA"] = new[] { TZ("Africa/Casablanca", "UTC+1") },
            ["NG"] = new[] { TZ("Africa/Lagos", "UTC+1") },
            ["ZA"] = new[] { TZ("Africa/Johannesburg", "UTC+2") },

            // ======================
            // MIDDLE EAST
            // ======================
            ["AE"] = new[] { TZ("Asia/Dubai", "UTC+4") },
            ["IL"] = new[] { TZ("Asia/Jerusalem", "UTC+2") },
            ["IQ"] = new[] { TZ("Asia/Baghdad", "UTC+3") },
            ["IR"] = new[] { TZ("Asia/Tehran", "UTC+3:30") },
            ["SA"] = new[] { TZ("Asia/Riyadh", "UTC+3") },
            ["TR"] = new[] { TZ("Europe/Istanbul", "UTC+3") },

            // ======================
            // ASIA
            // ======================
            ["CN"] = new[] { TZ("Asia/Shanghai", "UTC+8") },
            ["IN"] = new[] { TZ("Asia/Kolkata", "UTC+5:30") },
            ["ID"] = new[]
            {
                TZ("Asia/Jakarta", "UTC+7"),
                TZ("Asia/Makassar", "UTC+8"),
                TZ("Asia/Jayapura", "UTC+9")
            },
            ["JP"] = new[] { TZ("Asia/Tokyo", "UTC+9") },
            ["KR"] = new[] { TZ("Asia/Seoul", "UTC+9") },
            ["TH"] = new[] { TZ("Asia/Bangkok", "UTC+7") },
            ["VN"] = new[] { TZ("Asia/Ho_Chi_Minh", "UTC+7") },

            // ======================
            // AMERICAS
            // ======================
            ["US"] = new[]
            {
                TZ("America/New_York", "UTC-5"),
                TZ("America/Chicago", "UTC-6"),
                TZ("America/Denver", "UTC-7"),
                TZ("America/Los_Angeles", "UTC-8"),
                TZ("America/Anchorage", "UTC-9"),
                TZ("Pacific/Honolulu", "UTC-10")
            },
            ["CA"] = new[]
            {
                TZ("America/Toronto", "UTC-5"),
                TZ("America/Winnipeg", "UTC-6"),
                TZ("America/Edmonton", "UTC-7"),
                TZ("America/Vancouver", "UTC-8")
            },
            ["BR"] = new[]
            {
                TZ("America/Sao_Paulo", "UTC-3"),
                TZ("America/Manaus", "UTC-4"),
                TZ("America/Rio_Branco", "UTC-5")
            },
            ["MX"] = new[]
            {
                TZ("America/Mexico_City", "UTC-6"),
                TZ("America/Cancun", "UTC-5"),
                TZ("America/Tijuana", "UTC-8")
            },

            // ======================
            // OCEANIA
            // ======================
            ["AU"] = new[]
            {
                TZ("Australia/Sydney", "UTC+10"),
                TZ("Australia/Adelaide", "UTC+9:30"),
                TZ("Australia/Perth", "UTC+8")
            },
            ["NZ"] = new[]
            {
                TZ("Pacific/Auckland", "UTC+12"),
                TZ("Pacific/Chatham", "UTC+12:45")
            },
            ["FJ"] = new[] { TZ("Pacific/Fiji", "UTC+12") },
        };


    /// <summary>
    /// Gets the collection of time zones associated with the specified country.
    /// </summary>
    /// <param name="iso2">
    /// The ISO 3166-1 alpha-2 country code (e.g. <c>US</c>, <c>FR</c>, <c>JP</c>).
    /// </param>
    /// <returns>
    /// A read-only collection of time zone representations for the country.
    /// Each entry is formatted as <c>&lt;IANA ID&gt; (UTC±X)</c>.
    /// If the country code is not recognized, an empty collection is returned.
    /// </returns>
    /// <remarks>
    /// Countries that span multiple time zones will return more than one entry.
    /// The UTC offsets represent standard time and do not account for
    /// daylight saving time (DST).
    /// </remarks>

    public static IReadOnlyCollection<string> GetTimeZones(string iso2)
    {
        if (TimeZones.TryGetValue(iso2, out var zones))
        {
            return [..zones.Select(z => z.ToString())];
        }

        return [];
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="iana"></param>
    /// <param name="utc"></param>
    /// <returns></returns>
    public static CountryTimeZone TZ(string iana, string utc)
        => new(iana, utc);
}

/// <summary>
/// Represents a time zone associated with a country, including its IANA identifier
/// and the corresponding UTC offset.
/// </summary>
/// <param name="IanaId">
/// The IANA time zone identifier (e.g. <c>Europe/Paris</c>, <c>America/New_York</c>).
/// </param>
/// <param name="UtcOffset">
/// The UTC offset for the time zone (e.g. <c>UTC+1</c>, <c>UTC-5</c>, <c>UTC+5:30</c>).
/// </param>
public sealed class CountryTimeZone(string IanaId, string UtcOffset)
{
    /// <summary>
    /// Returns a human-readable string combining the IANA time zone identifier
    /// and its UTC offset.
    /// </summary>
    /// <returns>
    /// A formatted string in the form <c>&lt;IANA ID&gt; (UTC±X)</c>.
    /// </returns>
    public override string ToString() => $"{IanaId} ({UtcOffset})";
}

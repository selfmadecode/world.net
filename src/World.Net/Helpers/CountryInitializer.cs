namespace World.Net.Helpers;

internal sealed class CountryInitializer
{
    public static Dictionary<int, ICountry> Initialize()
    {
        return new Dictionary<int, ICountry>
        {
            { CountryIdentifier.AfghanistanId, new Afghanistan() }
            // Future countries can be added here in the same format.
        };
    }
}

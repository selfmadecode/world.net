namespace World.Net.Helpers;

internal sealed class CountryInitializer
{
    public static Dictionary<int, ICountry> Initialize()
    {
        return new Dictionary<int, ICountry>
        {
            { CountryIdentifier.AfghanistanId, new Afghanistan() },
            { CountryIdentifier.AlandIslands, new AlandIslands() },
            { CountryIdentifier.Algeria, new Algeria() },
            { CountryIdentifier.AmericanSamoa, new AmericanSamoa() },
            { CountryIdentifier.Andorra, new Andorra() },
            { CountryIdentifier.Albania, new Albania() }
            // Future countries can be added here in the same format.
        };
    }
}

namespace World.Net.Helpers;

internal sealed class CountryInitializer
{
    public static Dictionary<CountryIdentifier, ICountry> Initialize()
    {
        return new Dictionary<CountryIdentifier, ICountry>
        {
            { CountryIdentifier.Afghanistan, new Afghanistan() },
            { CountryIdentifier.AlandIslands, new AlandIslands() },
            { CountryIdentifier.Albania, new Albania() },
            { CountryIdentifier.Algeria, new Algeria() },
            { CountryIdentifier.AmericanSamoa, new AmericanSamoa() },
            { CountryIdentifier.Andorra, new Andorra() },
            { CountryIdentifier.AntiguaAndBarbuda, new AntiguaAndBarbuda() },
            { CountryIdentifier.Armenia, new Armenia() },
            { CountryIdentifier.Argentina, new Argentina() },
            { CountryIdentifier.Angola, new Angola() },
            { CountryIdentifier.Anguilla, new Anguilla() },
            { CountryIdentifier.Antarctica, new Antarctica() },
            { CountryIdentifier.Aruba, new Aruba() },
            { CountryIdentifier.Australia, new Australia() },
            { CountryIdentifier.Austria, new Austria() },
            { CountryIdentifier.Azerbaijan, new Azerbaijan() },
            { CountryIdentifier.Bahamas, new TheBahamas() },
            { CountryIdentifier.Bahrain, new Bahrain() },
            { CountryIdentifier.Bangladesh, new Bangladesh() },
            { CountryIdentifier.Barbados, new Barbados() },
            { CountryIdentifier.Belarus, new Belarus() },
            { CountryIdentifier.Belgium, new Belgium() },
            { CountryIdentifier.Belize, new Belize() },
            { CountryIdentifier.Benin, new Benin() },
            { CountryIdentifier.Bermuda, new Bermuda() },
            { CountryIdentifier.Bhutan, new Bhutan() },
            { CountryIdentifier.Bolivia, new Bolivia() },
            { CountryIdentifier.BosniaAndHerzegovina, new BosniaAndHerzegovina() },
            { CountryIdentifier.Botswana, new Botswana() },
            { CountryIdentifier.BouvetIsland, new BouvetIsland() },

            // Future countries can be added here in the same format.
        };
    }
}

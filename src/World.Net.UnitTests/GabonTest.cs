using World.Net.Countries;
using World.Net.Helpers;
using Xunit;

namespace World.Net.UnitTests;

public class GabonTest
{
    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForGabon()
    {
        var country = CountryProvider.GetCountry(CountryIdentifier.Gabon);

        Assert.Equal(CountryIdentifier.Gabon, country.Id);
        Assert.Equal("Gabon", country.Name);
        Assert.Equal("Gabonese Republic", country.OfficialName);
        Assert.Equal("République gabonaise", country.NativeName);
        Assert.Equal("Libreville", country.Capital);
        Assert.Equal(266, country.NumericCode);
        Assert.Equal("GA", country.ISO2Code);
        Assert.Equal("GAB", country.ISO3Code);
        Assert.Equal(new[] { "+241" }, country.CallingCode);
    }
}

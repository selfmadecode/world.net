namespace World.Net.UnitTests.Countries;

public sealed class AlgeriaTest
{
    [Fact]
    public void Algeria_HasExpectedInformation()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.Algeria;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(4, country.Id);
        Assert.Equal("Algeria", country.Name);
        Assert.Equal("People's Democratic Republic of Algeria", country.OfficialName);
        Assert.Equal("الجزائر", country.NativeName);
        Assert.Equal("Algiers", country.Capital);
        Assert.Equal(12, country.NumericCode);
        Assert.Equal("DZ", country.ISO2Code);
        Assert.Equal("DZA", country.ISO3Code);
        Assert.Equal("+213", country.CallingCode);
    }

}

namespace World.Net.UnitTests.Countries;

public sealed class AlandIslandsTest
{
    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForAlandIslands()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.AlandIslands;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(2, country.Id);
        Assert.Equal("Aland Islands", country.Name);
        Assert.Equal("Åland Islands", country.OfficialName);
        Assert.Equal("Åland", country.NativeName);
        Assert.Equal("Mariehamn", country.Capital);
        Assert.Equal(248, country.NumericCode);
        Assert.Equal("AX", country.ISO2Code);
        Assert.Equal("ALA", country.ISO3Code);
        Assert.Equal("+358", country.CallingCode);
    }
}

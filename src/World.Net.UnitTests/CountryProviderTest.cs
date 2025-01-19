using System;
using World.Net.Helpers;

namespace World.Net.UnitTests;

public sealed class CountryProviderTest
{
    [Fact]
    public void GetAllCountries_ShouldReturn_NonEmptyAndNonNullCollection()
    {
        var countries = CountryProvider.GetAllCountries();

        Assert.NotEmpty(countries);
        Assert.NotNull(countries);
    }

    [Fact]
    public void GetCountry_ShouldReturn_Country_WhenCountryExists()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.AfghanistanId;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);
        
        // Assert
        Assert.NotNull(country);
        Assert.NotEmpty(country.Name);
        Assert.NotEmpty(country.States);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal("Afghanistan", country.Name);
        Assert.Equal("افغانستان", country.NativeName);
        Assert.Equal("Islamic Republic of Afghanistan", country.OfficialName);
        Assert.Equal(004, country.NumericCode);
        Assert.Equal("AF", country.ISO2Code);
        Assert.Equal("AFG", country.ISO3Code);
        Assert.Equal("+93", country.CallingCode);
        Assert.Equal(34, country.States.Count());
        Assert.Equal("Kabul", country.Capital);
    }

    [Fact]
    public void GetCountry_ShouldThrow_CountryNotFoundException_WhenCountryDoesNotExist()
    {
        // Arrange
        int nonExistingCountryId = -9999;

        // Act & Assert
        var exception = Assert.Throws<CountryNotFoundException>(() => CountryProvider.GetCountry(nonExistingCountryId));
        Assert.Equal($"Country with id {nonExistingCountryId} was not found.", exception.Message);
    }
}
﻿namespace World.Net.UnitTests.Countries;

public sealed class AndorraTest
{
    private const string ANDORRA_NAME = "Andorra";
    private const string ANDORRA_OFFICIAL_NAME = "Principality of Andorra";
    private const string ANDORRA_NATIVE_NAME ="Andorra";
    private const string ANDORRA_CAPITAL = "Andorra la Vella";
    private const int ANDORRA_NUMERIC_CODE = 020;
    private const string ANDORRA_ISO2_CODE = "AD";
    private const string ANDORRA_ISO3_CODE = "AND";
    private readonly string[] ANDORRA_CALLING_CODE = ["+376"];
    private const int ANDORRA_PARISH_COUNT = 7;
    private const string ANDORRA_STATE_TYPE = "Parish";
    
    [Fact]
    public void Andorra_HasExpectedInformation()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Andorra;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(ANDORRA_NAME, country.Name);
        Assert.Equal(ANDORRA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(ANDORRA_NATIVE_NAME, country.NativeName);
        Assert.Equal(ANDORRA_CAPITAL, country.Capital);
        Assert.Equal(ANDORRA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(ANDORRA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(ANDORRA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(ANDORRA_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(ANDORRA_PARISH_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Equal(ANDORRA_STATE_TYPE, state.Type));
    }
}

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

    
}
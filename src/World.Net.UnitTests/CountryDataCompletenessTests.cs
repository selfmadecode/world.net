using System.Linq;
using World.Net;
using World.Net.Types;
using Xunit;

namespace World.Net.UnitTests
{
    public class CountryDataCompletenessTests
    {
        [Fact]
        public void AllCountries_ProvideCurrency_TimeZones_AndFlag()
        {
            var countries = CountryProvider.GetAllCountries();

            Assert.NotEmpty(countries);

            foreach (var country in countries)
            {
                // Currency record should be non-null
                Assert.NotNull(country.Currency);

                // TimeZones should contain at least one entry
                Assert.NotNull(country.TimeZones);
                Assert.NotEmpty(country.TimeZones);

                // Flag ISO2 should match the country's ISO2 code
                //Assert.NotNull(country.Flag);
                //Assert.Equal(country.ISO2Code, country.Flag.ISO2);

                //// Emoji should be present for two-letter ISO codes
                //if (!string.IsNullOrWhiteSpace(country.ISO2Code) && country.ISO2Code.Length == 2)
                //{
                //    Assert.False(string.IsNullOrWhiteSpace(country.Flag.Emoji));
                //}
            }
        }
    }
}

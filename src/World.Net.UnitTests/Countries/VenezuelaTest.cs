using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class VenezuelaTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Venezuela";
        private const string NATIVE_NAME = "República Bolivariana de Venezuela";
        private const string CAPITAL = "Caracas";
        private const string OFFICIAL_NAME = "Bolivarian Republic of Venezuela";
        private const string ISO2_CODE = "VE";
        private const string ISO3_CODE = "VEN";
        private const int NUMERIC_CODE = 862;
        private readonly string[] CALLING_CODE = ["+58"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Venezuela;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("Amazonas", "VE-Z", "State"),
        ("Anzoátegui", "VE-B", "State"),
        ("Apure", "VE-C", "State"),
        ("Aragua", "VE-D", "State"),
        ("Barinas", "VE-E", "State"),
        ("Bolívar", "VE-F", "State"),
        ("Carabobo", "VE-G", "State"),
        ("Cojedes", "VE-H", "State"),
        ("Delta Amacuro", "VE-Y", "State"),
        ("Falcón", "VE-I", "State"),
        ("Guárico", "VE-J", "State"),
        ("Lara", "VE-K", "State"),
        ("Mérida", "VE-L", "State"),
        ("Miranda", "VE-M", "State"),
        ("Monagas", "VE-N", "State"),
        ("Nueva Esparta", "VE-O", "State"),
        ("Portuguesa", "VE-P", "State"),
        ("Sucre", "VE-R", "State"),
        ("Táchira", "VE-S", "State"),
        ("Trujillo", "VE-T", "State"),
        ("Vargas", "VE-X", "State"),
        ("Yaracuy", "VE-U", "State"),
        ("Zulia", "VE-V", "State"),
        ("Capital District", "VE-DC", "Capital District")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForVenezuela()
        {
            var country = CountryProvider.GetCountry(EXPECTEDID);

            AssertCorrectInformation(
                country,
                EXPECTEDID,
                COUNTRY_NAME,
                OFFICIAL_NAME,
                NATIVE_NAME,
                CAPITAL,
                NUMERIC_CODE,
                ISO2_CODE,
                ISO3_CODE,
                CALLING_CODE,
                EXPECTED_STATES
            );
        }
    }

}

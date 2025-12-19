using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class UruguayTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Uruguay";
        private const string NATIVE_NAME = "República Oriental del Uruguay";
        private const string CAPITAL = "Montevideo";
        private const string OFFICIAL_NAME = "Oriental Republic of Uruguay";
        private const string ISO2_CODE = "UY";
        private const string ISO3_CODE = "URY";
        private const int NUMERIC_CODE = 858;
        private readonly string[] CALLING_CODE = ["+598"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Uruguay;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("Artigas", "UY-AR", "Department"),
        ("Canelones", "UY-CA", "Department"),
        ("Cerro Largo", "UY-CL", "Department"),
        ("Colonia", "UY-CO", "Department"),
        ("Durazno", "UY-DU", "Department"),
        ("Flores", "UY-FS", "Department"),
        ("Florida", "UY-FD", "Department"),
        ("Lavalleja", "UY-LA", "Department"),
        ("Maldonado", "UY-MA", "Department"),
        ("Montevideo", "UY-MO", "Department"),
        ("Paysandú", "UY-PA", "Department"),
        ("Río Negro", "UY-RN", "Department"),
        ("Rivera", "UY-RV", "Department"),
        ("Rocha", "UY-RO", "Department"),
        ("Salto", "UY-SA", "Department"),
        ("San José", "UY-SJ", "Department"),
        ("Soriano", "UY-SO", "Department"),
        ("Tacuarembó", "UY-TA", "Department"),
        ("Treinta y Tres", "UY-TT", "Department")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForUruguay()
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

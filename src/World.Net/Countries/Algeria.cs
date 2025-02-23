// Copyright (c) Raphael Anyanwu. All rights reserved.
// Licensed under the MIT License.
namespace World.Net.Countries;

internal sealed class Algeria : ICountry
{
    ///<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Algeria;

    ///<inheritdoc/>
    public string Name => nameof(Algeria);

    ///<inheritdoc/>
    public string OfficialName { get; } = "People's Democratic Republic of Algeria";

    ///<inheritdoc/>
    public string NativeName { get; } = "الجزائر";

    ///<inheritdoc/>
    public string Capital { get; } = "Algiers";

    ///<inheritdoc/>
    public int NumericCode { get; } = 012;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "DZ";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "DZA";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+213";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Adrar", "DZ-01"),
        new("Aïn Defla", "DZ-44"),
        new("Aïn Témouchent", "DZ-46"),
        new("Algiers", "DZ-16"),
        new("Annaba", "DZ-23"),
        new("Batna", "DZ-05"),
        new("Béchar", "DZ-08"),
        new("Béjaïa", "DZ-06"),
        new("Béni Abbès", "DZ-52"),
        new("Biskra", "DZ-07"),
        new("Blida", "DZ-09"),
        new("Bordj Badji Mokhtar", "DZ-50"),
        new("Bordj Bou Arréridj", "DZ-34"),
        new("Bouira", "DZ-10"),
        new("Boumerdès", "DZ-35"),
        new("Chlef", "DZ-02"),
        new("Constantine", "DZ-25"),
        new("Djanet", "DZ-56"),
        new("Djelfa", "DZ-17"),
        new("El Bayadh", "DZ-32"),
        new("El Meniaa", "DZ-58"),
        new("El M’Ghair", "DZ-57"),
        new("El Oued", "DZ-39"),
        new("El Tarf", "DZ-36"),
        new("Ghardaïa", "DZ-47"),
        new("Guelma", "DZ-24"),
        new("Illizi", "DZ-33"),
        new("In Guezzam", "DZ-54"),
        new("In Salah", "DZ-53"),
        new("Jijel", "DZ-18"),
        new("Khenchela", "DZ-40"),
        new("Laghouat", "DZ-03"),
        new("Médéa", "DZ-26"),
        new("Mascara", "DZ-29"),
        new("Mila", "DZ-43"),
        new("Mostaganem", "DZ-27"),
        new("M’Sila", "DZ-28"),
        new("Naâma", "DZ-45"),
        new("Oran", "DZ-31"),
        new("Ouargla", "DZ-30"),
        new("Ouled Djellal", "DZ-51"),
        new("Relizane", "DZ-48"),
        new("Saïda", "DZ-20"),
        new("Sétif", "DZ-19"),
        new("Sidi Bel Abbès", "DZ-22"),
        new("Skikda", "DZ-21"),
        new("Souk Ahras", "DZ-41"),
        new("Tamanghasset", "DZ-11"),
        new("Tébessa", "DZ-12"),
        new("Tiaret", "DZ-14"),
        new("Tindouf", "DZ-37"),
        new("Tipaza", "DZ-42"),
        new("Tissemsilt", "DZ-38"),
        new("Tizi Ouzou", "DZ-15"),
        new("Tlemcen", "DZ-13"),
        new("Timimoun", "DZ-49"),
        new("Touggourt", "DZ-55")
    ];
}

namespace World.Net.Countries
{
    internal sealed class Latvia : ICountry
    {
        ///<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.Latvia;

        ///<inheritdoc/>
        public string Name { get; } = "Latvia";

        ///<inheritdoc/>
        public string OfficialName { get; } = "Republic of Latvia";

        ///<inheritdoc/>
        public string NativeName { get; } = "Latvijas Republika";

        ///<inheritdoc/>
        public string Capital { get; } = "Riga";

        ///<inheritdoc/>
        public int NumericCode { get; } = 428;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "LV";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "LVA";

        ///<inheritdoc/>
        public string[] CallingCode { get; } = ["+371"];

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Aizkraukle", "LV-AI", "Municipality"),
            new("Alūksne", "LV-AL", "Municipality"),
            new("Balvi", "LV-BL", "Municipality"),
            new("Bauska", "LV-BU", "Municipality"),
            new("Cēsis", "LV-CE", "Municipality"),
            new("Dobele", "LV-DO", "Municipality"),
            new("Gulbene", "LV-GU", "Municipality"),
            new("Jelgava", "LV-JL", "Municipality"),
            new("Jēkabpils", "LV-JK", "Municipality"),
            new("Krāslava", "LV-KR", "Municipality"),
            new("Kuldīga", "LV-KU", "Municipality"),
            new("Limbaži", "LV-LM", "Municipality"),
            new("Līvāni", "LV-LV", "Municipality"),
            new("Ludza", "LV-LU", "Municipality"),
            new("Madona", "LV-MA", "Municipality"),
            new("Ogre", "LV-OG", "Municipality"),
            new("Preiļi", "LV-PR", "Municipality"),
            new("Rēzekne", "LV-RE", "Municipality"),
            new("Riga", "LV-RI", "Municipality"),
            new("Saldus", "LV-SA", "Municipality"),
            new("Sigulda", "LV-SI", "Municipality"),
            new("Smiltene", "LV-SM", "Municipality"),
            new("Talsi", "LV-TA", "Municipality"),
            new("Tukums", "LV-TU", "Municipality"),
            new("Valka", "LV-VA", "Municipality"),
            new("Valmiera", "LV-VM", "Municipality"),
            new("Ventspils", "LV-VE", "Municipality"),
            new("Augšdaugava", "LV-AD", "Municipality"),
            new("Dienvidkurzeme", "LV-DK", "Municipality"),
            new("Rēzekne City", "LV-RC", "Republic City"),
            new("Daugavpils City", "LV-DC", "Republic City"),
            new("Jelgava City", "LV-JC", "Republic City"),
            new("Jūrmala City", "LV-JU", "Republic City"),
            new("Liepāja City", "LV-LP", "Republic City"),
            new("Riga City", "LV-RG", "Republic City"),
            new("Ventspils City", "LV-VC", "Republic City")
        ];
    }
}

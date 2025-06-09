namespace World.Net.Countries;
internal sealed class Italy : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Italy;

    //<inheritdoc/>
    public string Name { get; } = "Italy";

    //<inheritdoc/>
    public string OfficialName { get; } = "Italian Republic";

    //<inheritdoc/>
    public string NativeName => "Italia";

    //<inheritdoc/>
    public string Capital { get; } = "Rome";

    //<inheritdoc/>
    public int NumericCode { get; } = 380;

    //<inheritdoc/>
    public string ISO2Code { get; } = "IT";

    //<inheritdoc/>
    public string ISO3Code { get; } = "ITA";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+39"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Abruzzo", "IT-65", "Region"),
        new("Agrigento", "IT-AG", "Free Municipal Consortium"),
        new("Alessandria", "IT-AL", "Province"),
        new("Ancona", "IT-AN", "Province"),
        new("Aosta Valley", "IT-23", "Autonomous Region"),
        new("Apulia", "IT-75", "Region"),
        new("Arezzo", "IT-AR", "Province"),
        new("Ascoli Piceno", "IT-AP", "Province"),
        new("Asti", "IT-AT", "Province"),
        new("Avellino", "IT-AV", "Province"),
        new("Barletta-Andria-Trani", "IT-BT", "Province"),
        new("Basilicata", "IT-77", "Region"),
        new("Belluno", "IT-BL", "Province"),
        new("Benevento", "IT-BN", "Province"),
        new("Bergamo", "IT-BG", "Province"),
        new("Biella", "IT-BI", "Province"),
        new("Brescia", "IT-BS", "Province"),
        new("Brindisi", "IT-BR", "Province"),
        new("Calabria", "IT-78", "Region"),
        new("Caltanissetta", "IT-CL", "Free Municipal Consortium"),
        new("Campania", "IT-72", "Region"),
        new("Campobasso", "IT-CB", "Province"),
        new("Caserta", "IT-CE", "Province"),
        new("Catanzaro", "IT-CZ", "Province"),
        new("Chieti", "IT-CH", "Province"),
        new("Como", "IT-CO", "Province"),
        new("Cosenza", "IT-CS", "Province"),
        new("Cremona", "IT-CR", "Province"),
        new("Crotone", "IT-KR", "Province"),
        new("Cuneo", "IT-CN", "Province"),
        new("Emilia-Romagna", "IT-45", "Region"),
        new("Enna", "IT-EN", "Free Municipal Consortium"),
        new("Fermo", "IT-FM", "Province"),
        new("Ferrara", "IT-FE", "Province"),
        new("Foggia", "IT-FG", "Province"),
        new("Forlì-Cesena", "IT-FC", "Province"),
        new("Friuli–Venezia Giulia", "IT-36", "Autonomous Region"),
        new("Frosinone", "IT-FR", "Province"),
        new("Gorizia", "IT-GO", "Decentralized Regional Entity"),
        new("Grosseto", "IT-GR", "Province"),
        new("Imperia", "IT-IM", "Province"),
        new("Isernia", "IT-IS", "Province"),
        new("L'Aquila", "IT-AQ", "Province"),
        new("La Spezia", "IT-SP", "Province"),
        new("Latina", "IT-LT", "Province"),
        new("Lazio", "IT-62", "Region"),
        new("Lecce", "IT-LE", "Province"),
        new("Lecco", "IT-LC", "Province"),
        new("Liguria", "IT-42", "Region"),
        new("Livorno", "IT-LI", "Province"),
        new("Lodi", "IT-LO", "Province"),
        new("Lombardy", "IT-25", "Region"),
        new("Lucca", "IT-LU", "Province"),
        new("Macerata", "IT-MC", "Province"),
        new("Mantua", "IT-MN", "Province"),
        new("Marche", "IT-57", "Region"),
        new("Massa and Carrara", "IT-MS", "Province"),
        new("Matera", "IT-MT", "Province"),
        new("Modena", "IT-MO", "Province"),
        new("Molise", "IT-67", "Region"),
        new("Monza and Brianza", "IT-MB", "Province"),
        new("Novara", "IT-NO", "Province"),
        new("Nuoro", "IT-NU", "Province"),
        new("Oristano", "IT-OR", "Province"),
        new("Padua", "IT-PD", "Province"),
        new("Palermo", "IT-PA", "Metropolitan City"),
        new("Parma", "IT-PR", "Province"),
        new("Pavia", "IT-PV", "Province"),
        new("Perugia", "IT-PG", "Province"),
        new("Pesaro and Urbino", "IT-PU", "Province"),
        new("Pescara", "IT-PE", "Province"),
        new("Piacenza", "IT-PC", "Province"),
        new("Piedmont", "IT-21", "Region"),
        new("Pisa", "IT-PI", "Province"),
        new("Pistoia", "IT-PT", "Province"),
        new("Pordenone", "IT-PN", "Decentralized Regional Entity"),
        new("Potenza", "IT-PZ", "Province"),
        new("Prato", "IT-PO", "Province"),
        new("Ragusa", "IT-RG", "Free Municipal Consortium"),
        new("Ravenna", "IT-RA", "Province"),
        new("Reggio Emilia", "IT-RE", "Province"),
        new("Rieti", "IT-RI", "Province"),
        new("Rimini", "IT-RN", "Province"),
        new("Rovigo", "IT-RO", "Province"),
        new("Salerno", "IT-SA", "Province"),
        new("Sardinia", "IT-88", "Autonomous Region"),
        new("Sassari", "IT-SS", "Province"),
        new("Savona", "IT-SV", "Province"),
        new("Sicily", "IT-82", "Autonomous Region"),
        new("Siena", "IT-SI", "Province"),
        new("Siracusa", "IT-SR", "Free Municipal Consortium"),
        new("Sondrio", "IT-SO", "Province"),
        new("South Sardinia", "IT-SU", "Province"),
        new("Taranto", "IT-TA", "Province"),
        new("Teramo", "IT-TE", "Province"),
        new("Terni", "IT-TR", "Province"),
        new("Trapani", "IT-TP", "Free Municipal Consortium"),
        new("Trentino-South Tyrol", "IT-32", "Autonomous Region"),
        new("Treviso", "IT-TV", "Province"),
        new("Trieste", "IT-TS", "Decentralized Regional Entity"),
        new("Tuscany", "IT-52", "Region"),
        new("Udine", "IT-UD", "Decentralized Regional Entity"),
        new("Umbria", "IT-55", "Region"),
        new("Varese", "IT VA", "Province"),
        new("Veneto", "IT-34", "Region"),
        new("Verbano-Cusio-Ossola", "IT-VB", "Province"),
        new("Vercelli", "IT-VC", "Province"),
        new("Verona", "IT-VR", "Province"),
        new("Vibo Valentia", "IT-VV", "Province"),
        new("Vicenza", "IT-VI", "Province"),
        new("Viterbo", "IT-VT", "Province"),
    ];
}

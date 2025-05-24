﻿namespace World.Net.Countries;
internal sealed class France : ICountry
{
    ///<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.France;

    ///<inheritdoc/>
    public string Name => nameof(France);

    ///<inheritdoc/>
    public string OfficialName { get; } = "French Republic";

    ///<inheritdoc/>
    public string NativeName { get; } = "France";

    ///<inheritdoc/>
    public string Capital { get; } = "Paris";

    ///<inheritdoc/>
    public int NumericCode { get; } = 250;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "FR";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "FRA";

    ///<inheritdoc/>
    public string[] CallingCode { get; } = ["+33"];

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Ain", "FR-01", "metropolitan department"),
        new("Aisne", "FR-02", "metropolitan department"),
        new("Allier", "FR-03", "metropolitan department"),
        new("Alpes-de-Haute-Provence", "FR-04", "metropolitan department"),
        new("Alpes-Maritimes", "FR-06", "metropolitan department"),
        new("Alsace", "FR-6AE", "European collectivity"),
        new("Ardèche", "FR-07", "metropolitan department"),
        new("Ardennes", "FR-08", "metropolitan department"),
        new("Ariège", "FR-09", "metropolitan department"),
        new("Aube", "FR-10", "metropolitan department"),
        new("Aude", "FR-11", "metropolitan department"),
        new("Auvergne-Rhône-Alpes", "FR-ARA", "metropolitan region"),
        new("Aveyron", "FR-12", "metropolitan department"),
        new("Bas-Rhin", "FR-67", "metropolitan department"),
        new("Bouches-du-Rhône", "FR-13", "metropolitan department"),
        new("Bourgogne-Franche-Comté", "FR-BFC", "metropolitan region"),
        new("Bretagne", "FR-BRE", "metropolitan region"),
        new("Calvados", "FR-14", "metropolitan department"),
        new("Cantal", "FR-15", "metropolitan department"),
        new("Centre-Val de Loire", "FR-CVL", "metropolitan region"),
        new("Charente", "FR-16", "metropolitan department"),
        new("Charente-Maritime", "FR-17", "metropolitan department"),
        new("Cher", "FR-18", "metropolitan department"),
        new("Clipperton", "FR-CP", "dependency"),
        new("Corrèze", "FR-19", "metropolitan department"),
        new("Corse", "FR-20R", "metropolitan collectivity with special status"),
        new("Corse-du-Sud", "FR-2A", "metropolitan department"),
        new("Côte-d'Or", "FR-21", "metropolitan department"),
        new("Côtes-d'Armor", "FR-22", "metropolitan department"),
        new("Creuse", "FR-23", "metropolitan department"),
        new("Deux-Sèvres", "FR-79", "metropolitan department"),
        new("Dordogne", "FR-24", "metropolitan department"),
        new("Doubs", "FR-25", "metropolitan department"),
        new("Drôme", "FR-26", "metropolitan department"),
        new("Essonne", "FR-91", "metropolitan department"),
        new("Eure", "FR-27", "metropolitan department"),
        new("Eure-et-Loir", "FR-28", "metropolitan department"),
        new("Finistère", "FR-29", "metropolitan department"),
        new("French Guiana", "FR-973", "overseas region"),
        new("French Polynesia", "FR-PF", "overseas collectivity"),
        new("French Southern and Antarctic Lands", "FR-TF", "overseas territory"),
        new("Gard", "FR-30", "metropolitan department"),
        new("Gers", "FR-32", "metropolitan department"),
        new("Gironde", "FR-33", "metropolitan department"),
        new("Grand-Est", "FR-GES", "metropolitan region"),
        new("Guadeloupe", "FR-971", "overseas region"),
        new("Haut-Rhin", "FR-68", "metropolitan department"),
        new("Haute-Corse", "FR-2B", "metropolitan department"),
        new("Haute-Garonne", "FR-31", "metropolitan department"),
        new("Haute-Loire", "FR-43", "metropolitan department"),
        new("Haute-Marne", "FR-52", "metropolitan department"),
        new("Haute-Saône", "FR-70", "metropolitan department"),
        new("Haute-Savoie", "FR-74", "metropolitan department"),
        new("Haute-Vienne", "FR-87", "metropolitan department"),
        new("Hautes-Alpes", "FR-05", "metropolitan department"),
        new("Hautes-Pyrénées", "FR-65", "metropolitan department"),
        new("Hauts-de-France", "FR-HDF", "metropolitan region"),
        new("Hauts-de-Seine", "FR-92", "metropolitan department"),
        new("Hérault", "FR-34", "metropolitan department"),
        new("Île-de-France", "FR-IDF", "metropolitan region"),
        new("Ille-et-Vilaine", "FR-35", "metropolitan department"),
        new("Indre", "FR-36", "metropolitan department"),
        new("Indre-et-Loire", "FR-37", "metropolitan department"),
        new("Isère", "FR-38", "metropolitan department"),
        new("Jura", "FR-39", "metropolitan department"),
        new("La Réunion", "FR-974", "overseas region"),
        new("Landes", "FR-40", "metropolitan department"),
        new("Loir-et-Cher", "FR-41", "metropolitan department"),
        new("Loire", "FR-42", "metropolitan department"),
        new("Loire-Atlantique", "FR-44", "metropolitan department"),
        new("Loiret", "FR-45", "metropolitan department"),
        new("Lot", "FR-46", "metropolitan department"),
        new("Lot-et-Garonne", "FR-47", "metropolitan department"),
        new("Lozère", "FR-48", "metropolitan department"),
        new("Maine-et-Loire", "FR-49", "metropolitan department"),
        new("Manche", "FR-50", "metropolitan department"),
        new("Marne", "FR-51", "metropolitan department"),
        new("Martinique", "FR-972", "overseas region"),
        new("Mayenne", "FR-53", "metropolitan department"),
        new("Mayotte", "FR-976", "overseas region"),
        new("Métropole de Lyon", "FR-69M", "metropolitan department"),
        new("Meurthe-et-Moselle", "FR-54", "metropolitan department"),
        new("Meuse", "FR-55", "metropolitan department"),
        new("Morbihan", "FR-56", "metropolitan department"),
        new("Moselle", "FR-57", "metropolitan department"),
        new("Nièvre", "FR-58", "metropolitan department"),
        new("Nord", "FR-59", "metropolitan department"),
        new("Oise", "FR-60", "metropolitan department"),
        new("Oléron", "FR-OL", "dependency"),
        new("Orne", "FR-61", "metropolitan department"),
        new("Paris", "FR-75", "metropolitan department"),
        new("Pas-de-Calais", "FR-62", "metropolitan department"),
        new("Puy-de-Dôme", "FR-63", "metropolitan department"),
        new("Pyrénées-Atlantiques", "FR-64", "metropolitan department"),
        new("Pyrénées-Orientales", "FR-66", "metropolitan department"),
        new("Réunion", "FR-974", "overseas region"),
        new("Rhône", "FR-69", "metropolitan department"),
        new("Saône-et-Loire", "FR-71", "metropolitan department"),
        new("Sarthe", "FR-72", "metropolitan department"),
        new("Savoie", "FR-73", "metropolitan department"),
        new("Seine-et-Marne", "FR-77", "metropolitan department"),
        new("Seine-Maritime", "FR-76", "metropolitan department"),
        new("Yvelines", "FR-78", "metropolitan department"),
        new("Somme", "FR-80", "metropolitan department"),
        new("Tarn", "FR-81", "metropolitan department"),
        new("Tarn-et-Garonne", "FR-82", "metropolitan department"),
        new("Territoire de Belfort", "FR-90", "metropolitan department"),
        new("Val-de-Marne", "FR-94", "metropolitan department"),
        new("Val-d'Oise", "FR-95", "metropolitan department"),
        new("Var", "FR-83", "metropolitan department"),
        new("Vaucluse", "FR-84", "metropolitan department"),
        new("Vendée", "FR-85", "metropolitan department"),
        new("Vienne", "FR-86", "metropolitan department"),
        new("Vosges", "FR-88", "metropolitan department"),
        new("Yonne", "FR-89", "metropolitan department"),
        new("Yvelines", "FR-78", "metropolitan department")
    ];
}

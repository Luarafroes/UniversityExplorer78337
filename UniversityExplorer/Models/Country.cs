namespace UniversityExplorer.Models;

// Matches the JSON returned by the Countries API
public class Country
{
    public string Name { get; set; } = "";
    public string? Capital { get; set; }   // nullable: some places have no capital
    public string Region { get; set; } = "";
    public long Population { get; set; }   // long, because some populations are huge
    public string Flag { get; set; } = ""; // the flag emoji
    public CountryFlags? Flags { get; set; } // flag image links
}

public class CountryFlags
{
    public string Png { get; set; } = "";
    public string Svg { get; set; } = "";
}
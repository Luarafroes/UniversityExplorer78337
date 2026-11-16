using System.Text.Json.Serialization;

namespace UniversityExplorer.Models;

// Matches the JSON returned by the Universities API
public class University
{
    public string Name { get; set; } = "";
    public string Country { get; set; } = "";

    // The API uses snake_case names, so we map them to C# names
    [JsonPropertyName("alpha_two_code")]
    public string AlphaTwoCode { get; set; } = "";

    [JsonPropertyName("web_pages")]
    public List<string> WebPages { get; set; } = new();

    public List<string> Domains { get; set; } = new();
}
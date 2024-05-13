using System.Text.Json.Serialization;

class VerseData
{
    [JsonPropertyName("verses")]
    public List<Verse> _verses { get; set; }
}
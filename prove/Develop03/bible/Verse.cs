using System.Text.Json.Serialization;

class Verse
{
    [JsonPropertyName("book_name")]
    public string _book_name { get; set; }
    [JsonIgnore]
    public int _book { get; set; }
    [JsonPropertyName("chapter")]
    public int _chapter { get; set; }
    [JsonPropertyName("verse")]
    public int _verse { get; set; }
    [JsonPropertyName("text")]
    public string _text { get; set; }
}
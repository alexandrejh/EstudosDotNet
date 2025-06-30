using System.Text.Json.Serialization;

namespace _02.TopicosIniciais.ReadJson.Entities;

public class Lesson
{

    public Lesson()
    {
    }

    public Lesson(int id, string title, string media, DateTime timestamp)
    {
        Id = id;
        Title = title;
        Media = media;
        Timestamp = timestamp;
    }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("media")]
    public string Media { get; set; }
    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }
}
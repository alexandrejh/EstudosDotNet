using System.Text.Json.Serialization;

namespace _02.TopicosIniciais.ReadJson.Entities;

public class Course
{

    public Course()
    {
    }

    public Course(int id, string title)
    {
        Id = id;
        Title = title;
    }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("lessons")]
    public List<Lesson> Lessons { get; set; } = new();

    public void AddLesson(Lesson lesson)
    {
        Lessons.Add(lesson);
    }
}
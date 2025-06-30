using System.Text.Json;
using _02.TopicosIniciais.ReadJson.Entities;

namespace _02.TopicosIniciais.ReadJson;

public static class ReadJsonRunner
{
    public static void Run()
    {
        try
        {
            var jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReadJson", "file.json");
        
            var jsonContent = File.ReadAllText(jsonFilePath);
        
            var courses = JsonSerializer.Deserialize<List<Course>>(jsonContent);
        
            foreach (var course in courses)
            {
                Console.WriteLine($"Course {course.Id}: {course.Title}");

                foreach (var lesson in course.Lessons)
                {
                    Console.WriteLine();
                    Console.WriteLine($"  Id: {lesson.Id}");
                    Console.WriteLine($"  Title: {lesson.Title}");
                    Console.WriteLine($"  Media: {lesson.Media}");
                    Console.WriteLine($"  Timestamp: {lesson.Timestamp}");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}

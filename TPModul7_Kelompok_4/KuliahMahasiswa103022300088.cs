using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class KuliahMahasiswa103022300088
{
    public class Course
    {
        [JsonPropertyName("code")]
        public String Code { get; set; }

        [JsonPropertyName("name")]
        public String Name { get; set; }
    }

    public class List
    {
        [JsonPropertyName("courses")]
        public List<Course> Courses { get; set; }
    }

    public static void ReadJson(string filepath)
    {
        try
        {
            String jsonString = File.ReadAllText(filepath);
            List list = JsonSerializer.Deserialize<List>(jsonString);
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            for(int i = 0; i < list.Courses.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {list.Courses[i].Code} - {list.Courses[i].Name}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Kegagalan Deserialisasi JSON");
        }
    }
}
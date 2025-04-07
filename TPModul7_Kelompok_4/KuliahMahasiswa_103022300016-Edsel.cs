using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TPModul7_Kelompok_4
{
    class KuliahMahasiswa_103022300016_Edsel
    {
        public class Course
        {
            [JsonPropertyName("code")] // Membaca property code pada file JSON
            public String Code { get; set; } // Getter Setter untuk code

            [JsonPropertyName("name")] // Membaca property name pada file JSON
            public String Name { get; set; } // Getter Setter untuk name
        }

        public class List
        {
            [JsonPropertyName("courses")] // Membaca property courses pada file JSON
            public List<Course> Courses { get; set; } // Getter Setter untuk courses
        }

        public static void ReadJson(string filepath)
        {
            try
            {
                String jsonString = File.ReadAllText(filepath);
                List list = JsonSerializer.Deserialize<List>(jsonString);
                foreach (var course in list.Courses)
                {
                    Console.WriteLine($"Code: {course.Code}, Name: {course.Name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kegagalan Deserialisasi JSON");
            }
        }
    }
}

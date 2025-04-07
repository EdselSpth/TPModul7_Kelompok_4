using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TPModul7_Kelompok_4
{
    class KuliahMahasiswa_103022300092_Abdul
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
        public static void ReadJson(string filePath)
        {
            try
            {
                String jsonString = File.ReadAllText(filePath);
                List list = JsonSerializer.Deserialize<List>(jsonString);
                foreach (var course in list.Courses)
                {
                    Console.WriteLine($"Code:{course.Code}, Nama: {course.Name}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi kegagalan Deserialisasi: " + e.Message);
            }
        }
    }
}

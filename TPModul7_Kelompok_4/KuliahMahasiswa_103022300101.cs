using System;
using System.Collections.Generic; // Buat pake List<T>
using System.Linq;
using System.Text;
using System.Text.Json; // Buat deserialisasi JSON
using System.Text.Json.Serialization; // Buat mapping nama properti JSON
using System.Threading.Tasks;

namespace TPModul7_Kelompok_4
{
    class KuliahMahasiswa_103022300101
    {
        // Kelas untuk struktur data course di JSON
        public class Course
        {
            [JsonPropertyName("code")] // Mapping ke JSON "code"
            public String Code { get; set; }

            [JsonPropertyName("name")] // Mapping ke JSON "name"
            public String Name { get; set; }
        }

        // Kelas pembungkus list course dari JSON
        public class List
        {
            [JsonPropertyName("courses")] // Mapping ke JSON "courses" yang isinya array objek Course
            public List<Course> Courses { get; set; }
        }

        // Method buat baca JSON dan deserialisasi ke objek List
        public static void ReadJson(string filepath)
        {
            try
            {
                String jsonString = File.ReadAllText(filepath); // Baca isi file JSON
                List list = JsonSerializer.Deserialize<List>(jsonString); // Ubah JSON jadi objek List

                // Tampilkan semua data course yang ada
                foreach (var course in list.Courses)
                {
                    Console.WriteLine($"Code: {course.Code}, Name: {course.Name}");
                }
            }
            catch (Exception ex)
            {
                // Handle error saat proses deserialisasi
                Console.WriteLine("Kegagalan Deserialisasi JSON");
            }
        }
    }
}

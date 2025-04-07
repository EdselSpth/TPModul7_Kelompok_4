using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TPModul7_Kelompok_4
{
    class DataMahasiswa_103022300016_Edsel
    {
        public class Nama
        {
            [JsonPropertyName("depan")]

            public String Depan {  get; set; }

            [JsonPropertyName("belakang")]

            public String Belakang { get; set; }
        }

        public class Mahasiswa
        {
            [JsonPropertyName("nama")]

            public Nama Nama { get; set; }

            [JsonPropertyName("nim")]
            public String NIM { get; set; }

            [JsonPropertyName("fakultas")]
            public String Fakultas { get; set; }
        }

        public static void ReadJSON(string filepath)
        {
            try
            {
                String jsonString = File.ReadAllText(filepath); 
                Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

                Console.WriteLine($"Nama {mhs.Nama.Depan} {mhs.Nama.Belakang} dengan nim {mhs.NIM} dari fakultas {mhs.Fakultas}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kegagalan Deserialisasi JSON");
            }
        }

        
    }
}

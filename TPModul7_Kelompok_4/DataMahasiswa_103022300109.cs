using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace TPModul7_Kelompok_4
{
    class DataMahasiswa_103022300109
    {
        public class Nama
        {
            [JsonPropertyName("depan")]
            public string namaDepan { get; set; }

            [JsonPropertyName("belakang")]
            public string namaBelakang { get; set; }
        }

        public class Mahasiswa
        {
            [JsonPropertyName("nama")]
            public Nama Nama { get; set; }

            [JsonPropertyName("nim")]
            public string Nim { get; set; }

            [JsonPropertyName("fakultas")]
            public string Fakultas { get; set; }
        }

        public static void ReadJSON(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

                Console.WriteLine($"Nama {mhs.Nama.namaDepan} {mhs.Nama.namaBelakang} dengan nim {mhs.Nim} dari fakultas {mhs.Fakultas}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat deserialisasi: " + ex.Message);
            }
        }
    }
}

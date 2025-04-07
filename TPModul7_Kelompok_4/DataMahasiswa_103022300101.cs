using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DataMahasiswa103022300088
{
    public class Nama
    {
        [JsonPropertyName("depan")]
        public string Depan { get; set; }

        [JsonPropertyName("belakang")]
        public string Belakang { get; set; }
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

            Console.WriteLine($"Nama {mhs.Nama.Depan} {mhs.Nama.Belakang} dengan nim {mhs.Nim} dari fakultas {mhs.Fakultas}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Terjadi kesalahan saat deserialisasi: " + ex.Message);
        }
    }
}
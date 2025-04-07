using System;
using System.IO; // Buat baca file
using System.Text.Json; // Buat deserialisasi JSON
using System.Text.Json.Serialization; // Buat kasih nama properti JSON

public class DataMahasiswa103022300101
{
    // Kelas buat struktur "nama" di JSON
    public class Nama
    {
        [JsonPropertyName("depan")] // Mapping properti JSON "depan"
        public string Depan { get; set; }

        [JsonPropertyName("belakang")] // Mapping properti JSON "belakang"
        public string Belakang { get; set; }
    }

    // Kelas utama mahasiswa
    public class Mahasiswa
    {
        [JsonPropertyName("nama")] // Properti "nama" di JSON yang berupa objek Nama
        public Nama Nama { get; set; }

        [JsonPropertyName("nim")] // Mapping ke JSON "nim"
        public string Nim { get; set; }

        [JsonPropertyName("fakultas")] // Mapping ke JSON "fakultas"
        public string Fakultas { get; set; }
    }

    // Method buat baca file JSON dan deserialisasi ke objek Mahasiswa
    public static void ReadJSON(string filePath)
    {
        try
        {
            string jsonString = File.ReadAllText(filePath); // Baca semua isi file JSON
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString); // Ubah JSON jadi objek Mahasiswa

            // Tampilkan hasil deserialisasi ke console
            Console.WriteLine($"Nama {mhs.Nama.Depan} {mhs.Nama.Belakang} dengan nim {mhs.Nim} dari fakultas {mhs.Fakultas}");
        }
        catch (Exception ex)
        {
            // Tampilkan pesan error kalau deserialisasi gagal
            Console.WriteLine("Terjadi kesalahan saat deserialisasi: " + ex.Message);
        }
    }
}

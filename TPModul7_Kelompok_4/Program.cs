using System;
using TPModul7_Kelompok_4; // Import namespace yang isinya class DataMahasiswa dan KuliahMahasiswa

class program
{
    static void Main(string[] args)
    {
        // Panggil method ReadJSON dari class DataMahasiswa buat baca file JSON mahasiswa
        DataMahasiswa103022300101.ReadJSON(@"D:\telkom\coding\C#\tpmodul7\TPModul7_Kelompok_4\tp7_1_103022300101.json");

        Console.WriteLine(" "); // Biar ada jarak/pemisah di output console

        // Panggil method ReadJson dari class KuliahMahasiswa buat baca file JSON course mata kuliah
        KuliahMahasiswa_103022300101.ReadJson(@"D:\telkom\coding\C#\tpmodul7\TPModul7_Kelompok_4\tp7_2_103022300101.json");
    }
}

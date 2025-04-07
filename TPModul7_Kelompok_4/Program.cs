using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModul7_Kelompok_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Data Milik Edsel Septa Haryanto 103022300016");
            DataMahasiswa_103022300016_Edsel.ReadJSON(@"C:\\Users\\rions\\Documents\\Kuliah\\Konstruksi Perangkat Lunak\\Praktikum\\Modul 7\\TPModul7_Kelompok_4\\TPModul7_Kelompok_4\TP7_1_103022300016.json");
            KuliahMahasiswa_103022300016_Edsel.ReadJson(@"C:\\Users\\rions\\Documents\\Kuliah\\Konstruksi Perangkat Lunak\\Praktikum\\Modul 7\\TPModul7_Kelompok_4\\TPModul7_Kelompok_4\TP7_2_103022300016.json");
            DataMahasiswa_103022300092_Abdul.ReadJSON(@"C:\Users\ABD AZIZ\Source\Repos\TPModul7_Kelompok_4\TPModul7_Kelompok_4\tp7_1_103022300092.json");
            Console.WriteLine("");
            KuliahMahasiswa_103022300092_Abdul.ReadJson(@"C:\Users\ABD AZIZ\Source\Repos\TPModul7_Kelompok_4\TPModul7_Kelompok_4\tp7_2_103022300092.json");
            // Panggil method ReadJSON dari class DataMahasiswa buat baca file JSON mahasiswa
            DataMahasiswa103022300101.ReadJSON(@"D:\telkom\coding\C#\tpmodul7\TPModul7_Kelompok_4\tp7_1_103022300101.json");

            Console.WriteLine(" "); // Biar ada jarak/pemisah di output console

            // Panggil method ReadJson dari class KuliahMahasiswa buat baca file JSON course mata kuliah
            KuliahMahasiswa_103022300101.ReadJson(@"D:\telkom\coding\C#\tpmodul7\TPModul7_Kelompok_4\tp7_2_103022300101.json");
            DataMahasiswa103022300088.ReadJSON(@"C:\Users\rakad\Downloads\tpmod7_103022300088\TPModul7_Kelompok_4\TPModul7_Kelompok_4\tp7_1_103022300088.json");
            Console.WriteLine(" ");
            KuliahMahasiswa103022300088.ReadJson(@"C:\Users\rakad\Downloads\tpmod7_103022300088\TPModul7_Kelompok_4\TPModul7_Kelompok_4\tp7_2_103022300088.json");
            DataMahasiswa_103022300109.ReadJSON(@"C:\Users\rezai\source\repos\EdselSpth\TPModul7_Kelompok_4\TPModul7_Kelompok_4\tp_1_103022300109.json");
            Console.WriteLine(" ");
            KuliahMahasiswa_103022300109.ReadJson(@"C:\Users\rezai\source\repos\EdselSpth\TPModul7_Kelompok_4\TPModul7_Kelompok_4\tp7_2_103022300109.json");
            DataMahasiswa103022330036_Funny.ReadJSON(@"C:\Users\Haikal Cannavaro\source\repos\TPModul7_Kelompok_4\TPModul7_Kelompok_4\tp7_1_103022330036.json");
            Console.WriteLine(" ");
            KuliahMahasiswa103022330036_TioFunnyTinambunan.ReadJson(@"C:\Users\Haikal Cannavaro\source\repos\TPModul7_Kelompok_4\TPModul7_Kelompok_4\tp7_2_103022330036.json");
        }
    }
}


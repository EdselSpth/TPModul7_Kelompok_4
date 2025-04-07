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

        }
    }
}


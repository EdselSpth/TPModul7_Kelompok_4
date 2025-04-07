using System;
using TPModul7_Kelompok_4;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa_103022300092_Abdul.ReadJSON(@"C:\Users\ABD AZIZ\Source\Repos\TPModul7_Kelompok_4\TPModul7_Kelompok_4\tp7_1_103022300092.json");
        Console.WriteLine("");
        KuliahMahasiswa_103022300092_Abdul.ReadJson(@"C:\Users\ABD AZIZ\Source\Repos\TPModul7_Kelompok_4\TPModul7_Kelompok_4\tp7_2_103022300092.json");

    }
}
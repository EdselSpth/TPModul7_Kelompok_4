using System;
using TPModul7_Kelompok_4;

class program
{
    static void Main(string[] args)
    {
        DataMahasiswa103022330036_Funny.ReadJSON(@"C:\Users\Haikal Cannavaro\source\repos\TPModul7_Kelompok_4\TPModul7_Kelompok_4\tp7_1_103022330036.json");
        Console.WriteLine(" ");
        KuliahMahasiswa103022330036_TioFunnyTinambunan.ReadJson(@"C:\Users\Haikal Cannavaro\source\repos\TPModul7_Kelompok_4\TPModul7_Kelompok_4\tp7_2_103022330036.json");
    }
}
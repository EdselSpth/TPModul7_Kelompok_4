using System;
using TPModul7_Kelompok_4;

class program
{
    static void Main(string[] args)
    {
        DataMahasiswa103022300101.ReadJSON(@"D:\telkom\coding\C#\tpmodul7\TPModul7_Kelompok_4\tp7_1_103022300101.json");
        Console.WriteLine(" ");
        KuliahMahasiswa_103022300101.ReadJson(@"D:\telkom\coding\C#\tpmodul7\TPModul7_Kelompok_4\tp7_2_103022300101.json");
    }
}
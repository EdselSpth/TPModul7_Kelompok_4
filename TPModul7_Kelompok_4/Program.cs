using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModul7_Kelompok_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_103022300109.ReadJSON(@"C:\Users\rezai\source\repos\EdselSpth\TPModul7_Kelompok_4\TPModul7_Kelompok_4\tp_1_103022300109.json");
            Console.WriteLine(" ");
            KuliahMahasiswa_103022300109.ReadJson(@"C:\Users\rezai\source\repos\EdselSpth\TPModul7_Kelompok_4\TPModul7_Kelompok_4\tp7_2_103022300109.json");
        }
    }
}

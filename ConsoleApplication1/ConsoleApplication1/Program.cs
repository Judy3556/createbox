using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace createbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // 问个好
            Console.WriteLine();
            Console.WriteLine(" 歡迎您使用本文件夾創建器");
            Console.WriteLine(" ");

            // 確定建立文件夾的數量
            Console.WriteLine(" 請問您要建立幾個文件夾？");
            int Count = int.Parse(Console.ReadLine());

            // 創建多個文件夾
            for (int i = 0; i < Count; i++)
            {
                int j = i + 1;
                Console.WriteLine(" ——————————————————————");
                // 定义文件夹位子
                string dirPath = @"C:\NewWork"+"("+j+")";

                // 如果文件夹存在，销毁文件夹
                if (Directory.Exists(dirPath))
                {
                    Console.WriteLine(" The directory {0} already exists.", dirPath);
                }

                // 如果文件夹不存在，建立新文件夹
                else
                {
                    Directory.CreateDirectory(dirPath);
                    Console.WriteLine(" The directory {0} was created.", dirPath);
                }
            }

            Console.WriteLine(" ——————————————————————");
            Console.WriteLine(" 感謝您的使用！");
            Console.ReadKey();
        }
    }
}
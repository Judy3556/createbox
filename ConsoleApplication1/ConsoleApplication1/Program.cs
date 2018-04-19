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
            //问个好
            Console.WriteLine("hello");

            //定义文件夹位子
            string dirPath = @"C:\47";

            //如果文件夹存在，销毁文件夹
            if (Directory.Exists(dirPath))
            {
                Console.WriteLine("The directory {0} already exists.", dirPath);
            }

            //如果文件夹不存在，建立新文件夹
            else
            {
                Directory.CreateDirectory(dirPath);
                Console.WriteLine("The directory {0} was created.", dirPath);
            }


            Console.Read();
        }
    }
}
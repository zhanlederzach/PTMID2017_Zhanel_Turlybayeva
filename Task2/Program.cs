using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            List<FileSystemInfo> list = new List<FileSystemInfo>();
            var d = new DirectoryInfo(@"C:\Users\Admin\Source\Repos");
            list.AddRange(d.GetFiles());
            */

            string path = @"C:\Users\Admin\Source\Repos\";

            List<FileSystemInfo> list = new List<FileSystemInfo>();

            DirectoryInfo dir = new DirectoryInfo(path);

            list.AddRange(dir.GetFiles());

            for (int j = 0; j < list.Count; ++j)
            {
                //string path2 = Path.GetTempFileName(); 

                FileStream fs = new FileStream(String.Format("{0}{1}.txt", path, list[j]), FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                fs.Close();
                sr.Close();
                string str = sr.ReadToEnd();
                //string[] str2 = str.Split(' ');

                for (int i = 0; i < str.Length; ++i)
                {
                    if (str[i]=='a' && str[i+1]=='b' && str[i + 2] == 'c' && str[i + 3] == 'd')
                    {
                        Console.WriteLine(list[j]);
                    }
                }
                                
                //string abc =Array.Find(str2, element => element.StartsWith("abc"), StringComparison.Ordinal))
                //Console.WriteLine(di.Name);
                //Console.Writeline(abc);
            }
            Console.ReadLine();
        }
    }
}

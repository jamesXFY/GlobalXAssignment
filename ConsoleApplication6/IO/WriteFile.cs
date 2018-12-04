using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication6.IO
{
    class WriteFile
    {
        public void WriteFileByLine(string path, string[] names) {
            try
            {
                if (!File.Exists(path))
                {
                    //File.Create(path);
                    TextWriter tw = new StreamWriter(path);
                    for (int idx = 0; idx < names.Length; idx++) {
                        tw.WriteLine(names[idx]);
                    }
                    
                    tw.Close();
                }
                else if (File.Exists(path))
                {
                    TextWriter tw = new StreamWriter(path, false);
                    for (int idx = 0; idx < names.Length; idx++)
                    {
                        tw.WriteLine(names[idx]);
                    }
                    tw.Close();
                }
            }
            catch (Exception e) {
                Console.WriteLine("write File Error");
            }
        }
    }
}

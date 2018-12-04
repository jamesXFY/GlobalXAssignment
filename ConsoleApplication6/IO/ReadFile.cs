using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.IO
{
    class ReadFile
    {
        public List<string> readFileByLine(string path) {
            List<string> names = new List<string>();
            try
            {
                string name = "";
                // Read the file and display it line by line.  
                System.IO.StreamReader file =
                    new System.IO.StreamReader(path);
                name = file.ReadLine();
                while (name != null && name.Trim() != "")
                {
                    names.Add(name.Trim());
                    name = file.ReadLine();
                }
                file.Close();
            }
            catch (Exception e) {
                Console.WriteLine("Read File Error");
            }
            
            return names;
        }
    }
}

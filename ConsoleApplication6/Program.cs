using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

using ConsoleApplication6.IO;
using ConsoleApplication6.Logic;
using ConsoleApplication6.OB;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile read = new ReadFile();
            var readPath = Path.Combine(Directory.GetCurrentDirectory(), "test.txt");
            var writePath = Path.Combine(Directory.GetCurrentDirectory(), "test1.txt");
            List<string> names = read.readFileByLine(readPath);
            SortPerson sortPersons = new SortPerson();
            List<Person> sortedPersons = sortPersons.transAndSort(names);
            string[] sortedNames = new string[sortedPersons.Count];
            for (int idx = 0; idx < sortedPersons.Count; idx++) {
                //Console.WriteLine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                Console.WriteLine(Person.transPersonToStr(sortedPersons.ElementAt(idx)));
                sortedNames[idx] = Person.transPersonToStr(sortedPersons.ElementAt(idx));
            }
            WriteFile write = new WriteFile();
            write.WriteFileByLine(writePath, sortedNames);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.OB
{
    public class Person
    {
        public string[] firstNames;
        public string lastName;
        public int heat;

        public static Person transStrToPerson(string name) {
            Person person = new Person();
            string[] subNames = name.Split(' ');
            int subNamesLen = subNames.Length;
            if (subNamesLen > 1)
            {
                person.firstNames = new string[subNames.Length - 1];
                Array.Copy(subNames, 0, person.firstNames, 0, subNames.Length - 1);
            }
            else
            {
                person.firstNames = null;
            }

            if (subNamesLen > 0)
            {
                person.lastName = subNames[subNames.Length - 1];
            }
            else
            {
                person.lastName = null;
            }
            
            return person; 
        }
        public static string transPersonToStr(Person person) {
            string name = "";
            if (person.firstNames.Length > 0) {
                for (int idx = 0; idx < person.firstNames.Length; idx++) {
                    name = name + person.firstNames[idx] + " ";
                }
            }

            name = name + person.lastName;
            return name;
        }
    }
}

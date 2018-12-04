using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.OB;

namespace ConsoleApplication6.Logic
{
    public class SortPerson
    {
        List<Person> orderedPersons = new List<Person>();
        public List<Person> transAndSort(List<string> names) {
            foreach (string name in names) {
               Person person = Person.transStrToPerson(name);
                if (orderedPersons.Count == 0)
                {
                    orderedPersons.Add(person);
                }
                else
                {
                    int insertIdx = orderedPersons.Count;
                    for (int idx = 0; idx < orderedPersons.Count; idx++) {
                        Person personBeCompared = orderedPersons.ElementAt(idx);
                        Compare compare = new Compare();
                        int heat = compare.comparePersons(person, personBeCompared);
                        if (heat <= 0) {
                            // replace 
                            insertIdx = idx;                            
                            break;
                        }
                    }

                    if (insertIdx == orderedPersons.Count)
                    {
                        orderedPersons.Add(person);
                    }
                    else
                    {
                        orderedPersons.Insert(insertIdx, person);
                    }
                }
               
            }
            return orderedPersons;
        }
    }
}

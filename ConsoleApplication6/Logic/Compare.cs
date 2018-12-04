using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.OB;

namespace ConsoleApplication6.Logic
{
    public class Compare
    {
        public int comparePersons(Person personF, Person personS) {

            int heat = string.Compare(personF.lastName, personS.lastName, StringComparison.Ordinal);
            if (heat == 0) {
                int personFlen = personF.firstNames.Length;
                int personSlen = personS.firstNames.Length;

                if (personFlen >= personSlen) {
                    for (int idx = 0; idx < personSlen; idx++) {
                        string subName1 = personS.firstNames[idx];
                        heat= string.Compare(personF.firstNames[idx], personS.firstNames[idx], StringComparison.Ordinal);
                        if (heat != 0) {
                            break;
                        } else if (idx== personSlen-1) {
                            heat = 1;
                        }
                        /**
                         * need to consider something here
                         * */
                    }
                }
            }
            return heat;
        }

    }
}

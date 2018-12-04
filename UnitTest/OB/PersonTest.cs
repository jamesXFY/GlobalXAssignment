using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication6.OB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OB
{
    [TestClass()]
    public class PersonTest
    {
        [TestMethod()]
        public void transStrToPerson()
        {
            // Frankie Conner Ritter
            Person person = Person.transStrToPerson("Frankie Conner Ritter");

            Assert.AreEqual(person.lastName, "Ritter");
            Assert.AreEqual(person.firstNames[0], "Frankie");
            Assert.AreEqual(person.firstNames[1], "Conner");
            

        }
    }
}
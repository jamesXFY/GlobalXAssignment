using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication6.Logic;
using ConsoleApplication6.OB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    [TestClass()]
    public class SortPersonTests
    {
        [TestMethod()]
        public void transAndSortTest()
        {
            var names = new List<string> { "Janet Parsons","Vaughn Lewis","Adonis Julius Archer","Shelby Nathan Yoder","Marin Alvarez","London Lindsey","Beau Tristan Bentley","Leo Gardner","Hunter Uriah Mathew Clarke","Mikayla Lopez","Frankie Conner Ritter"};
            SortPerson sort = new SortPerson();
            List<Person> sortedPersons = sort.transAndSort(names);
            // check ordered person first name
            Assert.AreEqual(sortedPersons[0].lastName, "Alvarez");
            Assert.AreEqual(sortedPersons[1].lastName, "Archer");
            Assert.AreEqual(sortedPersons[2].lastName, "Bentley");
            Assert.AreEqual(sortedPersons[3].lastName, "Clarke");
            Assert.AreEqual(sortedPersons[4].lastName, "Gardner");
            Assert.AreEqual(sortedPersons[5].lastName, "Lewis");
            Assert.AreEqual(sortedPersons[6].lastName, "Lindsey");
            Assert.AreEqual(sortedPersons[7].lastName, "Lopez");
            Assert.AreEqual(sortedPersons[8].lastName, "Parsons");
            Assert.AreEqual(sortedPersons[9].lastName, "Ritter");
            Assert.AreEqual(sortedPersons[10].lastName, "Yoder");

            names.Clear();
            names = new List<string>();
            names.Add("Janet Yoder");
            names.Add("Vaughn Yoder");
            names.Add("Adonis Julius Yoder");
            names.Add("Shelby Nathan Yoder");
            sortedPersons.Clear();
            sortedPersons = sort.transAndSort(names);
            Assert.AreEqual(sortedPersons[0].firstNames[0], "Adonis");
            Assert.AreEqual(sortedPersons[1].firstNames[0], "Janet");
            Assert.AreEqual(sortedPersons[2].firstNames[0], "Shelby");
            Assert.AreEqual(sortedPersons[3].firstNames[0], "Vaughn");


        }
    }
}
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
    public class CompareTests
    {
        [TestMethod()]
        public void comparePersonsTest()
        {
            Person person1 = new Person();
            Person person2 = new Person();
            //Beau Tristan Bentley
            person1.firstNames = new string[] {"Beau", "Tristan"};
            person1.lastName = "Bentley";
            //Hunter Uriah Mathew Clarke
            person2.firstNames = new string[] { "Hunter", "Uriah" , "Mathew"};
            person2.lastName = "Clarke";

            Compare compare = new Compare();
            int heat = compare.comparePersons(person1,person2);
            Assert.IsTrue(heat<0);

            //Beau Tristan Bentley
            person1.firstNames = new string[] { "Beau", "Tristan" };
            person1.lastName = "Bentley";
            //Hunter Uriah Mathew Bentley
            person2.firstNames = new string[] { "Hunter", "Uriah", "Mathew" };
            person2.lastName = "Bentley";

            heat = compare.comparePersons(person1, person2);
            Assert.IsTrue(heat == 0);

            //Beau Tristan Bentley
            person1.firstNames = new string[] { "Beau", "Tristan" };
            person1.lastName = "Bentley";
            //Beau Bentley
            person2.firstNames = new string[] { "Beau"};
            person2.lastName = "Bentley";

            heat = compare.comparePersons(person1, person2);
            Assert.IsTrue(heat > 0);
        }
    }
}
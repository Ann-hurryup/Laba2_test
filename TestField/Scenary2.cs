using Microsoft.VisualStudio.TestTools.UnitTesting;
using lr2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2.Tests
{
    [TestClass]
    public class Scenary2
    {
        [TestMethod]

        public void TestScenary2()
        {
            var engineer = new Engineer("Михаил Носков", Engineer.WorkType.Drill, new Well(0001, false), new Field());
            var chemist = new Chemist("Петр Петров", Chemist.WorkTypeCh.Analyze);
            var field = new Field();
            var transport = new Transport(0001);
            var well = new Well(0001, false);
            field.NotDrillField();
           

        }
    }
}

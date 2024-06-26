﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2.Tests
{
    [TestClass]
    public class Scenary1
    {
        [TestMethod]

        public void TestScenary1()
        {
            var engineer = new Engineer("Михаил Носков", Engineer.WorkType.Drill, new Well(0001, true), new Field());
            var chemist = new Chemist("Петр Петров", Chemist.WorkTypeCh.Analyze);
            var field = new Field();
            var transport = new Transport(0001);
            var well = new Well(0001, true);
            field.DrillField();
            well.ExtractWell();
            engineer.DrillField(field);
            engineer.ExtractWell(well);
            transport.Trans();
            chemist.Analyze();


        }
    }
}

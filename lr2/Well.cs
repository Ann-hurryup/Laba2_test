using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    public class Well 
    {
        public int IdWell { get; set; }
        public bool IsExtract { get; set; }


        public void Extract()
        {
            IsExtract = true;
            Console.WriteLine("Extracting from the well...");
        }

        public void NotExtract()
        {
            IsExtract = false;
            Console.WriteLine("Not extracting from the well.");
        }
    }
}

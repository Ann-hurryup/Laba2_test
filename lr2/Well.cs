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


        public void ExtractWell()
        {
            IsExtract = true;
            Console.WriteLine("Происходит добыча из скважины");
        }

        public void NotExtractWell()
        {
            IsExtract = false;
            Console.WriteLine("Процесс добычи отсутствует");
        }
    }
}

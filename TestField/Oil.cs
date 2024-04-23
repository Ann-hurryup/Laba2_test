using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    public class Oil
    {
        public Chemist Chemist { get; set; }
        public Transport Transport { get; set; }
        public bool IsOilTest { get; set; }
        public bool IsOilTransport { get; set; }

        public Oil(Chemist chemist, Transport transport)
        {
            Chemist = chemist;
            Transport = transport;
        }

        public void TransportOil(Transport transport)
        {
            IsOilTransport = true;
            Console.WriteLine($"Нефть транспортируется с помощью {transport.IdTransport}");
        }

        public void NotTransportOil(Transport transport)
        {
            IsOilTransport = false;
            Console.WriteLine("Нефть не транспортируется");
        }

        public void AnalyseOil(Chemist chemist)
        {
            IsOilTest = true;
            Console.WriteLine($"Нефть анализируется химиком {chemist.FullNameCh}");
        }

        public void NotAnalyseOil(Chemist chemist)
        {
            IsOilTest = false;
            Console.WriteLine("Нефть не анализируется");
        }
    }
}

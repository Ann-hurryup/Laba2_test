using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    public class Gas
    {
        public Chemist Chemist { get; set; }
        public Transport Transport { get; set; }
        public bool IsGasAnalyze { get; set; }
        public bool IsGasTrancport { get; set; }

        public Gas(Chemist chemist, Transport transport)
        {
            Chemist = chemist;
            Transport = transport;
        }

        public void TransportGas(Transport transport)
        {
            IsGasTrancport = true;
            Console.WriteLine($"Газ транспортируется с помощью {transport.IdTransport}");
        }
        public void NotTransportGas(Transport transport)
        {
            IsGasTrancport = false;
            Console.WriteLine("Газ не транспортируется");
        }
        // Метод для анализа газа с указанием проводящего анализ химика
        public void AnalyseGas(Chemist chemist)
        {
            IsGasAnalyze = true;
            Console.WriteLine($"Газ анализируется химиком {chemist.FullNameCh}");
        }

        public void NotAnalyseGas(Chemist chemist)
        {
            IsGasAnalyze = false;
            Console.WriteLine("Газ не анализируется");
        }
    }

}
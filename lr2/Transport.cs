using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    public class Transport
    {
        public int IdTransport { get; set; }
        public bool IsTransporting { get; set; }

        public Transport(int idTransport)
        {
            IdTransport = idTransport;
            IsTransporting = false; // Изначально транспорт не в пути
        }

        public void Trans()
        {
            IsTransporting = true;
            Console.WriteLine("Ресурсы транспортируются ");
        }

        public void NotTran()
        {
            IsTransporting = false;
            Console.WriteLine("Ресурсы не транспортируются ");
        }
    }

}

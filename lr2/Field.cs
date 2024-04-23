using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace lr2;

public class Field
{
    public int IdField { get; set; }
    public bool IsDrill { get; set; }

   
    public void DrillField()
    {
        IsDrill = true;
        Console.WriteLine("Происходит бурение...");
    }

    public void NotDrillField()
    {
        IsDrill = false;
        Console.WriteLine("Бурение НЕ происходит");
    }
    
}




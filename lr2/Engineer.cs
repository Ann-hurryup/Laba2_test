using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    public class Engineer
    {
        public string FullName { get; set; }
        public WorkType CurrentWork { get; set; }

        // Перечисление для типов работы
        public enum WorkType
        {
            Drill,
            Extract,
            Control
        }

        public Engineer(string fullName, WorkType currentWork)
        {
            FullName = fullName;
            CurrentWork = currentWork;
        }

        public void DrillWell()
        {
            Console.WriteLine($"{FullName} is drilling a well.");
            CurrentWork = WorkType.Drill;
        }

        public void Extract()
        {
            Console.WriteLine($"{FullName} is extracting resources.");
            CurrentWork = WorkType.Extract;
        }

        public void Control ()
        {
            Console.WriteLine($"{FullName} is supervising the process.");
            CurrentWork = WorkType.Control;
        }
    }

}

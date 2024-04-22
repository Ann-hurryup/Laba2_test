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
        public Well  Well{ get; set; }
        public Field Field { get; set; }

        public bool IsEngWell{  get; set; }
        public bool IsEngDrill { get; set; }

        // Перечисление для типов работы
        public enum WorkType
        {
            Drill,
            Extract
        }

        public Engineer(string fullName, WorkType currentWork, Well well, Field field)
        {
            FullName = fullName;
            CurrentWork = currentWork;
            Well = well;
            Field = field;
        }

        public void DrillField(Field field)
        {
            IsEngDrill = true;
            Console.WriteLine($" Инженер {FullName} бурит месторождение {field.IdField}");
            CurrentWork = WorkType.Drill;
        }

        public void ExtractWell(Well well)
        {
            IsEngWell = true;
            Console.WriteLine($"Инженер {FullName} добывает из скважины {well.IdWell}");
            CurrentWork = WorkType.Extract;
        }

        public void NotDrillField()
        {
            IsEngDrill = false;
            Console.WriteLine($" Инженер {FullName} не бурит месторождение");
        }

        public void NotExtractWell(Well well)
        {
            IsEngWell = false;
            Console.WriteLine($"Инженер {FullName} не добывает из скважины");
        }


    }

}

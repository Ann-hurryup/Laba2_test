using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    
        public class Chemist
        {
            public string FullNameCh { get; set; }
            public WorkTypeCh CurrentWorkCh { get; set; }
            public bool IsAnalyze { get; set; }

        // Enum для типов работы химика
        public enum WorkTypeCh
            {
                Analyze,
                QAReport
            }

            public Chemist(string fullNameCh, WorkTypeCh currentWorkCh)
            {
                FullNameCh = fullNameCh;
                CurrentWorkCh = currentWorkCh;
            }

            public void Analyze()
            {
                 IsAnalyze = true;
                Console.WriteLine($"Химик {FullNameCh} проводит анализ");
                CurrentWorkCh = WorkTypeCh.Analyze;
            }

            public void QAReport()
            {
                IsAnalyze = false;
                Console.WriteLine($"Химик {FullNameCh} делает отчет по качеству");
                CurrentWorkCh = WorkTypeCh.QAReport;
            }
        }
    }



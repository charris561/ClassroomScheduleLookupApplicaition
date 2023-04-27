using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Lookup_UI
{
    public class Constants
    {
        public const string InputFile = "ClassScheduleData.csv";
        public static readonly string[] ValidBuildings = { "ACAD", "BREC", "B204", "CENT", "COLU", "CUCH", "CYBR", "DWTN", "DWIR", "ECFA", "ECSS", "ELPC", "ENGR", "FINE", "HSMP", "LANE", "OCSE", "UHAL"};
        public static readonly DayOfWeek[] ExistingWeekdays = { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday};
    }
}

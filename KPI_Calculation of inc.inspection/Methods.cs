using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using wf = System.Windows.Forms;
using xl = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace KPI_Calculation_of_inc.inspection
{
    public static class Methods
    {
        public static void findInspectors(DataGridView InPutDataFridView, ListBox OutResults)
        {
            OutResults.Items.Clear();
            ArrayList checkers = new ArrayList();
            string[] _movementsOfInspections = new string[] { "321", "350" };

            foreach (string item in _movementsOfInspections)
            {
                for (int i = 0; i < InPutDataFridView.Rows.Count - 1; i++)//останній рядок не опрацьовуємо, так як там пустота
                {
                    if (InPutDataFridView.Rows[i].Cells[6].Value.ToString() == item) //опрацьовуємо тільки позиції де рух 321 або 350
                    {
                        bool IsAlreadyExist = checkers.Contains(InPutDataFridView.Rows[i].Cells[7].Value.ToString());
                        if (!IsAlreadyExist)
                        {
                            checkers.Add(InPutDataFridView.Rows[i].Cells[7].Value.ToString());
                        }
                    }
                }
            }

            for (int r = 0; r < checkers.Count; r++)
            {
                OutResults.Items.Add(checkers[r].ToString());
            }
        }
        public static DateTime CreateCorrectDate(string IncomeDate, string IncomeTime)
        {
            DateTime _result;

            int _CorrectHourCH = 0; // змінна для правильного підрахунку годин
            int _CorrectMinuteCH = 0; // змінна для правильного підрахунку хвилин
            int _CorrectSecondCH = 0; // змінна для правильного підрахунку секунд
            if ((int)IncomeTime.Length == 8) // Якщо час має формат 23:47:13, то довжина 8 символів
            {
                _CorrectHourCH = Convert.ToInt32(IncomeTime.Substring(0, 2));
                _CorrectMinuteCH = Convert.ToInt32(IncomeTime.Substring(3, 2));
                _CorrectSecondCH = Convert.ToInt32(IncomeTime.Substring(6, 2));
            }
            if ((int)IncomeTime.Length == 7)// Якщо час має формат 1:34:58, то довжина 7 символів
            {
                _CorrectHourCH = Convert.ToInt32(IncomeTime.Substring(0, 1));
                _CorrectMinuteCH = Convert.ToInt32(IncomeTime.Substring(2, 2));
                _CorrectSecondCH = Convert.ToInt32(IncomeTime.Substring(5, 2));
            }

            _result = new DateTime(
               Convert.ToInt32(IncomeDate.Substring(6, 4)),
               Convert.ToInt32(IncomeDate.Substring(3, 2)),
               Convert.ToInt32(IncomeDate.Substring(0, 2)),
               _CorrectHourCH,
               _CorrectMinuteCH,
               _CorrectSecondCH);

            return _result;
        }
        public static DateTime AddToDateHolidaysAndWeekends(DateTime startDate, int QtyOfHolidaysExceptWeekends)
        {
            DateTime _result;

            if (startDate.DayOfWeek.ToString() == "Friday")
            {
                _result = startDate.AddDays(QtyOfHolidaysExceptWeekends + 3);//змінна з датою оприбуткування з доданими вихідними днями, якщо є
            }
            else if (startDate.DayOfWeek.ToString() == "Saturday")
            {
                _result = startDate.AddDays(QtyOfHolidaysExceptWeekends + 2);//змінна з доданими вихідними днями, якщо є
            }
            else if (startDate.AddDays(QtyOfHolidaysExceptWeekends).DayOfWeek.ToString() == "Friday")// Коли святковий день припадає на п'ятницю.
            {
                _result = startDate.AddDays(QtyOfHolidaysExceptWeekends + 3);//змінна з доданими вихідними днями, якщо є
            }
            else
            {
                _result = startDate.AddDays(QtyOfHolidaysExceptWeekends);//змінна з доданими вихідними днями, якщо є
            }
            return _result;
        }
    }
}

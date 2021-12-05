using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace KPI_Calculation_of_inc.inspection
{
    class User
    {
        public string Name
        {
            get; set;
        }
        public User(string Name)
        {
            this.Name = Name;
        }

        public string quantityOf_Total_checks;
        public int quantityOf_NOK_checks { get; set; }
        public int percentageOf_NOK_checks { get; set; }

        public static List<OverDue_Inspection> _listOf_OverDueInspections = new List<OverDue_Inspection>();

        List<string> _movementTypesOf_Check = new List<string> { "321", "350" };
        string _movementTypeOf_Income = "101";

        string _nameOfColumn_user = "User Name";
        string _nameOfColumn_movementType = "Movement type";
        string _nameOfColumn_dateOfMovement = "Entry Date";
        string _nameOfColumn_article = "Material";
        string _nameOfColumn_quantity = "Qty in unit of entry";
        string _nameOfColumn_name = "Material Description";
        string _nameOfColumn_batch = "Batch";
        string _nameOfColumn_timeOfMovement = "TimeOfEntry";

        public void CalcOfTotalChecks(string SAPName, ComboBox cb_tabPageMonth, DateTimePicker dtp_tabPageMonth, DataGridView dgv_TableWithIncomeData) // метод для підрахунку загальної к-сті перевірок
        {
            int _monthForFilter = Convert.ToInt16(cb_tabPageMonth.Text.Substring(cb_tabPageMonth.Text.Length - 2, 2));//визначаємо місяць для фільтру
            int _yearForFilter = dtp_tabPageMonth.Value.Year;//визначаємо рік для фільтру
            DateTime _FullDateForFilter = new DateTime(_yearForFilter, _monthForFilter, 01);//повна дата для фільтру

            int ResultsOfTotalChecks = 0; // змінна для рахунку загальної к-сті перевірок по певному користувачу

            for (int q = 0; q <= dgv_TableWithIncomeData.Rows.Count - 2; q++)
            {
                //Визначення необхідної дати оприбуткування для підрахунків
                string _entrydateForFilter = dgv_TableWithIncomeData.Rows[q].Cells[_nameOfColumn_dateOfMovement].Value.ToString();//змінна для дати оприбуткування по циклу

                string _monthFF = _entrydateForFilter.Substring(3, 2);//змінна для відображення місяця оприбуткування з DataGridView по циклу
                if (_monthFF.Substring(0, 1) == "0") // число місяця може бути ОДНОЮ цифрою, а для порівняння потрібно ДВІ  
                {
                    _monthFF = _entrydateForFilter.Substring(4, 1);
                }

                string _yearFF = _entrydateForFilter.Substring(6, 4);//змінна для відображення року оприбуткування з DataGridView по циклу

                //Визначення необхідної дати KPI для підрахунків
                string _monthFromFullDateForFilter = _FullDateForFilter.Month.ToString();//змінна для тримання місяця
                string _yearFromFullDateForFilter = _FullDateForFilter.Year.ToString();//змінна для тримання року

                //Калькуляція
                bool _month = _monthFF == _monthFromFullDateForFilter;//Якщо місяць оприбуткування дорівнює місяцю KPI
                bool _year = _yearFF == _yearFromFullDateForFilter;//Якщо рік оприбуткування дорівнює року KPI

                if ((string)dgv_TableWithIncomeData.Rows[q].Cells[_nameOfColumn_user].Value == SAPName & _month == true & _year == true)//цикл для перебору всіх комірок з колонки “User name”.
                {
                    ResultsOfTotalChecks += 1;
                }
            }
            quantityOf_Total_checks = ResultsOfTotalChecks.ToString();
        }
        public void CalcOfNotOkChecks(string SAPNameForCalculation, ComboBox cb_tabPageMonth, DateTimePicker dtp_tabPageMonth, DataGridView dgv_TableWithIncomeData, ProgressBar progressBar, ListBox lbHolidays, DataGridView dgvForNOKChecks)
        {
            int NotOkChecks = 0;// змінна для рахування невчасних перевірок

            //Визначення необхідної дати KPI для підрахунків
            string _monthForKPI = Convert.ToInt16(cb_tabPageMonth.Text.Substring(cb_tabPageMonth.Text.Length - 2, 2)).ToString();
            string _yearForKPI = dtp_tabPageMonth.Value.Year.ToString();

            //Цей цикл для перебору кожного рядка. І якщо тип руху 321 або 350 та логін користувача співпадає в рядку, то продовжити виконання  
            for (int i = 0; i <= dgv_TableWithIncomeData.Rows.Count - 2; i++)//Цикл для перебору всіх рядків, де критерієм є рух = 321 або 350, та ім'я користувача, яке вказуємо як аргумент методу
            {
                progressBar.Value = i;

                //bool _sapName = (string)dgv_TableWithIncomeData.Rows[i].Cells["Користувач"].Value == SAPNameForCalculation;//Якщо користувач з таблиці співпадає з потрібним логіном користувача
                if ((string)dgv_TableWithIncomeData.Rows[i].Cells[$"{_nameOfColumn_user}"].Value == SAPNameForCalculation)//Якщо користувач з таблиці співпадає з потрібним логіном користувача
                {
                    string _movementTypeOfCurrentRow = Convert.ToString(dgv_TableWithIncomeData.Rows[i].Cells[$"{_nameOfColumn_movementType}"].Value);
                    bool _isMovementType_Check = _movementTypesOf_Check.Contains(_movementTypeOfCurrentRow);

                    if (_isMovementType_Check)//Якщо тип руху з рядка є рухом вхідної перевірки(321 чи 350)
                    {
                        #region CHECKED
                        string _entrydate = dgv_TableWithIncomeData.Rows[i].Cells[$"{_nameOfColumn_dateOfMovement}"].Value.ToString();//Дата оприбуткування з таблиці

                        //визначаємо дату оприбуткування по циклу для калькуляції
                        string _monthOfEntry = _entrydate.Substring(3, 2);//змінна для відображення місяця оприбуткування з DataGridView
                        if (_monthOfEntry.Substring(0, 1) == "0") // число місяця може бути ОДНОЮ цифрою(тобто починатися з нуля), а для порівняння потрібно ДВІ  
                        {
                            _monthOfEntry = _entrydate.Substring(4, 1);
                        }

                        string _yearOfEntry = _entrydate.Substring(6, 4);//змінна для відображення року з DataGridView

                        //bool _movementType321 = Convert.ToString(dgv_TableWithIncomeData.Rows[i].Cells["Тип руху"].Value) == "321";//Якщо рух 321
                        //bool _movementType350 = Convert.ToString(dgv_TableWithIncomeData.Rows[i].Cells["Тип руху"].Value) == "350";//Якщо рух 350

                        bool _IsMonthTheSame = _monthOfEntry == _monthForKPI;//Якщо місяць оприбуткування співпадає з місяцем KPI
                        bool _IsYearTheSame = _yearOfEntry == _yearForKPI;//Якщо рік оприбуткування співпадає з роком KPI

                        if (_IsMonthTheSame == true & _IsYearTheSame == true) //Якщо місяць та рік співпадають
                        {
                            string _articleCH = dgv_TableWithIncomeData.Rows[i].Cells[$"{_nameOfColumn_article}"].Value.ToString(); //створюємо змінну для теперішнього артикля в рядку по циклу
                            string _quantityCH = dgv_TableWithIncomeData.Rows[i].Cells[$"{_nameOfColumn_quantity}"].Value.ToString();//створюємо змінну для теперішньої к-сті в рядку по циклу
                            string _materialdescription = dgv_TableWithIncomeData.Rows[i].Cells[$"{_nameOfColumn_name}"].Value.ToString();
                            string _batch = dgv_TableWithIncomeData.Rows[i].Cells[$"{_nameOfColumn_batch}"].Value.ToString();
                            string _username = dgv_TableWithIncomeData.Rows[i].Cells[$"{_nameOfColumn_user}"].Value.ToString();
                            string _entrydateCH = dgv_TableWithIncomeData.Rows[i].Cells[$"{_nameOfColumn_dateOfMovement}"].Value.ToString(); //створюємо змінну для теперішнього дати в рядку по циклу
                            string _entrytimeCH = dgv_TableWithIncomeData.Rows[i].Cells[$"{_nameOfColumn_timeOfMovement}"].Value.ToString(); // інколи перевірка або оприбуткування проводиться в ночі, тобто години мають ОДНУ цифру.

                            DateTime _fullDateCH = Methods.CreateCorrectDate(_entrydateCH, _entrytimeCH);

                            bool _OneWasFound = false;
                            ArrayList arrNumbersOfRows = new ArrayList();// колекція для зберігання номерів рядів, де збігаються артикль, к-сть та 101 рух
                            arrNumbersOfRows.Clear();

                            for (int j = 0; j <= dgv_TableWithIncomeData.Rows.Count - 2; j++)// цикл для пошуку подібних рядків для i, та внесення номерів таких рядків у колекцію
                            {
                                string _articleIN = dgv_TableWithIncomeData.Rows[j].Cells[$"{_nameOfColumn_article}"].Value.ToString(); //створюємо змінну для теперішнього артикля в циклі
                                bool IsArticlesTheSame = _articleCH == _articleIN;

                                if (IsArticlesTheSame)//Якщо артиклі співпадають то заходимо
                                {
                                    string _quantityIN = dgv_TableWithIncomeData.Rows[j].Cells[$"{_nameOfColumn_quantity}"].Value.ToString();
                                    bool IsQuantityTheSame = _quantityCH == _quantityIN;

                                    if (IsQuantityTheSame)//Якщо кількості співпадають то заходимо
                                    {
                                        bool _movementType101 = Convert.ToString(dgv_TableWithIncomeData.Rows[j].Cells[$"{_nameOfColumn_movementType}"].Value) == _movementTypeOf_Income;

                                        string _entrydateIN = dgv_TableWithIncomeData.Rows[j].Cells[$"{_nameOfColumn_dateOfMovement}"].Value.ToString();
                                        string _entrytimeIN = dgv_TableWithIncomeData.Rows[j].Cells[$"{_nameOfColumn_timeOfMovement}"].Value.ToString();
                                        DateTime _fullDateIN = Methods.CreateCorrectDate(_entrydateIN, _entrytimeIN);

                                        if (_movementType101 == true) // Якщо рух 101 знаходимо в одному рядку, то вносимо дату та час оприбуткуванЬ в колекцію
                                        {
                                            arrNumbersOfRows.Add(_fullDateIN);
                                        }
                                    }
                                }
                            }

                            arrNumbersOfRows.Sort(); // спочатку робимо в алфавітному порядку від А до Я
                            arrNumbersOfRows.Reverse(); // Сортуємо колекцію від більшої дати до меншої. Це дасть нам у наступному циклі знайти найближчу дату оприбуткування

                            for (int m = 0; m < arrNumbersOfRows.Count; m++)
                            {
                                //Перевіряємо, чи ДАТА Оприбуткування елементу колекції по циклу більша за ДАТУ перевірки. Якщо ТАК, то виходимо, так як перевірка не може статися швидше, ніж оприбуткування
                                DateTime _fullDateIN = (DateTime)arrNumbersOfRows[m]; //змінній присвоюємо теперішній елемент в циклі
                                if ((DateTime)arrNumbersOfRows[m] > _fullDateCH)
                                {
                                    continue;
                                }
                                else if ((DateTime)arrNumbersOfRows[m] <= _fullDateCH) // Якщо ДАТА оприбуткування менша за ДАТА перевірки
                                {
                                    #region IfHolidays
                                    // в цьому регіоні будемо переглядати чи вплинув вихідний день на вчасність перевірки
                                    //Наприклад 07.03.19 матеріал оприбуткувався, а 09.03.19 він був опрацьований.
                                    // Тобто 2 дні опрацьовувався, але 08.03.19 був вихідний, тому потрібно один день відняти

                                    int _daysofholiday = 0;// змінна для рахування 

                                    for (int q = 0; q <= lbHolidays.Items.Count - 1; q++)
                                    {
                                        DateTime _CurrentDateFromHolidays = Convert.ToDateTime(lbHolidays.Items[q]);

                                        int _dayIN = _fullDateIN.Day;
                                        int _monthIN = _fullDateIN.Month;
                                        int _yearIN = _fullDateIN.Year;
                                        DateTime _forHolidayIN = new DateTime(_yearIN, _monthIN, _dayIN);

                                        int _dayCH = _fullDateCH.Day;
                                        int _monthCH = _fullDateCH.Month;
                                        int _yearCH = _fullDateCH.Year;
                                        DateTime _forHolidayCH = new DateTime(_yearCH, _monthCH, _dayCH);

                                        if (_forHolidayCH > _CurrentDateFromHolidays && _forHolidayIN <= _CurrentDateFromHolidays)
                                        {
                                            _daysofholiday += 1;
                                        }
                                    }
                                    #endregion

                                    int _daysFromCalculation = 0;
                                    string _calculation = null;
                                    DateTime _fullDateInWithHolidays = Methods.AddToDateHolidaysAndWeekends(_fullDateIN, _daysofholiday);

                                    if (_fullDateCH.ToShortDateString() == _fullDateInWithHolidays.ToShortDateString())
                                    {
                                        _daysFromCalculation = 0;
                                    }
                                    else
                                    {
                                        _calculation = (_fullDateCH - _fullDateInWithHolidays).ToString();
                                    }

                                    _calculation = (_fullDateCH - _fullDateInWithHolidays).ToString();

                                    if (_calculation.Length == 10)
                                    {
                                        _daysFromCalculation = Convert.ToInt16(_calculation.Substring(0, 1));
                                    }
                                    else if (_calculation.Length == 8)
                                    {
                                        _daysFromCalculation = 0;
                                    }


                                    if (_daysFromCalculation >= 1)
                                    {
                                        NotOkChecks += 1;
                                        _listOf_OverDueInspections.Add(new OverDue_Inspection(_articleCH, _quantityCH, _materialdescription, _batch, _fullDateIN, _fullDateCH));
                                        _OneWasFound = true;
                                        break;
                                    }
                                    //break;
                                }
                                if (_OneWasFound == true)
                                { break; }
                            }
                        }
                        #endregion
                    }
                }
            }
            quantityOf_NOK_checks = NotOkChecks;
        }
        public void CalcOfPercentage()
        {
            double NOKChecks = Convert.ToDouble(quantityOf_NOK_checks);
            double TotalChecks = Convert.ToDouble(quantityOf_Total_checks);

            if (TotalChecks == 0)
            {
                quantityOf_Total_checks = "Перевірок не було";
            }
            else
            {
                percentageOf_NOK_checks = Convert.ToInt32(100 - (100 / TotalChecks * NOKChecks));
            }

            //try
            //{
            //    int result = Convert.ToInt16(lblForResult.Text);
            //    if (result < nudGoal.Value)
            //    { lblForResult.ForeColor = Color.Red; }
            //    else if (result >= nudGoal.Value)
            //    { lblForResult.ForeColor = Color.Green; }
            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show($"За вказаний місяць користувач '{Name}' перевірок не проводив", "Увага!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
        public void Fill_dgv_with_NOK_inspections(DataGridView Destination, List<OverDue_Inspection> Results)
        {
            for (int i = 0; i < Results.Count; i++)
            {
                Destination.Rows.Add(_listOf_OverDueInspections[i]._article, _listOf_OverDueInspections[i]._quantity, _listOf_OverDueInspections[i]._materialdescription, _listOf_OverDueInspections[i]._batch, _listOf_OverDueInspections[i]._date_INCOME, Name, _listOf_OverDueInspections[i]._date_Inspection, (_listOf_OverDueInspections[i]._date_INCOME - _listOf_OverDueInspections[i]._date_Inspection));
            }
        }
    }
}

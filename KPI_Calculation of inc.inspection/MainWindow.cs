using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;

namespace KPI_Calculation_of_inc.inspection
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            string[] months = new string[12] { "Січень - 01", "Лютий - 02", "Березень - 03", "Квітень - 04", "Травень - 05", "Червень - 06", "Липень - 07", "Серпень - 08", "Вересень - 09", "Жовтень - 10", "Листопад - 11", "Грудень - 12", };
            cb_forTabPageMonth.DataSource = months;// випадаючий список місяців для фільтру
        }
        private void btn_Choose_File_Click(object sender, EventArgs e)//обираємо шлях до файлу
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.tb_Choose_File.Text = openFileDialog1.FileName;

                cb_spreedSheets.Items.Clear();

                string[] _listOfSheetsFromExcel = ExcelControls.Get_AllWorkSheetsFromExcel(openFileDialog1.FileName);
                cb_spreedSheets.Items.AddRange(_listOfSheetsFromExcel);
                cb_spreedSheets.SelectedIndex = 0;
            }
        }
        private void btn_Load_Excel_Click(object sender, EventArgs e)//вигружаємо дані з excel в DataGridView
        {
            dgv_DataFromExcel.DataSource = null;
            DataTable _dataTable = ExcelControls.Get_ExcelData(tb_Choose_File.Text, cb_spreedSheets.Text);

            if (_dataTable.Rows.Count == 0)
            {
                return;
            }

            _dataTable.Columns.Add("TimeOfEntry");

            for (int i = 0; i < _dataTable.Rows.Count; i++)
            {
                string _currentTime = _dataTable.Rows[i].ItemArray[9].ToString();
                string _justTime = _currentTime.Substring(_currentTime.Length - 8, 8);
                _dataTable.Rows[i].SetField<string>("TimeOfEntry", _justTime);
            }

            _dataTable.Columns.Remove("Time of Entry");

            dgv_DataFromExcel.DataSource = _dataTable;

            Methods.findInspectors(dgv_DataFromExcel, lb_checkers);
        }
        private void btn_calc_totalQty_of_inspections_Click(object sender, EventArgs e)//Рахуємо к-сть перевірок
        {
            dgv_results.Rows.Clear();

            User._listOf_OverDueInspections.Clear();//Видаляємо раніше обраних користувачів

            if (dgv_DataFromExcel.Rows.Count != 0)
            {
                dgv_nokInspections.Rows.Clear();// перед новим розрахунком очищаємо таблицю для нових результатів НОК перевірок
                progressBar1.Maximum = dgv_DataFromExcel.Rows.Count;

                ArrayList _selectedUsers = new ArrayList { };
                for (int i = 0; i < lb_checkers.SelectedItems.Count; i++)
                {
                    _selectedUsers.Add(lb_checkers.SelectedItems[i].ToString());
                }

                if (_selectedUsers.Count == 0)
                {
                    MessageBox.Show("Please, select needed people!");
                    return;
                }

                List<User> _listOfUsers = new List<User>();

                foreach (string item in _selectedUsers)
                {
                    User user = new User(item);
                    _listOfUsers.Add(user);
                    //Рахуємо загальну к-сть перевірок для поточного користувача
                    user.CalcOfTotalChecks(user.Name, cb_forTabPageMonth, dtp_forTabPageMonth, dgv_DataFromExcel);

                    //Рахуємо к-сть протермінованих перевірок
                    user.CalcOfNotOkChecks(user.Name, cb_forTabPageMonth, dtp_forTabPageMonth, dgv_DataFromExcel, progressBar1, lb_holidays, dgv_nokInspections);

                    ////Рахуємо відсоток протермінованих
                    user.CalcOfPercentage();

                    user.Fill_dgv_with_NOK_inspections(dgv_nokInspections, User._listOf_OverDueInspections);

                    progressBar1.Value = dgv_DataFromExcel.Rows.Count;
                }

                for (int i = 0; i < _listOfUsers.Count; i++)
                {
                    dgv_results.Rows.Add(_listOfUsers[i].Name, _listOfUsers[i].quantityOf_Total_checks, _listOfUsers[i].quantityOf_NOK_checks, _listOfUsers[i].percentageOf_NOK_checks);
                }

                HighlightResults(dgv_results, "Percentage", Convert.ToInt32(nud_minGoal.Value));
            }
            else
            {
                MessageBox.Show("Завантажте дані з excel-таблиці\nВиконайте КРОК 1", "Увага!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_chooseHoliday_Click(object sender, EventArgs e)
        {
            string _selectedItem = dtp_holidays.Value.ToShortDateString();//змінна для зберігання вибраної дати в DateTimePicker
            DateTime _day = Convert.ToDateTime(_selectedItem); // конвертуємо дату в формат DateTime

            if (_day.DayOfWeek.ToString() == "Saturday" || _day.DayOfWeek.ToString() == "Sunday")
            {
                MessageBox.Show("Ви й так вибрали вихідний день!!!");
            }
            else
            {
                bool IsAlreadyExist = lb_holidays.Items.Contains(_selectedItem);
                if (IsAlreadyExist)
                {
                    MessageBox.Show("Ця дата вже є у списку!");
                }
                else
                {
                    lb_holidays.Items.Add(_selectedItem);
                }
            }
        }
        private void btn_deleteHoliday_Click(object sender, EventArgs e)
        {
            if (lb_holidays.SelectedIndex == -1)
            {
                MessageBox.Show("Оберіть дату для видалення");
            }
            else
            {
                lb_holidays.Items.RemoveAt(lb_holidays.SelectedIndex);
            }
        }
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void інфоПроПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Програма була створена для підрахунку проміжних результатів цілі 'Вчасність вхідного контролю'", "Інфо про програму", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void btn_UnSelectSelectedUsers_Click(object sender, EventArgs e)
        {
            lb_checkers.SelectedItems.Clear();
        }
        private void HighlightResults(DataGridView NameOfDGV, string NameOfHeader, int minValue)
        {
            for (int i = 0; i < NameOfDGV.RowCount - 1; i++)
            {
                int _currentValue = Convert.ToInt16(NameOfDGV[NameOfHeader, i].Value);

                if (_currentValue > minValue)
                {
                    NameOfDGV.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    NameOfDGV.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}

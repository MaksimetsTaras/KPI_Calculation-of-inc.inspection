using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI_Calculation_of_inc.inspection
{
    class OverDue_Inspection
    {
        public OverDue_Inspection(string article, string quantity, string material_description, string batch, DateTime dateOf_INCOME, DateTime dateOf_Inspection)
        {
            _article = article;
            _quantity = quantity;
            _materialdescription = material_description;
            _batch = batch;
            _date_INCOME = dateOf_INCOME;
            _date_Inspection = dateOf_Inspection;
            DurationOf_Inspection = (dateOf_Inspection - dateOf_INCOME).ToString();
        }

        public readonly string _article;
        public readonly string _quantity;
        public readonly string _materialdescription;
        public readonly string _batch;
        public readonly DateTime _date_INCOME;
        public readonly DateTime _date_Inspection;
        public string DurationOf_Inspection;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.TaxCalculator.App.DataModels;

namespace DTD.TaxCalculator.App.Pages
{
    public partial class Page5 : UserControl
    {
        public static List<Schedule24AData> DataSource { get; set; }
        private Schedule24AData Total { get; set; }

        public Page5()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            if (DataSource == null)
                DataSource = new List<Schedule24AData>
                {
                    new Schedule24AData("Basic pay"),
                    new Schedule24AData("Special pay"),
                    new Schedule24AData("Arrear pay(if not included in taxable income earlier)"),
                    new Schedule24AData("Dearness allowance"),
                    new Schedule24AData("House rent allowance"),
                    new Schedule24AData("Medical allowance"),
                    new Schedule24AData("Conveyance allowance"),
                    new Schedule24AData("Festival allowance"),
                    new Schedule24AData("Entertainment"),
                    new Schedule24AData("Leave allowance"),
                    new Schedule24AData("Honorarium/Reward/Fee"),
                    new Schedule24AData("Overtime allowance"),
                    new Schedule24AData("Bonus/Ex-gratia"),
                    new Schedule24AData("Other allowances"),
                    new Schedule24AData("Employer's contribution to a recognized provident fund"),
                    new Schedule24AData("Interest on Savings account"),
                    new Schedule24AData("Interest on Fixed Deposit"),
                    new Schedule24AData("Interest on DPS"),
                    new Schedule24AData("Interest accrued on a recognized provident fund"),
                    new Schedule24AData("Deemed income for free furnished/unfurnished accommodation"),
                    new Schedule24AData("Other,If any(give detail"),
                    new Schedule24AData("Total")
                };

            Total = DataSource[DataSource.Count - 1];
            dataGridView1.DataSource = DataSource;
            dataGridView1.CellValidated += DataGridView1_CellValidated;
            DatagridConfig();


        }

        private void DataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            Total.Amount = DataSource.Where(r=>r.Particulars!="Total").Sum(r=>r.Amount);
            Total.TaxExempted = DataSource.Where(r => r.Particulars != "Total").Sum(r => r.TaxExempted);
            dataGridView1.Refresh();
        }

        private void DatagridConfig()
        {
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;

            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N0"
            };

            dataGridView1.Columns[1].DefaultCellStyle = dataGridViewCellStyle;
            dataGridView1.Columns[2].DefaultCellStyle = dataGridViewCellStyle;
            dataGridView1.Columns[3].DefaultCellStyle = dataGridViewCellStyle;


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.TaxCalculator.App.Pages;

namespace DTD.TaxCalculator.App
{
    public partial class TaxForm : Form
    {
        public TaxForm()
        {
            InitializeComponent();
            Page1_Click(new object(), new EventArgs());
        }



        private void Page1_Click(object sender, EventArgs e)
        {
            Page1 page1 = new Page1() { Dock = DockStyle.Top };
            PagePanel.Controls.Clear();
            PagePanel.Controls.Add(page1);
        }
    }
}

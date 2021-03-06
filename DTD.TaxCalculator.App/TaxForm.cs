﻿using System;
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

        private void Page2_Click(object sender, EventArgs e)
        {
            Page2 page2 = new Page2() { Dock = DockStyle.Top };
            PagePanel.Controls.Clear();
            PagePanel.Controls.Add(page2);
        }

        private void Page3_Click(object sender, EventArgs e)
        {
            Page3 page3 = new Page3() { Dock = DockStyle.Top };
            PagePanel.Controls.Clear();
            PagePanel.Controls.Add(page3);
        }

        private void Page5_Click(object sender, EventArgs e)
        {
            Page5 page5 = new Page5() { Dock = DockStyle.Top };
            PagePanel.Controls.Clear();
            PagePanel.Controls.Add(page5);
        }

        private void Page8_Click(object sender, EventArgs e)
        {
            Page8 page8 = new Page8() { Dock = DockStyle.Top };
            PagePanel.Controls.Clear();
            PagePanel.Controls.Add(page8);
        }

        private void Page11_Click(object sender, EventArgs e)
        {
            Page11 page11 = new Page11() { Dock = DockStyle.Top };
            PagePanel.Controls.Clear();
            PagePanel.Controls.Add(page11);
        }

    
    }
}

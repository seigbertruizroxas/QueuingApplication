using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QueuingApplication
{
    public partial class SpecificCashierWindow : Form
    {
        public SpecificCashierWindow()
        {
            InitializeComponent();

           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                lblNowServing.Text = CashierClass.CashierQueue.Peek().ToString();
            }
            else
            {
                lblNowServing.Text = "No queue";
            }
        }
    }
}

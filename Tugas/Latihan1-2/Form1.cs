using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (vScrollBar1.Value < vScrollBar2.Value)
            {
                label1.Text = vScrollBar1.Value.ToString();
                label2.Text = vScrollBar2.Value.ToString();
            }
            else
            { label1.Text = vScrollBar2.Value.ToString();
                label2.Text = vScrollBar1.Value.ToString();

            }
            DateTime tmp = new DateTime();
            tmp = new DateTime(DateTime.Today.Year + Math.Abs(vScrollBar1.Value - vScrollBar2.Value), DateTime.Today.Month, DateTime.Today.Day);
            dateTimePicker1.MinDate = DateTime.Today.Date;
            dateTimePicker1.MaxDate = tmp;
            label3.Text = Convert.ToString(DateTime.Today.Year + Math.Abs((vScrollBar1.Value - vScrollBar2.Value)));

        } 
        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            if (vScrollBar1.Value > vScrollBar2.Value)
            {
                label1.Text = vScrollBar1.Value.ToString();
                label2.Text = vScrollBar2.Value.ToString();
            }
            else
            {
                label1.Text = vScrollBar2.Value.ToString();
                label2.Text = vScrollBar1.Value.ToString();

            }
            DateTime tmp = new DateTime();
            tmp = new DateTime(DateTime.Today.Year + Math.Abs(vScrollBar1.Value - vScrollBar2.Value), DateTime.Today.Month, DateTime.Today.Day);
            dateTimePicker1.MinDate = DateTime.Today.Date;
            dateTimePicker1.MaxDate = tmp;
            label3.Text = Convert.ToString(DateTime.Today.Year + Math.Abs((vScrollBar1.Value - vScrollBar2.Value)));
        }
    }
}

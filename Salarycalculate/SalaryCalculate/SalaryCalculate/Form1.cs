﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalaryEmployee s = new SalaryEmployee("Ali", "Ahmadi", "124225", 2000000);
            hourlyEmployee h = new hourlyEmployee("Farshid", "Rezayee", "43378484", 50000, 54);
            ClommisionEmployee c = new ClommisionEmployee("Hassan", "Fadayee", "3677373", 45788888, .4);
            BaseplusCommisionEmployee b = new BaseplusCommisionEmployee("Neda", "Saghari", "676869", 500000, .4, 600000);
            label1.Text += s.ToString() + "\n Salary" + s.Earning();
            label1.Text += h.ToString() + "\n Salary" + h.Earning();
            label1.Text += c.ToString() + "\n Salary" + c.Earning();
            label1.Text += b.ToString() + "\n Salary" + b.Earning();
        }
    }
}

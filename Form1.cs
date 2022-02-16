using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _02计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJiSuan_Click(object sender, EventArgs e)
        {
            


            // 采集用户的输入
            int n1 = Convert.ToInt32(txtNum1.Text.Trim());
            int n2 = int.Parse(txtNum2.Text.Trim());
            Calculator cal = new Calculator(n1, n2);
            switch (cboCaoZuoFu.Text.Trim())
            {
                case "+":
                    lblResult.Text = cal.Add().ToString();
                    break;
                case "-":
                    break;
            }



        }
    }
}

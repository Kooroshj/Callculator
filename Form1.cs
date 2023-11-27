using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        ICalculate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }
        public bool check()
        {
            bool isvalid = true;

            if (txtnum1.Value == 0 || txtnum2.Value == 0)
            {
                isvalid = false;
                MessageBox.Show("لطفا اعداد خود را وارد کنید!!!");
               
            }
            return isvalid;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            int num1 , num2;
            num1 = Convert.ToInt32(txtnum1.Value);
            num2 = Convert.ToInt32(txtnum2.Value);
            if (check()==true)
            {
               
                MessageBox.Show("جواب برابر است با : "+Convert.ToString(calculate.plus(num1,num2)));


            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtnum1.Value);
            num2 = Convert.ToInt32(txtnum2.Value);
            if (check() == true)
            {
               
                MessageBox.Show("جواب برابر است با : "+Convert.ToString(calculate.minus(num1, num2)));
                

            }
        }

        private void btnzarb_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtnum1.Value);
            num2 = Convert.ToInt32(txtnum2.Value);
            
            if (check())
            {
                
                MessageBox.Show("جواب برابر است با : "+ Convert.ToString(calculate.zarb(num1, num2)));


            }
        }

        private void btntaghsim_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtnum1.Value);
            num2 = Convert.ToInt32(txtnum2.Value);
            if (check() == true)
            {
              
                MessageBox.Show("جواب برابر است با : "+Convert.ToString(calculate.taghsim(num1, num2)));


            }
        }
    }
}

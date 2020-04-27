using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax_calculator_v2._2
{
    public partial class Form1 : Form
    {
        int i;
        int a;      //weird number at the beginning
        float b;    //percentage as decimal
        int c;      //final figure or something
        float d;    //difference 8)
        float k;

        float datsum;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32.TryParse(inputText.Text, out i);
            if (Enumerable.Range(0, 18200).Contains(i))      //"tax free threshold"
            {
                a = 0;
                b = 0;
                c = 0;
                row.Text = "1st bracket";
            }
            if (Enumerable.Range(18201, 37000).Contains(i))
            {
                a = 0;
                b = 0.19f;
                c = 18200;
                row.Text = "2nd bracket";
            }
            if (Enumerable.Range(37001, 80000).Contains(i))
            {
                a = 3572;
                b = 0.325f;
                c = 37000;
                row.Text = "3rd bracket";
            }
            if (Enumerable.Range(80001, 180000).Contains(i))
            {
                a = 17547;
                b = 0.37f;
                c = 80000;
                row.Text = "4th bracket";
            }
            if (i > 180001)
            {
                a = 54547;
                b = 0.45f;
                c = 180000;
                row.Text = "5th bracket";
            }

            //now things get algorythmic ( ͡° ͜ʖ ͡°)
            d = i - c;

            datsum = a + b * d;

            float iat;
            iat = i - datsum;
            k = iat / i * 100;

            //and returning the values
            sum.Text = "Total tax: $" + datsum.ToString();
            perc.Text = "income after tax / taxable income: " + k.ToString() + "%";
            afterTax.Text = "income after tax: $" + iat.ToString();
        }
    }
}

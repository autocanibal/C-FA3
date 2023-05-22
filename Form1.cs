using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_FA3
{
    
    public partial class Form1 : Form
    {
        public static string outputTxt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            double salesDouble = double.Parse(salesAmnt.Text);
            double taxDouble = Decimal.ToDouble(salesTaxAmnt.Value);
            double tax = Math.Round((Double)taxDouble / 100 * salesDouble, 2);
            double newSales = Math.Round((Double)salesDouble + tax, 2);
            outputTxt = "Tax on R"+salesAmnt.Text+" at " + salesTaxAmnt.Value+"% is R"+tax+"\nThe total is R"+newSales;
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.salesTaxAmnt.Value = 0;
            this.salesAmnt.Text = "";
        }

    }
}

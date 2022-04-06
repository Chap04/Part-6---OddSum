using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_6___OddSum
{
    public partial class frmOddSum : Form
    {
        public frmOddSum()
        {
            InitializeComponent();
        }
        int numberStore;
        int number;
        int numberSum;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtInput.Text, out numberStore))
            {
                for (number = 1; number <= numberStore; number += 2)
                {
                    numberSum += number;
                }
                lblOutput.Text = ($"The sum of the odd numbers from 1 to {numberStore} is {numberSum}");
            }
        }
    }
}

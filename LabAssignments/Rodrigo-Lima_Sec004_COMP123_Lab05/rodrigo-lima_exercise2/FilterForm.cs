using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rodrigo_lima_exercise2
{
    public partial class FilterForm : Form
    {
        public double MinSellPrice { get; set; }

        public FilterForm()
        {
            InitializeComponent();
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(MinSellPrice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Prevent empty error
            if (textBox1.Text == null || textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            // Check if value is a valid double
            if (double.TryParse(textBox1.Text, out double min) || min > 0)
            {
                this.MinSellPrice = min;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                textBox1.Focus();
                MessageBox.Show(this, "Mim. Selling price is invalid", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

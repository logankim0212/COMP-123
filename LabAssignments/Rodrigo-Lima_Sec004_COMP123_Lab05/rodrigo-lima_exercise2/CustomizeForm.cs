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
    public partial class CustomizeForm : Form
    {
        public Color BtnForeColor { get; set; }
        public Color BtnBackColor { get; set; }
        public Color FormBackColor { get; set; }
        public Color LabelColor { get; set; }

        public CustomizeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BtnForeColor = Color.AliceBlue;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CustomizeForm_Load(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
        }
    }
}

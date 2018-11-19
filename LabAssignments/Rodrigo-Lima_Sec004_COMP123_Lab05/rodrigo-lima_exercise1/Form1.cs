using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rodrigo_lima_exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                label3.Text = folderBrowserDialog1.SelectedPath;

                showFilesFromDir(folderBrowserDialog1.SelectedPath);
            }
        }

        private void showFilesFromDir(string dir)
        {
            // Get dir files
            string[] files = Directory.GetFiles(dir);

            // Clear the files list
            checkedListBox1.Items.Clear();

            foreach (var file in files)
            {
                checkedListBox1.Items.Add(file);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Uncheck all items
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }

            // Check selected
            checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);

            // Get item information
            string filename = (string) checkedListBox1.Items[checkedListBox1.SelectedIndex];
            label1.Text = $"{filename} was created {File.GetCreationTime(filename).ToString("MM-dd-yyyy HH:mm:ss")}";
        }
    }
}

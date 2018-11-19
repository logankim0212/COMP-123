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

namespace rodrigo_lima_exercise2
{
    public partial class Form1 : Form
    {
        // Filters
        public double MinSellPrice { get; set; }

        // Colors
        public Color BtnForeColor { get; set; }
        public Color BtnBackColor { get; set; }
        public Color FormBackColor { get; set; }
        public Color LabelColor { get; set; }

        public Form1()
        {
            InitializeComponent();
            loadItems();
        }

        private string getFileName()
        {
            string path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            if (Environment.OSVersion.Version.Major >= 6)
            {
                path = Directory.GetParent(path).ToString();
            }
            path = Path.Combine(path, "INVENTORY.DAT");
            label5.Text = path;
            return path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
     
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;

            textBox1.Focus();

            button3.Enabled = true;
        }

        private int numberIndex(int number)
        {
            if (!File.Exists(getFileName()))
            {
                return -1;
            }

            string[] lines = File.ReadAllLines(getFileName());

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Split('|')[0] == Convert.ToString(number))
                {
                    return i;
                }
            }

            return -1;
        }

        private bool numberExists(int number)
        {
            return numberIndex(number) != -1;
        }

        private void saveItem()
        {
            // Validade
            if (!int.TryParse(textBox1.Text, out int number))
            {
                textBox1.Focus();
                MessageBox.Show(this, "Number is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox2.Text == null || textBox2.Text.Length == 0)
            {
                textBox2.Focus();
                MessageBox.Show(this, "Description is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Double.TryParse(textBox3.Text, out double price))
            {
                textBox3.Focus();
                MessageBox.Show(this, "Price is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create the Inventory object
            Inventory inv = new Inventory
            {
                Number = number,
                Description = textBox2.Text,
                Price = price
            };

            // Build new line
            var newLine = $"{inv.Number}|{inv.Description}|{inv.Price}";

            // Update
            if (numberExists(inv.Number))
            {
                string[] lines = File.ReadAllLines(getFileName());
                lines[numberIndex(inv.Number)] = newLine;
                File.WriteAllLines(getFileName(), lines);
            }
            // Insert
            else
            {
                File.AppendAllText(getFileName(), $"{newLine}\n");
            }

            // Controls
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            button3.Enabled = false;
        }

        private void loadItems(string[] items = null)
        {
            // Clear all items
            listView1.Items.Clear();

            if (!File.Exists(getFileName()))
            {
                button2.Enabled = false;
                return;
            }

            string[] invs = null;
            if (items != null)
            {
                invs = items;
            }
            else
            {
                invs = File.ReadAllLines(getFileName());
            }
            foreach (var inv in invs)
            {
                // Convert line to Invetory object
                string[] line = inv.Split('|');
                Inventory inventory = new Inventory();
                inventory.Number = int.Parse(line[0]);
                inventory.Description = line[1];
                inventory.Price = double.Parse(line[2]);

                // Add to list
                ListViewItem item = new ListViewItem(Convert.ToString(inventory.Number));
                item.SubItems.Add(inventory.Description);
                item.SubItems.Add($"{inventory.Price:C2}");
                listView1.Items.Add(item);
            }

            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveItem();
            loadItems();
            resetFilter();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hitTest = listView1.HitTest(e.Location);
            if (hitTest.Item != null)
            {
                textBox1.Text = hitTest.Item.Text;
                textBox2.Text = hitTest.Item.SubItems[1].Text;
                textBox3.Text = hitTest.Item.SubItems[2].Text.Replace("$", "");

                textBox1.Enabled = false;
                textBox2.Enabled = true;
                textBox3.Enabled = true;

                button3.Enabled = true;

                textBox2.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int number = int.Parse(listView1.SelectedItems[0].Text);
                if (MessageBox.Show(this, $"Delete '{listView1.SelectedItems[0].SubItems[1].Text}'?", "Confirm", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // Remove item from file
                    int index = numberIndex(number);
                    List<string> temp = File.ReadAllLines(getFileName()).ToList();
                    temp.RemoveAt(index);
                    string[] lines = temp.ToArray();
                    File.WriteAllLines(getFileName(), lines);

                    // Remove item from list
                    listView1.SelectedItems[0].Remove();
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button4, new Point(0, button4.Height));
        }

        private void minimumSellingPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterForm f = new FilterForm();
            f.MinSellPrice = MinSellPrice;
            if (f.ShowDialog() == DialogResult.OK)
            {
                // Store min sell price value to later use
                MinSellPrice = f.MinSellPrice;

                // Filter
                var filteredList = File.ReadAllLines(getFileName()).ToList()
                    .Where(x => Convert.ToDouble(x.Split('|')[2]) >= MinSellPrice);

                loadItems(filteredList.ToArray());
            }

            configureFilterButton();
        }

        private void configureFilterButton()
        {
            if (MinSellPrice > 0)
            {
                button4.BackColor = Color.Red;
                button4.ForeColor = Color.White;
                button4.Text = "Filtering";
            }
            else
            {
                button4.BackColor = SystemColors.Control;
                button4.ForeColor = SystemColors.ControlText;
                button4.Text = "Filter";
            }
        }

        private void resetFilter()
        {
            MinSellPrice = 0;
            configureFilterButton();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CustomizeForm f = new CustomizeForm();

            f.BtnForeColor = this.BtnForeColor;
            f.BtnBackColor = this.BtnBackColor;
            f.FormBackColor = this.FormBackColor;
            f.LabelColor = this.LabelColor;

            if (f.ShowDialog() == DialogResult.OK)
            {

            }

        }
    }
}

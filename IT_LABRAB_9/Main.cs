using IT_LABRAB_9.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_LABRAB_9
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            dataGridView1.DataSource = ProductionData.ReadAllProduction();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Enterprises();
            form.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new Products();
            form.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductionData.ReadProductionByYear(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddProduction();

            foreach (var p in ProductData.ReadAllProducts())
            {
                form.comboBox1.Items.Add(p.ProductName);
            }

            foreach (var p in EnterprisesData.ReadAllEnterprises())
            {
                form.comboBox2.Items.Add(p.Name);
            }

            if (form.ShowDialog() == DialogResult.OK)
            {
                var p = new Production();
                p.Volume = int.Parse(form.textBox2.Text);
                p.Year = int.Parse(form.textBox1.Text);
                p.EnterpriseCode = EnterprisesData.ReadAllEnterprises()[form.comboBox2.SelectedIndex].Code;
                p.ProductCode = ProductData.ReadAllProducts()[form.comboBox1.SelectedIndex].ProductCode;
                ProductionData.AddProduct(p);
                dataGridView1.DataSource = ProductionData.ReadAllProduction();
            }
            //NotesGrid.DataSource = taskData.ReadAllTasks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ids = new List<int>();
            var selected = dataGridView1.SelectedRows;
            foreach (DataGridViewRow row in selected)
            {
                ids.Add((int)row.Cells["ProductCode"].Value);
            }

            foreach (var id in ids)
            {
                ProductionData.Delete(id);
            }

            dataGridView1.DataSource = ProductionData.ReadAllProduction();
        }
    }
}

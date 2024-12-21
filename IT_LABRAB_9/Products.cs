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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            dataGridView1.DataSource = ProductData.ReadAllProducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {

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
                ProductData.Delete(id);
            }

            dataGridView1.DataSource = ProductData.ReadAllProducts();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddProduct();

            if (form.ShowDialog() == DialogResult.OK)
            {
                var p = new Product();
                p.ProductName = form.Name.Text;
                p.ProductCode = int.Parse(form.Code.Text);
                p.IsStandard = int.Parse(form.IsStandart.Text) == 1 ? true : false;
                p.Note = form.Note.Text;
                p.AnnualProductionVolume = int.Parse(form.AnnualProductionVolume.Text);

                ProductData.AddProduct(p);
                dataGridView1.DataSource = ProductData.ReadAllProducts();
            }
        }
    }
}

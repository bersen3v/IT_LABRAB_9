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
    public partial class Enterprises : Form
    {
        public Enterprises()
        {
            InitializeComponent();
            dataGridView1.DataSource = EnterprisesData.ReadAllEnterprises();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ids = new List<int>();
            var selected = dataGridView1.SelectedRows;
            foreach (DataGridViewRow row in selected)
            {
                ids.Add((int)row.Cells["Code"].Value);
            }

            foreach (var id in ids)
            {
                EnterprisesData.Delete(id);
            }

            dataGridView1.DataSource = EnterprisesData.ReadAllEnterprises();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddEnterprise();

            if (form.ShowDialog() == DialogResult.OK)
            {
                var p = new Enterprise();
                p.Code = int.Parse(form.Code.Text);
                p.Name = form.Name.Text;
                p.Address = form.Adress.Text;
                p.Phone = form.Phone.Text;
                EnterprisesData.AddEnterprise(p);
                dataGridView1.DataSource = EnterprisesData.ReadAllEnterprises();
            }
        }
    }
}

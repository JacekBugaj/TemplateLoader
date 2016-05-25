using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateLoader.Model;

namespace TemplateLoader
{
    public partial class Form1 : Form
    {
        TemplateLoaderDbContext db = new TemplateLoaderDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowClients_Click(object sender, EventArgs e)
        {
            var customers = (from c in db.Customers select c).ToList();
            dataGridView1.DataSource = customers;
        }
    }
}

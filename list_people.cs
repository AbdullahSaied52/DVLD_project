using bussiness_layer_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_project_1
{
    public partial class list_people : Form
    {
        public list_people()
        {
            InitializeComponent();
        }

        private void list_people_Load(object sender, EventArgs e)
        {
            _refresh();
        }
        private void _refresh()
        {
            dataGridView1.DataSource=ClsBussiness.list_all();
        }
    }
}

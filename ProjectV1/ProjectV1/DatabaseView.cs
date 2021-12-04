using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectV1
{
    public partial class DatabaseView : Form
    {
        DataSet dataSet = new DataSet();
        public DatabaseView()
        {
            InitializeComponent();
        }

        private void DatabaseView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentDBDataSet.Student);

        }
    }
}

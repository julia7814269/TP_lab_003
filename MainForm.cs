using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void button_ShowRoadData(object sender, EventArgs e)
        {
            RoadForm roadForm = new RoadForm();
            roadForm.ShowDialog();
        }
        private void button_ShowTempData(object sender, EventArgs e)
        {
            TempForm tempForm = new TempForm();
            tempForm.ShowDialog();
        }
    }
}
